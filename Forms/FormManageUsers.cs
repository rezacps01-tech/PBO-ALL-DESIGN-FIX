using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormManageUsers : BaseForm
    {
        private readonly UserRepository _repo = new();
        private int _selId = -1;

        public FormManageUsers() { InitializeComponent(); LoadData(); }

        protected override void LoadData()
        {
            int no = 1;
            dataGridUsers.DataSource = _repo.GetAll().Select(u => new {
                No = no++, ID = u.UserId, Username = u.Username, Nama = u.FullName,
                Telepon = u.Phone ?? "-", Role = u.RoleName, Aktif = u.IsActive ? "Ya" : "Tidak",
                Terdaftar = u.CreatedAt.ToString("dd MMM yyyy"),
                Terakhir_Update = u.UpdatedAt.ToString("dd MMM yyyy HH:mm")
            }).ToList();
            if (dataGridUsers.Columns.Contains("ID")) dataGridUsers.Columns["ID"].Visible = false;
            if (dataGridUsers.Columns.Contains("Terakhir_Update")) dataGridUsers.Columns["Terakhir_Update"].HeaderText = "Terakhir Update";
            _selId = -1;
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        { if (e.RowIndex >= 0) _selId = (int)dataGridUsers.Rows[e.RowIndex].Cells["ID"].Value; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selId < 0) { ShowWarning("Pilih user!"); return; }
            if (_selId == 1) { ShowWarning("Tidak bisa hapus admin utama!"); return; }
            if (Confirm("Hapus user ini permanen?") && _repo.DeletePermanent(_selId)) { ShowInfo("Dihapus!"); LoadData(); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
