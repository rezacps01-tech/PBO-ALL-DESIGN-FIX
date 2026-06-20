namespace AgroGrandong.Forms
{
    partial class FormManageSchedule
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridSchedules;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridSchedules = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSchedules).BeginInit();
            SuspendLayout();
            // 
            // dataGridSchedules
            // 
            dataGridSchedules.AllowUserToAddRows = false;
            dataGridSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSchedules.ColumnHeadersHeight = 29;
            dataGridSchedules.Location = new Point(23, 93);
            dataGridSchedules.Margin = new Padding(3, 4, 3, 4);
            dataGridSchedules.MultiSelect = false;
            dataGridSchedules.Name = "dataGridSchedules";
            dataGridSchedules.ReadOnly = true;
            dataGridSchedules.RowHeadersWidth = 51;
            dataGridSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSchedules.Size = new Size(983, 667);
            dataGridSchedules.TabIndex = 4;
            dataGridSchedules.CellClick += dataGridSchedules_CellClick;
            dataGridSchedules.CellContentClick += dataGridSchedules_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(23, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 47);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Green;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(171, 27);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 47);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(320, 27);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 47);
            btnDelete.TabIndex = 2;
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
            btnRefresh.Location = new Point(469, 27);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(137, 47);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormManageSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1029, 800);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridSchedules);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormManageSchedule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kelola Jadwal - AgroGrandong";
            Load += FormManageSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSchedules).EndInit();
            ResumeLayout(false);
        }
    }
}
