using AgroGrandong.Models;
using AgroGrandong.Repositories;

namespace AgroGrandong.Forms
{
    public partial class FormAdminProfile : BaseForm
    {
        private readonly UserRepository _repo = new();
        private User _user;

        public FormAdminProfile(User user) { _user = user; InitializeComponent(); FillData(); }

        private void FillData() { txtUsername.Text = _user.Username; txtFullName.Text = _user.FullName; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) { ShowWarning("Username harus diisi!"); return; }
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) { ShowWarning("Nama harus diisi!"); return; }
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtPassword.Text != txtConfirm.Text) { ShowWarning("Password tidak cocok!"); return; }
                if (txtPassword.Text.Length < 6) { ShowWarning("Password minimal 6 karakter!"); return; }
            }
            if (_repo.GetAll().Any(u => u.Username == txtUsername.Text.Trim() && u.UserId != _user.UserId)) { ShowWarning("Username sudah ada!"); return; }

            _user.Username = txtUsername.Text.Trim(); _user.FullName = txtFullName.Text.Trim();
            if (!string.IsNullOrEmpty(txtPassword.Text)) _user.Password = txtPassword.Text;

            if (_repo.Update(_user)) { ShowInfo("Profil diperbarui!"); Close(); }
            else ShowError("Gagal menyimpan!");
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
