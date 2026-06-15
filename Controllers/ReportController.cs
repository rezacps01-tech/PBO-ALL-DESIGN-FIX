using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Controllers
{
    // Controller untuk mengelola logika laporan
    public class ReportController
    {
        private readonly BookingRepository _bookRepo = new();
        private readonly ScheduleRepository _schRepo = new();
        private readonly UserRepository _userRepo = new();

        public int GetTotalSchedules() => _schRepo.GetAll().Count;

        public int GetTotalBookings() => _bookRepo.GetAll().Count;

        public int GetTotalKonsumen() => _userRepo.GetAll().Count(u => u.RoleName == "Konsumen" && u.IsActive);

        public decimal GetTotalPendapatan() => _bookRepo.GetAll()
            .Where(b => b.TotalPrice.HasValue && b.Status == "completed")
            .Sum(b => b.TotalPrice!.Value);

        public List<object> GetReportData()
        {
            var schs = _schRepo.GetAll();
            int no = 1;
            return _bookRepo.GetAll().Select(b => (object)new
            {
                No = no++,
                Lokasi = schs.FirstOrDefault(s => s.ScheduleId == b.ScheduleId)?.Location ?? "-",
                Tanggal = b.BookingDate.ToString("dd MMM yyyy"),
                Estimasi = $"{b.EstimatedWeight} kg",
                Aktual = b.ActualWeight.HasValue ? $"{b.ActualWeight} kg" : "-",
                Pendapatan = b.TotalPrice.HasValue ? $"Rp {b.TotalPrice:N0}" : "-",
                Status = b.Status
            }).ToList();
        }
    }
}
