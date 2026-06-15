using Npgsql;
using AgroGrandong.Models;

namespace AgroGrandong.Repositories
{
    public class BookingRepository : BaseRepository, IRepository<Booking>
    {
        private const string SEL = @"SELECT booking_id,schedule_id,user_id,booking_date,estimated_weight,
            actual_weight,total_price,status,notes,created_at,updated_at FROM bookings";

        private Booking Map(NpgsqlDataReader r) => new()
        {
            BookingId = r.GetInt32(0), ScheduleId = r.GetInt32(1), UserId = r.GetInt32(2),
            BookingDate = r.GetDateTime(3), EstimatedWeight = r.GetDecimal(4),
            ActualWeight = r.IsDBNull(5) ? null : r.GetDecimal(5),
            TotalPrice = r.IsDBNull(6) ? null : r.GetDecimal(6),
            Status = r.GetString(7), Notes = r.IsDBNull(8) ? null : r.GetString(8),
            CreatedAt = r.GetDateTime(9), UpdatedAt = r.GetDateTime(10)
        };

        public List<Booking> GetAll()
        {
            var list = new List<Booking>();
            using var conn = GetConn(); conn.Open();
            using var cmd = new NpgsqlCommand($"{SEL} ORDER BY booking_date DESC", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(Map(r));
            return list;
        }

        public List<Booking> GetByUser(int uid)
        {
            var list = new List<Booking>();
            using var conn = GetConn(); conn.Open();
            using var cmd = new NpgsqlCommand($"{SEL} WHERE user_id=@uid ORDER BY booking_date DESC", conn);
            cmd.Parameters.AddWithValue("uid", uid);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(Map(r));
            return list;
        }

        public bool Add(Booking b)
        {
            using var conn = GetConn(); conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                decimal price = 0;
                using (var cmd = new NpgsqlCommand("SELECT price_per_kg FROM schedules WHERE schedule_id=@s", conn, tx))
                { cmd.Parameters.AddWithValue("s", b.ScheduleId); price = (decimal)(cmd.ExecuteScalar() ?? 0); }

                using (var cmd = new NpgsqlCommand("INSERT INTO bookings(schedule_id,user_id,estimated_weight,total_price,notes) VALUES(@a,@b,@c,@d,@e)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("a", b.ScheduleId); cmd.Parameters.AddWithValue("b", b.UserId);
                    cmd.Parameters.AddWithValue("c", b.EstimatedWeight); cmd.Parameters.AddWithValue("d", b.EstimatedWeight * price);
                    cmd.Parameters.Add(new NpgsqlParameter("e", b.Notes ?? (object)DBNull.Value));
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new NpgsqlCommand("UPDATE schedules SET current_booking=current_booking+1, status=CASE WHEN current_booking+1>=capacity THEN 'full' ELSE status END WHERE schedule_id=@s", conn, tx))
                { cmd.Parameters.AddWithValue("s", b.ScheduleId); cmd.ExecuteNonQuery(); }

                tx.Commit(); return true;
            }
            catch { tx.Rollback(); return false; }
        }

        public bool UpdateStatus(int id, string status, decimal? weight = null, decimal? total = null) => Exec(
            "UPDATE bookings SET status=@a,actual_weight=@b,total_price=@c,updated_at=NOW() WHERE booking_id=@id",
            ("id", id), ("a", status), ("b", weight), ("c", total)) > 0;

        public bool Delete(int id) => CancelBooking(id);

        public bool CancelBooking(int id)
        {
            using var conn = GetConn(); conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                using (var cmd = new NpgsqlCommand("SELECT schedule_id FROM bookings WHERE booking_id=@id", conn, tx))
                { cmd.Parameters.AddWithValue("id", id); var res = cmd.ExecuteScalar(); if (res == null) return false;
                  int sid = (int)res;
                  new NpgsqlCommand($"UPDATE bookings SET status='cancelled',updated_at=NOW() WHERE booking_id={id}", conn, tx).ExecuteNonQuery();
                  new NpgsqlCommand($"UPDATE schedules SET current_booking=current_booking-1, status=CASE WHEN status='full' THEN 'available' ELSE status END WHERE schedule_id={sid}", conn, tx).ExecuteNonQuery();
                }
                tx.Commit(); return true;
            }
            catch { tx.Rollback(); return false; }
        }

        public bool DeletePermanent(int id)
        {
            using var conn = GetConn(); conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                string status = ""; int sid = 0;
                using (var cmd = new NpgsqlCommand("SELECT status,schedule_id FROM bookings WHERE booking_id=@id", conn, tx))
                { cmd.Parameters.AddWithValue("id", id); using var r = cmd.ExecuteReader();
                  if (!r.Read()) return false; status = r.GetString(0); sid = r.GetInt32(1); }

                if (status == "pending" || status == "confirmed")
                    new NpgsqlCommand($"UPDATE schedules SET current_booking=current_booking-1, status=CASE WHEN status='full' THEN 'available' ELSE status END WHERE schedule_id={sid}", conn, tx).ExecuteNonQuery();

                new NpgsqlCommand($"DELETE FROM bookings WHERE booking_id={id}", conn, tx).ExecuteNonQuery();
                tx.Commit(); return true;
            }
            catch { tx.Rollback(); return false; }
        }
    }
}
