using Npgsql;
using AgroGrandong.Models;

namespace AgroGrandong.Repositories
{
    public class ScheduleRepository : BaseRepository, IRepository<Schedule>
    {
        private const string SEL = @"SELECT schedule_id,location,address,schedule_date,start_time,end_time,
            capacity,current_booking,price_per_kg,status,notes,created_by,created_at,updated_at FROM schedules";

        private Schedule Map(NpgsqlDataReader r) => new()
        {
            ScheduleId = r.GetInt32(0), Location = r.GetString(1), Address = r.GetString(2),
            ScheduleDate = r.GetDateTime(3), StartTime = r.GetTimeSpan(4), EndTime = r.GetTimeSpan(5),
            Capacity = r.GetInt32(6), CurrentBooking = r.GetInt32(7), PricePerKg = r.GetDecimal(8),
            Status = r.GetString(9), Notes = r.IsDBNull(10) ? null : r.GetString(10),
            CreatedBy = r.GetInt32(11), CreatedAt = r.GetDateTime(12), UpdatedAt = r.GetDateTime(13)
        };

        private List<Schedule> Query(string where = "")
        {
            var list = new List<Schedule>();
            using var conn = GetConn(); conn.Open();
            using var cmd = new NpgsqlCommand($"{SEL} {where} ORDER BY schedule_id ASC", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(Map(r));
            return list;
        }

        public List<Schedule> GetAll() => Query();
        public List<Schedule> GetAvailable()
        {
            var all = Query("WHERE status='available' AND current_booking<capacity");
            var now = DateTime.Now;
            return all.Where(s =>
                s.ScheduleDate.Date > now.Date ||
                (s.ScheduleDate.Date == now.Date && s.StartTime > now.TimeOfDay)
            ).ToList();
        }

        public bool Add(Schedule s) => Exec(
            "INSERT INTO schedules(location,address,schedule_date,start_time,end_time,capacity,price_per_kg,notes,created_by) VALUES(@a,@b,@c,@d,@e,@f,@g,@h,@i)",
            ("a", s.Location), ("b", s.Address), ("c", s.ScheduleDate.Date),
            ("d", s.StartTime), ("e", s.EndTime), ("f", s.Capacity),
            ("g", s.PricePerKg), ("h", s.Notes), ("i", s.CreatedBy)) > 0;

        public bool Update(Schedule s) => Exec(
            "UPDATE schedules SET location=@a,address=@b,schedule_date=@c,start_time=@d,end_time=@e,capacity=@f,price_per_kg=@g,status=@h,notes=@i,updated_at=NOW() WHERE schedule_id=@id",
            ("id", s.ScheduleId), ("a", s.Location), ("b", s.Address), ("c", s.ScheduleDate.Date),
            ("d", s.StartTime), ("e", s.EndTime), ("f", s.Capacity),
            ("g", s.PricePerKg), ("h", s.Status), ("i", s.Notes)) > 0;

        public bool Delete(int id)
        {
            using var conn = GetConn(); conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                new NpgsqlCommand("DELETE FROM bookings WHERE schedule_id=" + id, conn, tx).ExecuteNonQuery();
                new NpgsqlCommand("DELETE FROM schedules WHERE schedule_id=" + id, conn, tx).ExecuteNonQuery();
                tx.Commit(); return true;
            }
            catch { tx.Rollback(); return false; }
        }
    }
}
