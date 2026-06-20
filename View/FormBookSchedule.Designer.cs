namespace AgroGrandong.Forms
{
    partial class FormBookSchedule
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblScheduleInfo;
        private TextBox txtWeight;
        private TextBox txtNotes;
        private Button btnSubmit;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblScheduleInfo = new Label();
            txtWeight = new TextBox();
            txtNotes = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblWeight = new Label();
            lblNotes = new Label();
            estimasi_berat = new Label();
            Catatan = new Label();
            SuspendLayout();
            // 
            // lblScheduleInfo
            // 
            lblScheduleInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblScheduleInfo.Location = new Point(23, 27);
            lblScheduleInfo.Name = "lblScheduleInfo";
            lblScheduleInfo.Size = new Size(434, 107);
            lblScheduleInfo.TabIndex = 0;
            lblScheduleInfo.Text = "Info Jadwal";
            lblScheduleInfo.Click += lblScheduleInfo_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(194, 147);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(171, 27);
            txtWeight.TabIndex = 2;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(23, 227);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(434, 79);
            txtNotes.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(40, 167, 69);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(23, 327);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(137, 47);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Booking";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(171, 327);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 47);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblWeight
            // 
            lblWeight.Location = new Point(0, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(114, 31);
            lblWeight.TabIndex = 1;
            // 
            // lblNotes
            // 
            lblNotes.Location = new Point(0, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(114, 31);
            lblNotes.TabIndex = 3;
            // 
            // estimasi_berat
            // 
            estimasi_berat.AutoSize = true;
            estimasi_berat.Location = new Point(36, 150);
            estimasi_berat.Name = "estimasi_berat";
            estimasi_berat.Size = new Size(136, 20);
            estimasi_berat.TabIndex = 7;
            estimasi_berat.Text = "EStimasi Berat (Kg)";
            // 
            // Catatan
            // 
            Catatan.AutoSize = true;
            Catatan.Location = new Point(23, 203);
            Catatan.Name = "Catatan";
            Catatan.Size = new Size(60, 20);
            Catatan.TabIndex = 8;
            Catatan.Text = "Catatan";
            Catatan.Click += label1_Click;
            // 
            // FormBookSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(480, 400);
            Controls.Add(Catatan);
            Controls.Add(estimasi_berat);
            Controls.Add(lblScheduleInfo);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormBookSchedule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Booking Jadwal - AgroGrandong";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblWeight;
        private Label lblNotes;
        private Label estimasi_berat;
        private Label Catatan;
    }
}
