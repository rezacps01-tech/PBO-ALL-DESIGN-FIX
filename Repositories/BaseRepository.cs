using Npgsql;

namespace AgroGrandong.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        bool Add(T entity);
        bool Delete(int id);
    }

    public abstract class BaseRepository
    {
        protected NpgsqlConnection GetConn() => new(Database.DatabaseConnection.ConnectionString);

        protected int Exec(string sql, params (string name, object? val)[] p)
        {
            using var conn = GetConn(); conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            foreach (var (name, val) in p)
                cmd.Parameters.AddWithValue(name, val ?? DBNull.Value);
            return cmd.ExecuteNonQuery();
        }
    }
}
