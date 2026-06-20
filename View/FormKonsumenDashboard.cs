using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormKonsumenDashboard : BaseForm
    {
        private readonly User _user;
        private readonly ScheduleRepository _schRepo = new();
        private readonly BookingRepository _bookRepo = new();

        public FormKonsumenDashboard(User user)
        {
            _user = user; InitializeComponent();
            lblWelcome.Text = $"Dashboard Konsumen - {_user.FullName}";
            LoadData();
        }

        protected override void LoadData()
        {
            int n1 = 1;
            dataGridSchedules.DataSource = _schRepo.GetAvailable().Select(s => new
            {
                No = n1++,
                ID = s.ScheduleId,
                Lokasi = s.Location,
                Tanggal = s.ScheduleDate.ToString("dd MMM yyyy"),
                Waktu = $"{s.StartTime:hh\\:mm}-{s.EndTime:hh\\:mm}",
                Tersedia = $"{s.AvailableSlots}/{s.Capacity}",
                Harga = $"Rp {s.PricePerKg:N0}/kg",
                Keterangan = s.Notes ?? "-"
            }).ToList();
            if (dataGridSchedules.Columns.Contains("ID")) dataGridSchedules.Columns["ID"].Visible = false;

            int n2 = 1;
            dataGridBookings.DataSource = _bookRepo.GetByUser(_user.UserId).Select(b => new
            {
                No = n2++,
                ID = b.BookingId,
                Tanggal = b.BookingDate.ToString("dd MMM yyyy"),
                Estimasi = $"{b.EstimatedWeight} kg",
                Total = b.TotalPrice.HasValue ? $"Rp {b.TotalPrice:N0}" : "-",
                Status = b.Status,
                Catatan = b.Notes ?? "-"
            }).ToList();
            if (dataGridBookings.Columns.Contains("ID")) dataGridBookings.Columns["ID"].Visible = false;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridSchedules.SelectedRows.Count == 0) { ShowWarning("Pilih jadwal!"); return; }
            int sid = (int)dataGridSchedules.SelectedRows[0].Cells["ID"].Value;
            if (new FormBookSchedule(_user, sid).ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnProfile_Click(object sender, EventArgs e) => new FormProfile(_user).ShowDialog();
        private void btnLogout_Click(object sender, EventArgs e) => Close();

        private void FormKonsumenDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dataGridSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
