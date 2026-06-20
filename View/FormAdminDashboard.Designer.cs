namespace AgroGrandong.Forms
{
    partial class FormAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminDashboard));
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            labelWelcome = new Label();
            buttonProfile = new Button();
            buttonLogout = new Button();
            panelMenu = new Panel();
            buttonDashboard = new Button();
            buttonJadwal = new Button();
            buttonBooking = new Button();
            buttonUsers = new Button();
            buttonLaporan = new Button();
            panelContent = new Panel();
            labelTotalJadwal = new Label();
            labelTotalBooking = new Label();
            labelTotalKonsumen = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Green;
            panelTop.BackgroundImage = (Image)resources.GetObject("panelTop.BackgroundImage");
            panelTop.BackgroundImageLayout = ImageLayout.Stretch;
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(labelWelcome);
            panelTop.Controls.Add(buttonProfile);
            panelTop.Controls.Add(buttonLogout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1143, 80);
            panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-17, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 48);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(89, 20);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(387, 46);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "DASHBOARD ADMIN";
            // 
            // buttonProfile
            // 
            buttonProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonProfile.BackColor = Color.DarkCyan;
            buttonProfile.Cursor = Cursors.Hand;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.Location = new Point(869, 20);
            buttonProfile.Margin = new Padding(3, 4, 3, 4);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(114, 40);
            buttonProfile.TabIndex = 6;
            buttonProfile.Text = "PROFILE";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLogout.BackColor = Color.Red;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(1006, 20);
            buttonLogout.Margin = new Padding(3, 4, 3, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(114, 40);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Green;
            panelMenu.BackgroundImage = (Image)resources.GetObject("panelMenu.BackgroundImage");
            panelMenu.BackgroundImageLayout = ImageLayout.Stretch;
            panelMenu.Controls.Add(buttonDashboard);
            panelMenu.Controls.Add(buttonJadwal);
            panelMenu.Controls.Add(buttonBooking);
            panelMenu.Controls.Add(buttonUsers);
            panelMenu.Controls.Add(buttonLaporan);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ActiveBorder;
            panelMenu.Location = new Point(0, 80);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 720);
            panelMenu.TabIndex = 1;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(0, 27);
            buttonDashboard.Margin = new Padding(3, 4, 3, 4);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(229, 67);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonJadwal
            // 
            buttonJadwal.BackColor = Color.Transparent;
            buttonJadwal.Cursor = Cursors.Hand;
            buttonJadwal.FlatAppearance.BorderSize = 0;
            buttonJadwal.FlatStyle = FlatStyle.Flat;
            buttonJadwal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJadwal.ForeColor = Color.White;
            buttonJadwal.Location = new Point(0, 107);
            buttonJadwal.Margin = new Padding(3, 4, 3, 4);
            buttonJadwal.Name = "buttonJadwal";
            buttonJadwal.Size = new Size(229, 67);
            buttonJadwal.TabIndex = 1;
            buttonJadwal.Text = "Kelola Jadwal";
            buttonJadwal.UseVisualStyleBackColor = false;
            buttonJadwal.Click += buttonJadwal_Click;
            // 
            // buttonBooking
            // 
            buttonBooking.BackColor = Color.Transparent;
            buttonBooking.Cursor = Cursors.Hand;
            buttonBooking.FlatAppearance.BorderSize = 0;
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBooking.ForeColor = Color.White;
            buttonBooking.Location = new Point(0, 187);
            buttonBooking.Margin = new Padding(3, 4, 3, 4);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(229, 67);
            buttonBooking.TabIndex = 2;
            buttonBooking.Text = "Kelola Booking";
            buttonBooking.UseVisualStyleBackColor = false;
            buttonBooking.Click += buttonBooking_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.Transparent;
            buttonUsers.Cursor = Cursors.Hand;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsers.ForeColor = Color.White;
            buttonUsers.Location = new Point(0, 267);
            buttonUsers.Margin = new Padding(3, 4, 3, 4);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(229, 67);
            buttonUsers.TabIndex = 3;
            buttonUsers.Text = "Kelola Pengguna";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonLaporan
            // 
            buttonLaporan.BackColor = Color.Transparent;
            buttonLaporan.Cursor = Cursors.Hand;
            buttonLaporan.FlatAppearance.BorderSize = 0;
            buttonLaporan.FlatStyle = FlatStyle.Flat;
            buttonLaporan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLaporan.ForeColor = Color.White;
            buttonLaporan.Location = new Point(0, 347);
            buttonLaporan.Margin = new Padding(3, 4, 3, 4);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Size = new Size(229, 67);
            buttonLaporan.TabIndex = 4;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.UseVisualStyleBackColor = false;
            buttonLaporan.Click += buttonLaporan_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.LimeGreen;
            panelContent.BackgroundImage = (Image)resources.GetObject("panelContent.BackgroundImage");
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;
            panelContent.Controls.Add(labelTotalJadwal);
            panelContent.Controls.Add(labelTotalBooking);
            panelContent.Controls.Add(labelTotalKonsumen);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(229, 80);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(23, 27, 23, 27);
            panelContent.Size = new Size(914, 720);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // labelTotalJadwal
            // 
            labelTotalJadwal.Anchor = AnchorStyles.Top;
            labelTotalJadwal.BackColor = Color.ForestGreen;
            labelTotalJadwal.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalJadwal.ForeColor = Color.White;
            labelTotalJadwal.Location = new Point(34, 40);
            labelTotalJadwal.Name = "labelTotalJadwal";
            labelTotalJadwal.Padding = new Padding(23, 27, 23, 27);
            labelTotalJadwal.Size = new Size(251, 160);
            labelTotalJadwal.TabIndex = 0;
            labelTotalJadwal.Text = "Total Jadwal\r\n0";
            labelTotalJadwal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalBooking
            // 
            labelTotalBooking.Anchor = AnchorStyles.Top;
            labelTotalBooking.BackColor = Color.ForestGreen;
            labelTotalBooking.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalBooking.ForeColor = Color.White;
            labelTotalBooking.Location = new Point(320, 40);
            labelTotalBooking.Name = "labelTotalBooking";
            labelTotalBooking.Padding = new Padding(23, 27, 23, 27);
            labelTotalBooking.Size = new Size(251, 160);
            labelTotalBooking.TabIndex = 1;
            labelTotalBooking.Text = "Total Booking\r\n0";
            labelTotalBooking.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalKonsumen
            // 
            labelTotalKonsumen.Anchor = AnchorStyles.Top;
            labelTotalKonsumen.BackColor = Color.ForestGreen;
            labelTotalKonsumen.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalKonsumen.ForeColor = Color.White;
            labelTotalKonsumen.Location = new Point(606, 40);
            labelTotalKonsumen.Name = "labelTotalKonsumen";
            labelTotalKonsumen.Padding = new Padding(23, 27, 23, 27);
            labelTotalKonsumen.Size = new Size(251, 160);
            labelTotalKonsumen.TabIndex = 2;
            labelTotalKonsumen.Text = "Total Konsumen\r\n0";
            labelTotalKonsumen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard - AgroGrandong";
            Load += FormAdminDashboard_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonJadwal;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonLaporan;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelTotalJadwal;
        private System.Windows.Forms.Label labelTotalBooking;
        private System.Windows.Forms.Label labelTotalKonsumen;
        private PictureBox pictureBox1;
    }
}
