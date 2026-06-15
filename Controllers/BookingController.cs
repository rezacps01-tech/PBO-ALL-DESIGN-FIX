using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Controllers
{
    // Controller untuk mengelola logika booking
    public class BookingController
    {
        private readonly BookingRepository _repo = new();
        private readonly ScheduleRepository _schRepo = new();
        private readonly UserRepository _userRepo = new();

        public List<Booking> GetAllBookings() => _repo.GetAll();

        public List<Booking> GetUserBookings(int userId) => _repo.GetByUser(userId);

        public bool CreateBooking(int scheduleId, int userId, decimal estimatedWeight, string? notes)
        {
            var booking = new Booking
            {
                ScheduleId = scheduleId,
                UserId = userId,
                EstimatedWeight = estimatedWeight,
                Notes = notes?.Trim()
            };
            return _repo.Add(booking);
        }

        public bool ConfirmBooking(int bookingId) => _repo.UpdateStatus(bookingId, "confirmed");

        public bool CompleteBooking(int bookingId, decimal actualWeight)
        {
            var booking = _repo.GetAll().FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null) return false;

            var schedule = _schRepo.GetAll().FirstOrDefault(s => s.ScheduleId == booking.ScheduleId);
            if (schedule == null) return false;

            decimal totalPrice = actualWeight * schedule.PricePerKg;
            return _repo.UpdateStatus(bookingId, "completed", actualWeight, totalPrice);
        }

        public bool CancelBooking(int bookingId) => _repo.CancelBooking(bookingId);

        public bool DeleteBooking(int bookingId) => _repo.DeletePermanent(bookingId);

        // Helper: ambil harga per kg dari jadwal terkait booking
        public decimal GetPricePerKg(int bookingId)
        {
            var booking = _repo.GetAll().FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null) return 0;
            var schedule = _schRepo.GetAll().FirstOrDefault(s => s.ScheduleId == booking.ScheduleId);
            return schedule?.PricePerKg ?? 0;
        }
    }
}
