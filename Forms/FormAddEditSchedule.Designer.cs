namespace AgroGrandong.Forms
{
    partial class FormAddEditSchedule
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLocation;
        private TextBox txtAddress;
        private TextBox txtCapacity;
        private TextBox txtPrice;
        private TextBox txtNotes;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
        private Label lblLoc;
        private Label lblAddr;
        private Label lblDate;
        private Label lblStart;
        private Label lblEnd;
        private Label lblCap;
        private Label lblPrice;
        private Label lblStatus;
        private Label lblNotes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtLocation = new TextBox();
            txtAddress = new TextBox();
            txtCapacity = new TextBox();
            txtPrice = new TextBox();
            txtNotes = new TextBox();
            dtpDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblLoc = new Label();
            lblAddr = new Label();
            lblDate = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            lblCap = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            lblNotes = new Label();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(160, 27);
            txtLocation.Margin = new Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(331, 27);
            txtLocation.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(160, 73);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(331, 65);
            txtAddress.TabIndex = 3;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(160, 293);
            txtCapacity.Margin = new Padding(3, 4, 3, 4);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(114, 27);
            txtCapacity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 340);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(171, 27);
            txtPrice.TabIndex = 13;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(160, 433);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(331, 65);
            txtNotes.TabIndex = 17;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(160, 153);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(228, 27);
            dtpDate.TabIndex = 5;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(160, 200);
            dtpStartTime.Margin = new Padding(3, 4, 3, 4);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(159, 27);
            dtpStartTime.TabIndex = 7;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(160, 247);
            dtpEndTime.Margin = new Padding(3, 4, 3, 4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(159, 27);
            dtpEndTime.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "available", "full", "cancelled", "completed" });
            cmbStatus.Location = new Point(160, 387);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(171, 28);
            cmbStatus.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(160, 520);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 47);
            btnSave.TabIndex = 18;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSeaGreen;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(309, 520);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 47);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.ForeColor = Color.Black;
            lblLoc.Location = new Point(23, 31);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(53, 20);
            lblLoc.TabIndex = 0;
            lblLoc.Text = "Lokasi:";
            // 
            // lblAddr
            // 
            lblAddr.AutoSize = true;
            lblAddr.Location = new Point(23, 77);
            lblAddr.Name = "lblAddr";
            lblAddr.Size = new Size(60, 20);
            lblAddr.TabIndex = 2;
            lblAddr.Text = "Alamat:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(23, 157);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Tanggal:";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(23, 204);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(94, 20);
            lblStart.TabIndex = 6;
            lblStart.Text = "Waktu Mulai:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(23, 251);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(103, 20);
            lblEnd.TabIndex = 8;
            lblEnd.Text = "Waktu Selesai:";
            // 
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Location = new Point(23, 297);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(75, 20);
            lblCap.TabIndex = 10;
            lblCap.Text = "Kapasitas:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 344);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(77, 20);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Harga/Kg:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 391);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(23, 437);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(88, 20);
            lblNotes.TabIndex = 16;
            lblNotes.Text = "Keterangan:";
            // 
            // FormAddEditSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(526, 593);
            Controls.Add(lblLoc);
            Controls.Add(txtLocation);
            Controls.Add(lblAddr);
            Controls.Add(txtAddress);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblStart);
            Controls.Add(dtpStartTime);
            Controls.Add(lblEnd);
            Controls.Add(dtpEndTime);
            Controls.Add(lblCap);
            Controls.Add(txtCapacity);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAddEditSchedule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Jadwal";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
