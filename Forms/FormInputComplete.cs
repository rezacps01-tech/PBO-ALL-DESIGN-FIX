using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormInputComplete : BaseForm
    {
        private readonly int _bookingId;
        private readonly BookingRepository _bookRepo = new();
        private readonly ScheduleRepository _schRepo = new();
        private decimal _pricePerKg;

        public FormInputComplete(int bookingId)
        {
            _bookingId = bookingId;
            InitializeComponent();
            var b = _bookRepo.GetAll().FirstOrDefault(x => x.BookingId == _bookingId);
            if (b != null) { var s = _schRepo.GetAll().FirstOrDefault(x => x.ScheduleId == b.ScheduleId); if (s != null) _pricePerKg = s.PricePerKg; }
            lblHint.Text = $"* Otomatis: berat x Rp {_pricePerKg:N0}/kg";
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        { txtPrice.Text = decimal.TryParse(txtWeight.Text, out decimal w) && w > 0 ? (w * _pricePerKg).ToString("N0") : ""; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtWeight.Text, out decimal w) || w <= 0) { ShowWarning("Berat harus angka positif!"); return; }
            decimal total = w * _pricePerKg;
            if (_bookRepo.UpdateStatus(_bookingId, "completed", w, total)) { ShowInfo($"Selesai! Total: Rp {total:N0}"); DialogResult = DialogResult.OK; Close(); }
            else ShowError("Gagal!");
        }

        private void btnCancel_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
