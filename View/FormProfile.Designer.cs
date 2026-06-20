namespace AgroGrandong.Forms
{
    partial class FormProfile
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
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
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            lblConf = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblAddr = new Label();
            lblHint = new Label();
            label1 = new Label();
            Username = new Label();
            passwordBaru = new Label();
            knfrmpassword = new Label();
            NamaLengkap = new Label();
            NoHp = new Label();
            label7 = new Label();
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
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(194, 440);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 53);
            btnSave.TabIndex = 14;
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
            btnBack.Location = new Point(23, 440);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(149, 53);
            btnBack.TabIndex = 15;
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
            // lblHint
            // 
            lblHint.Location = new Point(0, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(114, 31);
            lblHint.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(23, 123);
            Username.Name = "Username";
            Username.Size = new Size(82, 20);
            Username.TabIndex = 17;
            Username.Text = "Username :";
            // 
            // passwordBaru
            // 
            passwordBaru.AutoSize = true;
            passwordBaru.Location = new Point(23, 170);
            passwordBaru.Name = "passwordBaru";
            passwordBaru.Size = new Size(111, 20);
            passwordBaru.TabIndex = 18;
            passwordBaru.Text = "Password Baru :";
            // 
            // knfrmpassword
            // 
            knfrmpassword.AutoSize = true;
            knfrmpassword.Location = new Point(23, 216);
            knfrmpassword.Name = "knfrmpassword";
            knfrmpassword.Size = new Size(152, 20);
            knfrmpassword.TabIndex = 19;
            knfrmpassword.Text = "Konfirmasi Password :";
            knfrmpassword.Click += label4_Click;
            // 
            // NamaLengkap
            // 
            NamaLengkap.AutoSize = true;
            NamaLengkap.Location = new Point(23, 263);
            NamaLengkap.Name = "NamaLengkap";
            NamaLengkap.Size = new Size(120, 20);
            NamaLengkap.TabIndex = 20;
            NamaLengkap.Text = "Nama Lengkap : ";
            // 
            // NoHp
            // 
            NoHp.AutoSize = true;
            NoHp.Location = new Point(23, 310);
            NoHp.Name = "NoHp";
            NoHp.Size = new Size(86, 20);
            NoHp.TabIndex = 21;
            NoHp.Text = "Nomor HP :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(27, 398);
            label7.Name = "label7";
            label7.Size = new Size(292, 17);
            label7.TabIndex = 22;
            label7.Text = "*Kosonggakan password jika tidak ingin mengubah";
            label7.Click += label7_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(514, 520);
            Controls.Add(label7);
            Controls.Add(NoHp);
            Controls.Add(NamaLengkap);
            Controls.Add(knfrmpassword);
            Controls.Add(passwordBaru);
            Controls.Add(Username);
            Controls.Add(label1);
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
            Controls.Add(lblHint);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Setting Profile - AgroGrandong";
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
        private Label lblHint;
        private Label label1;
        private Label Username;
        private Label passwordBaru;
        private Label knfrmpassword;
        private Label NamaLengkap;
        private Label NoHp;
        private Label label7;
    }
}
