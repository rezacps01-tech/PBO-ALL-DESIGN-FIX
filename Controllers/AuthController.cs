using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Controllers
{
    // Controller untuk mengelola logika autentikasi
    public class AuthController
    {
        private readonly UserRepository _repo = new();

        public User? Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return null;
            return _repo.Login(username, password);
        }

        public bool Register(string username, string password, string fullName, string phone, string address)
        {
            if (_repo.GetAll().Any(u => u.Username == username.Trim()))
                return false;

            var user = new User
            {
                Username = username.Trim(),
                Password = password,
                FullName = fullName.Trim(),
                Phone = phone.Trim(),
                Address = address.Trim(),
                RoleId = 2,
                IsActive = true
            };
            return _repo.Add(user);
        }
    }
}
