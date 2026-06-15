using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormManageSchedule : BaseForm
    {
        private readonly ScheduleRepository _repo = new();
        private readonly User _user;
        private Schedule? _selected;

        public FormManageSchedule(User user) { _user = user; InitializeComponent(); LoadData(); }

        protected override void LoadData()
        {
            int no = 1;
            dataGridSchedules.DataSource = _repo.GetAll().Select(s => new {
                No = no++, ID = s.ScheduleId, Lokasi = s.Location, Alamat = s.Address,
                Tanggal = s.ScheduleDate.ToString("dd MMM yyyy"),
                Waktu = $"{s.StartTime:hh\\:mm}-{s.EndTime:hh\\:mm}",
                Stok = s.AvailableSlots, Harga = $"Rp {s.PricePerKg:N0}/kg",
                Status = s.Status, Keterangan = s.Notes ?? "-",
                Dibuat = s.CreatedAt.ToString("dd MMM yyyy"),
                Diupdate = s.UpdatedAt.ToString("dd MMM yyyy HH:mm")
            }).ToList();
            if (dataGridSchedules.Columns.Contains("ID")) dataGridSchedules.Columns["ID"].Visible = false;
            if (dataGridSchedules.Columns.Contains("Diupdate")) dataGridSchedules.Columns["Diupdate"].HeaderText = "Terakhir Update";
            _selected = null;
        }

        private void dataGridSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        { if (e.RowIndex >= 0) _selected = _repo.GetAll().FirstOrDefault(x => x.ScheduleId == (int)dataGridSchedules.Rows[e.RowIndex].Cells["ID"].Value); }

        private void btnAdd_Click(object sender, EventArgs e) { if (new FormAddEditSchedule(_user).ShowDialog() == DialogResult.OK) LoadData(); }
        private void btnEdit_Click(object sender, EventArgs e) { if (_selected == null) { ShowWarning("Pilih jadwal!"); return; } if (new FormAddEditSchedule(_user, _selected).ShowDialog() == DialogResult.OK) LoadData(); }
        private void btnDelete_Click(object sender, EventArgs e) { if (_selected == null) { ShowWarning("Pilih jadwal!"); return; } if (Confirm("Hapus jadwal ini?") && _repo.Delete(_selected.ScheduleId)) { ShowInfo("Dihapus!"); LoadData(); } }
        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
