using AgroGrandong.Forms;

namespace AgroGrandong
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            // Test database connection
            if (!Database.DatabaseConnection.TestConnection())
            {
                MessageBox.Show(
                    "Tidak dapat terhubung ke database PostgreSQL!\n\n" +
                    "Pastikan:\n" +
                    "1. PostgreSQL sudah terinstall dan berjalan\n" +
                    "2. Database 'agrograndong' sudah dibuat\n" +
                    "3. Connection string di App.config sudah benar\n" +
                    "4. Schema database sudah dijalankan (schema.sql)",
                    "Error Koneksi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Application.Run(new FormLogin());
        }
    }
}
