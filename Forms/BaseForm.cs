namespace AgroGrandong.Forms
{
    public class BaseForm : Form
    {
        protected void ShowInfo(string msg) => MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        protected void ShowError(string msg) => MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        protected void ShowWarning(string msg) => MessageBox.Show(msg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        protected bool Confirm(string msg) => MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        protected virtual void LoadData() { }
    }
}
