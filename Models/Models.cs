namespace AgroGrandong.Models
{
    public abstract class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public abstract string GetDisplayInfo();
    }

    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string FullName { get; set; } = "";
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; } = "";
        public bool IsActive { get; set; }
        public override string GetDisplayInfo() => $"{FullName} ({RoleName})";
    }

    public class Schedule : BaseEntity
    {
        public int ScheduleId { get; set; }
        public string Location { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime ScheduleDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Capacity { get; set; }
        public int CurrentBooking { get; set; }
        public decimal PricePerKg { get; set; }
        public string Status { get; set; } = "available";
        public string? Notes { get; set; }
        public int CreatedBy { get; set; }
        public int AvailableSlots => Capacity - CurrentBooking;
        public override string GetDisplayInfo() => $"{Location} - {ScheduleDate:dd MMM yyyy}";
    }

    public class Booking : BaseEntity
    {
        public int BookingId { get; set; }
        public int ScheduleId { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal EstimatedWeight { get; set; }
        public decimal? ActualWeight { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Status { get; set; } = "pending";
        public string? Notes { get; set; }
        public override string GetDisplayInfo() => $"Booking #{BookingId} - {EstimatedWeight}kg ({Status})";
    }
}
