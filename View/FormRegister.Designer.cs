namespace AgroGrandong.Forms
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnRegister;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            lblConf = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblAddr = new Label();
            username = new Label();
            password = new Label();
            knfrmsPsswrd = new Label();
            NamaLengkap = new Label();
            nohp = new Label();
            alamat = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(194, 73);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(285, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 120);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(285, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(194, 167);
            txtConfirm.Margin = new Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '●';
            txtConfirm.Size = new Size(285, 27);
            txtConfirm.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(194, 213);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(285, 27);
            txtFullName.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(194, 260);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(285, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(194, 307);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(285, 79);
            txtAddress.TabIndex = 12;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(194, 407);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(286, 53);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "DAFTAR";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(23, 407);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(149, 53);
            btnBack.TabIndex = 14;
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
            // lblPass
            // 
            lblPass.Location = new Point(0, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(114, 31);
            lblPass.TabIndex = 3;
            // 
            // lblConf
            // 
            lblConf.Location = new Point(0, 0);
            lblConf.Name = "lblConf";
            lblConf.Size = new Size(114, 31);
            lblConf.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 31);
            lblName.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(0, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(114, 31);
            lblPhone.TabIndex = 9;
            // 
            // lblAddr
            // 
            lblAddr.Location = new Point(0, 0);
            lblAddr.Name = "lblAddr";
            lblAddr.Size = new Size(114, 31);
            lblAddr.TabIndex = 11;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(21, 76);
            username.Name = "username";
            username.Size = new Size(82, 20);
            username.TabIndex = 15;
            username.Text = "Username :";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(21, 123);
            password.Name = "password";
            password.Size = new Size(77, 20);
            password.TabIndex = 16;
            password.Text = "Password :";
            // 
            // knfrmsPsswrd
            // 
            knfrmsPsswrd.AutoSize = true;
            knfrmsPsswrd.Location = new Point(21, 170);
            knfrmsPsswrd.Name = "knfrmsPsswrd";
            knfrmsPsswrd.Size = new Size(152, 20);
            knfrmsPsswrd.TabIndex = 17;
            knfrmsPsswrd.Text = "Konfirmasi Password :";
            // 
            // NamaLengkap
            // 
            NamaLengkap.AutoSize = true;
            NamaLengkap.Location = new Point(21, 216);
            NamaLengkap.Name = "NamaLengkap";
            NamaLengkap.Size = new Size(116, 20);
            NamaLengkap.TabIndex = 18;
            NamaLengkap.Text = "Nama Lengkap :";
            NamaLengkap.Click += label4_Click;
            // 
            // nohp
            // 
            nohp.AutoSize = true;
            nohp.Location = new Point(21, 263);
            nohp.Name = "nohp";
            nohp.Size = new Size(86, 20);
            nohp.TabIndex = 19;
            nohp.Text = "Nomor HP :";
            // 
            // alamat
            // 
            alamat.AutoSize = true;
            alamat.Location = new Point(21, 307);
            alamat.Name = "alamat";
            alamat.Size = new Size(68, 20);
            alamat.TabIndex = 20;
            alamat.Text = "Alamat : ";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(514, 487);
            Controls.Add(alamat);
            Controls.Add(nohp);
            Controls.Add(NamaLengkap);
            Controls.Add(knfrmsPsswrd);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(lblConf);
            Controls.Add(txtConfirm);
            Controls.Add(lblName);
            Controls.Add(txtFullName);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddr);
            Controls.Add(txtAddress);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Daftar Akun Konsumen - AgroGrandong";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblUser;
        private Label lblPass;
        private Label lblConf;
        private Label lblName;
        private Label lblPhone;
        private Label lblAddr;
        private Label username;
        private Label password;
        private Label knfrmsPsswrd;
        private Label NamaLengkap;
        private Label nohp;
        private Label alamat;
    }
}
