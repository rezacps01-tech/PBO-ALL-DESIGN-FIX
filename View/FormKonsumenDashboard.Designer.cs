namespace AgroGrandong.Forms
{
    partial class FormKonsumenDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelTop;
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnProfile;
        private Label lblScheduleTitle;
        private DataGridView dataGridSchedules;
        private Button btnBook;
        private Label lblBookingTitle;
        private DataGridView dataGridBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKonsumenDashboard));
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            btnProfile = new Button();
            btnLogout = new Button();
            lblScheduleTitle = new Label();
            dataGridSchedules = new DataGridView();
            btnBook = new Button();
            lblBookingTitle = new Label();
            dataGridBookings = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSchedules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBookings).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 192, 0);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(btnProfile);
            panelTop.Controls.Add(btnLogout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1029, 80);
            panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(67, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(361, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "DASHBOARD KONSUMEN";
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.BackColor = Color.DarkCyan;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(731, 20);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(137, 40);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "PROFILE";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Crimson;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(880, 20);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(137, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblScheduleTitle
            // 
            lblScheduleTitle.AutoSize = true;
            lblScheduleTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblScheduleTitle.Location = new Point(23, 100);
            lblScheduleTitle.Name = "lblScheduleTitle";
            lblScheduleTitle.Size = new Size(149, 25);
            lblScheduleTitle.TabIndex = 3;
            lblScheduleTitle.Text = "Jadwal Tersedia";
            // 
            // dataGridSchedules
            // 
            dataGridSchedules.AllowUserToAddRows = false;
            dataGridSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSchedules.BackgroundColor = Color.SeaGreen;
            dataGridSchedules.ColumnHeadersHeight = 29;
            dataGridSchedules.Location = new Point(23, 139);
            dataGridSchedules.Margin = new Padding(3, 4, 3, 4);
            dataGridSchedules.MultiSelect = false;
            dataGridSchedules.Name = "dataGridSchedules";
            dataGridSchedules.ReadOnly = true;
            dataGridSchedules.RowHeadersWidth = 51;
            dataGridSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSchedules.Size = new Size(983, 320);
            dataGridSchedules.TabIndex = 4;
            dataGridSchedules.CellContentClick += dataGridSchedules_CellContentClick;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Blue;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(23, 536);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.RightToLeft = RightToLeft.Yes;
            btnBook.Size = new Size(166, 47);
            btnBook.TabIndex = 5;
            btnBook.Text = "Booking Jadwal";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookingTitle.Location = new Point(23, 587);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(134, 25);
            lblBookingTitle.TabIndex = 6;
            lblBookingTitle.Text = "Booking Saya";
            // 
            // dataGridBookings
            // 
            dataGridBookings.AllowUserToAddRows = false;
            dataGridBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBookings.BackgroundColor = Color.SeaGreen;
            dataGridBookings.ColumnHeadersHeight = 29;
            dataGridBookings.Location = new Point(23, 630);
            dataGridBookings.Margin = new Padding(3, 4, 3, 4);
            dataGridBookings.MultiSelect = false;
            dataGridBookings.Name = "dataGridBookings";
            dataGridBookings.ReadOnly = true;
            dataGridBookings.RowHeadersWidth = 51;
            dataGridBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBookings.Size = new Size(983, 257);
            dataGridBookings.TabIndex = 7;
            // 
            // FormKonsumenDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1029, 920);
            Controls.Add(btnBook);
            Controls.Add(panelTop);
            Controls.Add(lblScheduleTitle);
            Controls.Add(dataGridSchedules);
            Controls.Add(lblBookingTitle);
            Controls.Add(dataGridBookings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormKonsumenDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Konsumen - AgroGrandong";
            Load += FormKonsumenDashboard_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSchedules).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}
