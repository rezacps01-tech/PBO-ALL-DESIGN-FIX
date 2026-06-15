using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormManageBooking : BaseForm
    {
        private readonly BookingRepository _repo = new();
        private readonly UserRepository _userRepo = new();
        private readonly ScheduleRepository _schRepo = new();
        private int _selId = -1;
        private string _selStatus = "";

        public FormManageBooking() { InitializeComponent(); LoadData(); }

        protected override void LoadData()
        {
            var users = _userRepo.GetAll();
            var schs = _schRepo.GetAll();
            int no = 1;
            dataGridBookings.DataSource = _repo.GetAll().Select(b => new {
                No = no++, ID = b.BookingId,
                Jadwal = schs.FirstOrDefault(s => s.ScheduleId == b.ScheduleId)?.Location ?? "-",
                Konsumen = users.FirstOrDefault(u => u.UserId == b.UserId)?.FullName ?? "-",
                Tanggal = b.BookingDate.ToString("dd MMM yyyy"),
                Waktu = schs.FirstOrDefault(s => s.ScheduleId == b.ScheduleId) is { } sc ? $"{sc.StartTime:hh\\:mm}-{sc.EndTime:hh\\:mm}" : "-",
                Estimasi = $"{b.EstimatedWeight} kg",
                Aktual = b.ActualWeight.HasValue ? $"{b.ActualWeight} kg" : "-",
                Total = b.TotalPrice.HasValue ? $"Rp {b.TotalPrice:N0}" : "-",
                Status = b.Status, Catatan = b.Notes ?? "-",
                Diupdate = b.UpdatedAt.ToString("dd MMM yyyy HH:mm")
            }).ToList();
            if (dataGridBookings.Columns.Contains("ID")) dataGridBookings.Columns["ID"].Visible = false;
            if (dataGridBookings.Columns.Contains("Diupdate")) dataGridBookings.Columns["Diupdate"].HeaderText = "Terakhir Update";
            _selId = -1;
        }

        private void dataGridBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        { if (e.RowIndex < 0) return; _selId = (int)dataGridBookings.Rows[e.RowIndex].Cells["ID"].Value; _selStatus = dataGridBookings.Rows[e.RowIndex].Cells["Status"].Value?.ToString() ?? ""; }

        private void btnConfirm_Click(object sender, EventArgs e)
        { if (_selId < 0 || _selStatus != "pending") { ShowWarning("Pilih booking pending!"); return; } if (Confirm("Terima?") && _repo.UpdateStatus(_selId, "confirmed")) { ShowInfo("Diterima!"); LoadData(); } }

        private void btnComplete_Click(object sender, EventArgs e)
        { if (_selId < 0 || (_selStatus != "pending" && _selStatus != "confirmed")) { ShowWarning("Pilih booking pending/confirmed!"); return; } if (new FormInputComplete(_selId).ShowDialog() == DialogResult.OK) LoadData(); }

        private void btnCancel_Click(object sender, EventArgs e)
        { if (_selId < 0 || (_selStatus != "pending" && _selStatus != "confirmed")) { ShowWarning("Pilih booking pending/confirmed!"); return; } if (Confirm("Batalkan?") && _repo.CancelBooking(_selId)) { ShowInfo("Dibatalkan!"); LoadData(); } }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        { if (_selId < 0) { ShowWarning("Pilih booking!"); return; } if (Confirm("Hapus permanen?") && _repo.DeletePermanent(_selId)) { ShowInfo("Dihapus!"); LoadData(); } }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
