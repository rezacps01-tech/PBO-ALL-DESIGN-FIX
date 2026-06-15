using Npgsql;
using AgroGrandong.Models;

namespace AgroGrandong.Repositories
{
    public class UserRepository : BaseRepository, IRepository<User>
    {
        private const string SEL = @"SELECT u.user_id, u.username, u.password, u.full_name,
            u.phone, u.address, u.role_id, r.role_name, u.is_active, u.created_at, u.updated_at
            FROM users u JOIN roles r ON u.role_id = r.role_id";

        private User Map(NpgsqlDataReader r) => new()
        {
            UserId = r.GetInt32(0), Username = r.GetString(1), Password = r.GetString(2),
            FullName = r.GetString(3), Phone = r.IsDBNull(4) ? null : r.GetString(4),
            Address = r.IsDBNull(5) ? null : r.GetString(5), RoleId = r.GetInt32(6),
            RoleName = r.GetString(7), IsActive = r.GetBoolean(8),
            CreatedAt = r.GetDateTime(9), UpdatedAt = r.GetDateTime(10)
        };

        public User? Login(string user, string pass)
        {
            using var conn = GetConn(); conn.Open();
            using var cmd = new NpgsqlCommand($"{SEL} WHERE u.username=@u AND u.password=@p AND u.is_active=true", conn);
            cmd.Parameters.AddWithValue("u", user);
            cmd.Parameters.AddWithValue("p", pass);
            using var r = cmd.ExecuteReader();
            return r.Read() ? Map(r) : null;
        }

        public List<User> GetAll()
        {
            var list = new List<User>();
            using var conn = GetConn(); conn.Open();
            using var cmd = new NpgsqlCommand($"{SEL} ORDER BY u.user_id", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read()) list.Add(Map(r));
            return list;
        }

        public bool Add(User u) => Exec(
            "INSERT INTO users(username,password,full_name,phone,address,role_id) VALUES(@a,@b,@c,@d,@e,@f)",
            ("a", u.Username), ("b", u.Password), ("c", u.FullName),
            ("d", u.Phone), ("e", u.Address), ("f", u.RoleId)) > 0;

        public bool Update(User u) => Exec(
            "UPDATE users SET username=@a,password=@b,full_name=@c,phone=@d,address=@e,role_id=@f,is_active=@g,updated_at=NOW() WHERE user_id=@id",
            ("id", u.UserId), ("a", u.Username), ("b", u.Password), ("c", u.FullName),
            ("d", u.Phone), ("e", u.Address), ("f", u.RoleId), ("g", u.IsActive)) > 0;

        public bool Delete(int id) => Exec("UPDATE users SET is_active=false WHERE user_id=@id", ("id", id)) > 0;

        public bool DeletePermanent(int id)
        {
            using var conn = GetConn(); conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                new NpgsqlCommand("DELETE FROM bookings WHERE user_id=" + id, conn, tx).ExecuteNonQuery();
                new NpgsqlCommand("DELETE FROM users WHERE user_id=" + id, conn, tx).ExecuteNonQuery();
                tx.Commit(); return true;
            }
            catch { tx.Rollback(); return false; }
        }
    }
}
