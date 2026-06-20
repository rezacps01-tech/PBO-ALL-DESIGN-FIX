namespace AgroGrandong.Forms
{
    partial class FormLaporan
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridLaporan;
        private Button btnRefresh;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridLaporan = new DataGridView();
            btnRefresh = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridLaporan).BeginInit();
            SuspendLayout();
            // 
            // dataGridLaporan
            // 
            dataGridLaporan.AllowUserToAddRows = false;
            dataGridLaporan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLaporan.ColumnHeadersHeight = 29;
            dataGridLaporan.Location = new Point(23, 133);
            dataGridLaporan.Margin = new Padding(3, 4, 3, 4);
            dataGridLaporan.MultiSelect = false;
            dataGridLaporan.Name = "dataGridLaporan";
            dataGridLaporan.ReadOnly = true;
            dataGridLaporan.RowHeadersWidth = 51;
            dataGridLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLaporan.Size = new Size(869, 507);
            dataGridLaporan.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Lime;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(23, 67);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(137, 47);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(419, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LAPORAN BOOKING & PENDAPATAN";
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(914, 667);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridLaporan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLaporan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Laporan - AgroGrandong";
            ((System.ComponentModel.ISupportInitialize)dataGridLaporan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
