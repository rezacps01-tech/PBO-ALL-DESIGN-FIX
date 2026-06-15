using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Controllers
{
    // Controller untuk mengelola logika user/profil
    public class UserController
    {
        private readonly UserRepository _repo = new();

        public List<User> GetAllUsers() => _repo.GetAll();

        public bool UpdateProfile(User user, string username, string fullName, string? phone, string? address, string? newPassword)
        {
            if (_repo.GetAll().Any(u => u.Username == username.Trim() && u.UserId != user.UserId))
                return false;

            user.Username = username.Trim();
            user.FullName = fullName.Trim();
            user.Phone = phone?.Trim();
            user.Address = address?.Trim();
            if (!string.IsNullOrEmpty(newPassword))
                user.Password = newPassword;

            return _repo.Update(user);
        }

        public bool DeleteUser(int userId)
        {
            if (userId == 1) return false; // proteksi admin utama
            return _repo.DeletePermanent(userId);
        }
    }
}
