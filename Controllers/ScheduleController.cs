using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Controllers
{
    // Controller untuk mengelola logika jadwal
    public class ScheduleController
    {
        private readonly ScheduleRepository _repo = new();

        public List<Schedule> GetAllSchedules() => _repo.GetAll();

        public List<Schedule> GetAvailableSchedules() => _repo.GetAvailable();

        public bool AddSchedule(string location, string address, DateTime date, TimeSpan startTime, TimeSpan endTime, int capacity, decimal pricePerKg, string? notes, int createdBy)
        {
            var schedule = new Schedule
            {
                Location = location.Trim(),
                Address = address.Trim(),
                ScheduleDate = date.Date,
                StartTime = startTime,
                EndTime = endTime,
                Capacity = capacity,
                PricePerKg = pricePerKg,
                Notes = notes?.Trim(),
                CreatedBy = createdBy
            };
            return _repo.Add(schedule);
        }

        public bool UpdateSchedule(Schedule schedule) => _repo.Update(schedule);

        public bool DeleteSchedule(int scheduleId) => _repo.Delete(scheduleId);
    }
}
