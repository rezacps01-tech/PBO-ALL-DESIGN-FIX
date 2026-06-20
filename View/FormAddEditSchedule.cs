using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormAddEditSchedule : BaseForm
    {
        private readonly ScheduleRepository _repo = new();
        private readonly User _user;
        private readonly Schedule? _edit;

        public FormAddEditSchedule(User user, Schedule? sch = null)
        {
            _user = user; _edit = sch;
            InitializeComponent();
            cmbStatus.SelectedIndex = 0;
            if (_edit != null) { this.Text = "Edit Jadwal"; FillData(); }
        }

        private void FillData()
        {
            txtLocation.Text = _edit!.Location; txtAddress.Text = _edit.Address;
            dtpDate.Value = _edit.ScheduleDate;
            dtpStartTime.Value = DateTime.Today.Add(_edit.StartTime);
            dtpEndTime.Value = DateTime.Today.Add(_edit.EndTime);
            txtCapacity.Text = _edit.Capacity.ToString();
            txtPrice.Text = _edit.PricePerKg.ToString();
            cmbStatus.SelectedItem = _edit.Status; txtNotes.Text = _edit.Notes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text)) { ShowWarning("Lokasi harus diisi!"); return; }
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) { ShowWarning("Alamat harus diisi!"); return; }
            if (!int.TryParse(txtCapacity.Text, out int cap) || cap <= 0) { ShowWarning("Kapasitas harus angka positif!"); return; }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0) { ShowWarning("Harga harus angka positif!"); return; }
            if (dtpEndTime.Value <= dtpStartTime.Value) { ShowWarning("Waktu selesai harus > waktu mulai!"); return; }

            var s = new Schedule
            {
                ScheduleId = _edit?.ScheduleId ?? 0,
                Location = txtLocation.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                ScheduleDate = dtpDate.Value.Date,
                StartTime = dtpStartTime.Value.TimeOfDay,
                EndTime = dtpEndTime.Value.TimeOfDay,
                Capacity = cap,
                PricePerKg = price,
                Status = cmbStatus.SelectedItem?.ToString() ?? "available",
                Notes = txtNotes.Text.Trim(),
                CreatedBy = _user.UserId
            };

            bool ok = _edit == null ? _repo.Add(s) : _repo.Update(s);
            if (ok) { ShowInfo("Berhasil!"); DialogResult = DialogResult.OK; Close(); }
            else ShowError("Gagal menyimpan!");
        }

        private void btnCancel_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }

        private void FormAddEditSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
