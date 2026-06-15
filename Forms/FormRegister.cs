using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormRegister : BaseForm
    {
        private readonly UserRepository _repo = new();
        public FormRegister() => InitializeComponent();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) { ShowWarning("Username harus diisi!"); return; }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) { ShowWarning("Password harus diisi!"); return; }
            if (txtPassword.Text != txtConfirm.Text) { ShowWarning("Password tidak cocok!"); return; }
            if (txtPassword.Text.Length < 6) { ShowWarning("Password minimal 6 karakter!"); return; }
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) { ShowWarning("Nama harus diisi!"); return; }
            if (string.IsNullOrWhiteSpace(txtPhone.Text)) { ShowWarning("No HP harus diisi!"); return; }
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) { ShowWarning("Alamat harus diisi!"); return; }
            if (_repo.GetAll().Any(u => u.Username == txtUsername.Text.Trim())) { ShowWarning("Username sudah ada!"); return; }

            var user = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                RoleId = 2,
                IsActive = true
            };

            if (_repo.Add(user)) { ShowInfo("Daftar berhasil! Silakan login."); Close(); }
            else ShowError("Gagal mendaftar.");
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
