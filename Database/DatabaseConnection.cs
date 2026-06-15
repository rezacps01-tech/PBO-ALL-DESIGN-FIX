using Npgsql;
using System.Configuration;

namespace AgroGrandong.Database
{
    public class DatabaseConnection
    {
        private static string? connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    connectionString = ConfigurationManager.AppSettings["ConnectionString"]
                        ?? "Host=localhost;Port=5432;Database=agrograndong;Username=postgres;Password=GamnyuKemqing76";
                }
                return connectionString;
            }
            set => connectionString = value;
        }

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
