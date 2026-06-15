using AgroGrandong.Repositories;
using AgroGrandong.Models;

namespace AgroGrandong.Forms
{
    public partial class FormLogin : BaseForm
    {
        private readonly UserRepository _userRepo = new();
        public FormLogin() => InitializeComponent();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            { ShowWarning("Username dan password harus diisi!"); return; }

            var user = _userRepo.Login(textBoxUsername.Text.Trim(), textBoxPassword.Text);
            if (user == null) { ShowError("Username atau password salah!"); textBoxPassword.Clear(); return; }

            ShowInfo($"Selamat datang, {user.GetDisplayInfo()}!");
            this.Hide();
            Form dash = user.RoleName == "Admin" ? new FormAdminDashboard(user) : new FormKonsumenDashboard(user);
            dash.ShowDialog();
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e) => new FormRegister().ShowDialog();
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
    }
}
