namespace AgroGrandong.Forms
{
    partial class FormAdminProfile
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            lblTitle = new Label();
            lblUser = new Label();
            lblName = new Label();
            lblPass = new Label();
            lblConf = new Label();
            lblHint = new Label();
            username = new Label();
            namalngkp = new Label();
            psswrdbaru = new Label();
            knfrms_psswrd = new Label();
            judul = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(171, 73);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(171, 120);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(274, 27);
            txtFullName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 167);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(274, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(171, 213);
            txtConfirm.Margin = new Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '●';
            txtConfirm.Size = new Size(274, 27);
            txtConfirm.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(171, 300);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(274, 53);
            btnSave.TabIndex = 10;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(23, 300);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 53);
            btnBack.TabIndex = 11;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 31);
            lblTitle.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(114, 31);
            lblUser.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 31);
            lblName.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.Location = new Point(0, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(114, 31);
            lblPass.TabIndex = 5;
            // 
            // lblConf
            // 
            lblConf.Location = new Point(0, 0);
            lblConf.Name = "lblConf";
            lblConf.Size = new Size(114, 31);
            lblConf.TabIndex = 7;
            // 
            // lblHint
            // 
            lblHint.Location = new Point(0, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(114, 31);
            lblHint.TabIndex = 9;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(25, 76);
            username.Name = "username";
            username.Size = new Size(82, 20);
            username.TabIndex = 12;
            username.Text = "Username :";
            // 
            // namalngkp
            // 
            namalngkp.AutoSize = true;
            namalngkp.Location = new Point(25, 123);
            namalngkp.Name = "namalngkp";
            namalngkp.Size = new Size(116, 20);
            namalngkp.TabIndex = 13;
            namalngkp.Text = "Nama Lengkap :";
            // 
            // psswrdbaru
            // 
            psswrdbaru.AutoSize = true;
            psswrdbaru.Location = new Point(25, 170);
            psswrdbaru.Name = "psswrdbaru";
            psswrdbaru.Size = new Size(111, 20);
            psswrdbaru.TabIndex = 14;
            psswrdbaru.Text = "Password Baru :";
            psswrdbaru.Click += label3_Click;
            // 
            // knfrms_psswrd
            // 
            knfrms_psswrd.AutoSize = true;
            knfrms_psswrd.Location = new Point(25, 216);
            knfrms_psswrd.Name = "knfrms_psswrd";
            knfrms_psswrd.Size = new Size(87, 20);
            knfrms_psswrd.TabIndex = 15;
            knfrms_psswrd.Text = "Konfirmasi :";
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            judul.Location = new Point(188, 23);
            judul.Name = "judul";
            judul.Size = new Size(184, 28);
            judul.TabIndex = 16;
            judul.Text = "Edit Profil Admin";
            // 
            // FormAdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(480, 380);
            Controls.Add(judul);
            Controls.Add(knfrms_psswrd);
            Controls.Add(psswrdbaru);
            Controls.Add(namalngkp);
            Controls.Add(username);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblName);
            Controls.Add(txtFullName);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(lblConf);
            Controls.Add(txtConfirm);
            Controls.Add(lblHint);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAdminProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Profil Admin - AgroGrandong";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblUser;
        private Label lblName;
        private Label lblPass;
        private Label lblConf;
        private Label lblHint;
        private Label username;
        private Label namalngkp;
        private Label psswrdbaru;
        private Label knfrms_psswrd;
        private Label judul;
    }
}
