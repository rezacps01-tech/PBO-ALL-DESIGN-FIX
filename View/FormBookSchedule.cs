using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormBookSchedule : BaseForm
    {
        private readonly User _user;
        private readonly int _schId;
        private readonly BookingRepository _bookRepo = new();
        private readonly ScheduleRepository _schRepo = new();

        public FormBookSchedule(User user, int scheduleId)
        {
            _user = user; _schId = scheduleId;
            InitializeComponent();
            var s = _schRepo.GetAll().FirstOrDefault(x => x.ScheduleId == _schId);
            if (s != null) lblScheduleInfo.Text = $"Lokasi: {s.Location}\nTanggal: {s.ScheduleDate:dd MMM yyyy}\nWaktu: {s.StartTime:hh\\:mm}-{s.EndTime:hh\\:mm}\nHarga: Rp {s.PricePerKg:N0}/kg";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtWeight.Text, out decimal w) || w <= 0) { ShowWarning("Berat harus angka positif!"); return; }
            var b = new Booking { ScheduleId = _schId, UserId = _user.UserId, EstimatedWeight = w, Notes = txtNotes.Text.Trim() };
            if (_bookRepo.Add(b)) { ShowInfo("Booking berhasil!"); DialogResult = DialogResult.OK; Close(); }
            else ShowError("Gagal. Jadwal mungkin penuh.");
        }

        private void btnCancel_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblScheduleInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
