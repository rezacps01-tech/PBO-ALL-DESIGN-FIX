using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormLaporan : BaseForm
    {
        private readonly BookingRepository _bookRepo = new();
        private readonly ScheduleRepository _schRepo = new();

        public FormLaporan() { InitializeComponent(); LoadData(); }

        protected override void LoadData()
        {
            var schs = _schRepo.GetAll();
            int no = 1;
            dataGridLaporan.DataSource = _bookRepo.GetAll().Select(b => new {
                No = no++, Lokasi = schs.FirstOrDefault(s => s.ScheduleId == b.ScheduleId)?.Location ?? "-",
                Tanggal = b.BookingDate.ToString("dd MMM yyyy"),
                Estimasi = $"{b.EstimatedWeight} kg",
                Aktual = b.ActualWeight.HasValue ? $"{b.ActualWeight} kg" : "-",
                Pendapatan = b.TotalPrice.HasValue ? $"Rp {b.TotalPrice:N0}" : "-",
                Status = b.Status
            }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}