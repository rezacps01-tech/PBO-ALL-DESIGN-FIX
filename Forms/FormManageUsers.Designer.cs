namespace AgroGrandong.Forms
{
    partial class FormManageUsers
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridUsers;
        private Button btnDelete;
        private Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridUsers = new DataGridView();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsers
            // 
            dataGridUsers.AllowUserToAddRows = false;
            dataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsers.ColumnHeadersHeight = 29;
            dataGridUsers.Location = new Point(23, 93);
            dataGridUsers.Margin = new Padding(3, 4, 3, 4);
            dataGridUsers.MultiSelect = false;
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.ReadOnly = true;
            dataGridUsers.RowHeadersWidth = 51;
            dataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsers.Size = new Size(983, 667);
            dataGridUsers.TabIndex = 2;
            dataGridUsers.CellClick += dataGridUsers_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(23, 27);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 47);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(171, 27);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(137, 47);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1029, 800);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridUsers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormManageUsers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kelola Pengguna - AgroGrandong";
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
        }
    }
}
