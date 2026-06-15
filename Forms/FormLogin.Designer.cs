namespace AgroGrandong.Forms
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelTitle = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            panelMain = new Panel();
            buttonRegister = new Button();
            labelSubtitle = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(91, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(265, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "AgroGrandong";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(57, 160);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 23);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(57, 193);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(297, 30);
            textBoxUsername.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPassword.Location = new Point(57, 247);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 23);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(57, 280);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(297, 30);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Lime;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(57, 347);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(297, 53);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(labelTitle);
            panelMain.Controls.Add(buttonLogin);
            panelMain.Controls.Add(buttonRegister);
            panelMain.Controls.Add(labelSubtitle);
            panelMain.Controls.Add(textBoxPassword);
            panelMain.Controls.Add(labelUsername);
            panelMain.Controls.Add(labelPassword);
            panelMain.Controls.Add(textBoxUsername);
            panelMain.Location = new Point(46, 40);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(411, 493);
            panelMain.TabIndex = 7;
            panelMain.Paint += panelMain_Paint;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(40, 167, 69);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(57, 413);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(297, 40);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Belum punya akun? DAFTAR";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.BackColor = Color.Transparent;
            labelSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtitle.ForeColor = Color.Black;
            labelSubtitle.Location = new Point(40, 93);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(356, 23);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Sistem Penjadwalan Mesin Giling Padi Keliling";
            // 
            // FormLogin
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(503, 587);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - AgroGrandong";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Panel panelMain;
    }
}
