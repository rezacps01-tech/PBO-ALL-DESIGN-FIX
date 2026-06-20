using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormAdminDashboard : BaseForm
    {
        private readonly User _user;
        private readonly ScheduleRepository _schRepo = new();
        private readonly BookingRepository _bookRepo = new();
        private readonly UserRepository _userRepo = new();

        public FormAdminDashboard(User user)
        {
            InitializeComponent();
            _user = user;
            labelWelcome.Text = $"Dashboard Admin - {_user.FullName}";
        }

        protected override void LoadData()
        {
            labelTotalJadwal.Text = $"Total Jadwal\n{_schRepo.GetAll().Count}";
            labelTotalBooking.Text = $"Total Booking\n{_bookRepo.GetAll().Count}";
            labelTotalKonsumen.Text = $"Total Konsumen\n{_userRepo.GetAll().Count(u => u.RoleName == "Konsumen" && u.IsActive)}";
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e) => LoadData();
        private void buttonDashboard_Click(object sender, EventArgs e) => LoadData();
        private void buttonJadwal_Click(object sender, EventArgs e) { new FormManageSchedule(_user).ShowDialog(); LoadData(); }
        private void buttonBooking_Click(object sender, EventArgs e) { new FormManageBooking().ShowDialog(); LoadData(); }
        private void buttonUsers_Click(object sender, EventArgs e) { new FormManageUsers().ShowDialog(); LoadData(); }
        private void buttonLaporan_Click(object sender, EventArgs e) => new FormLaporan().ShowDialog();
        private void buttonProfile_Click(object sender, EventArgs e) { new FormAdminProfile(_user).ShowDialog(); labelWelcome.Text = $"Dashboard Admin - {_user.FullName}"; }
        private void buttonLogout_Click(object sender, EventArgs e) { if (Confirm("Yakin ingin keluar?")) Close(); }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
