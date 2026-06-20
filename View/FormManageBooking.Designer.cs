namespace AgroGrandong.Forms
{
    partial class FormManageBooking
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridBookings;
        private Button btnConfirm;
        private Button btnComplete;
        private Button btnCancel;
        private Button btnDeleteBooking;
        private Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridBookings = new DataGridView();
            btnConfirm = new Button();
            btnComplete = new Button();
            btnCancel = new Button();
            btnDeleteBooking = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBookings).BeginInit();
            SuspendLayout();
            // 
            // dataGridBookings
            // 
            dataGridBookings.AllowUserToAddRows = false;
            dataGridBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBookings.ColumnHeadersHeight = 29;
            dataGridBookings.Location = new Point(23, 93);
            dataGridBookings.Margin = new Padding(3, 4, 3, 4);
            dataGridBookings.MultiSelect = false;
            dataGridBookings.Name = "dataGridBookings";
            dataGridBookings.ReadOnly = true;
            dataGridBookings.RowHeadersWidth = 51;
            dataGridBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBookings.Size = new Size(983, 680);
            dataGridBookings.TabIndex = 5;
            dataGridBookings.CellClick += dataGridBookings_CellClick;
            dataGridBookings.CellContentClick += this.dataGridBookings_CellContentClick;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(23, 27);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(137, 47);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Terima";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.Green;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComplete.ForeColor = Color.White;
            btnComplete.Location = new Point(171, 27);
            btnComplete.Margin = new Padding(3, 4, 3, 4);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(137, 47);
            btnComplete.TabIndex = 1;
            btnComplete.Text = "Selesai";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LimeGreen;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(320, 27);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 47);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Batalkan";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.BackColor = Color.Red;
            btnDeleteBooking.FlatStyle = FlatStyle.Flat;
            btnDeleteBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteBooking.ForeColor = Color.White;
            btnDeleteBooking.Location = new Point(469, 27);
            btnDeleteBooking.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(137, 47);
            btnDeleteBooking.TabIndex = 3;
            btnDeleteBooking.Text = "Hapus";
            btnDeleteBooking.UseVisualStyleBackColor = false;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(617, 27);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(137, 47);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormManageBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1029, 800);
            Controls.Add(btnConfirm);
            Controls.Add(btnComplete);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteBooking);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridBookings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormManageBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kelola Booking - AgroGrandong";
            Load += FormManageBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridBookings).EndInit();
            ResumeLayout(false);
        }
    }
}
