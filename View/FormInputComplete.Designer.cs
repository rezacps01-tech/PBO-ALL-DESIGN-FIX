namespace AgroGrandong.Forms
{
    partial class FormInputComplete
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtWeight;
        private TextBox txtPrice;
        private Label lblHint;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtWeight = new TextBox();
            txtPrice = new TextBox();
            lblHint = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblW = new Label();
            lblP = new Label();
            BeratAktual = new Label();
            TotalHarga = new Label();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(183, 27);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(171, 27);
            txtWeight.TabIndex = 1;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(240, 240, 240);
            txtPrice.Location = new Point(183, 73);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(171, 27);
            txtPrice.TabIndex = 3;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.BackColor = Color.Transparent;
            lblHint.ForeColor = Color.Black;
            lblHint.Location = new Point(23, 120);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(197, 20);
            lblHint.TabIndex = 4;
            lblHint.Text = "* Otomatis: berat x harga/kg";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 173);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 47);
            btnSave.TabIndex = 5;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(171, 173);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 47);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblW
            // 
            lblW.Location = new Point(0, 0);
            lblW.Name = "lblW";
            lblW.Size = new Size(114, 31);
            lblW.TabIndex = 0;
            // 
            // lblP
            // 
            lblP.Location = new Point(0, 0);
            lblP.Name = "lblP";
            lblP.Size = new Size(114, 31);
            lblP.TabIndex = 2;
            // 
            // BeratAktual
            // 
            BeratAktual.AutoSize = true;
            BeratAktual.Location = new Point(23, 30);
            BeratAktual.Name = "BeratAktual";
            BeratAktual.Size = new Size(129, 20);
            BeratAktual.TabIndex = 7;
            BeratAktual.Text = "Berat Aktual (Kg) :";
            // 
            // TotalHarga
            // 
            TotalHarga.AutoSize = true;
            TotalHarga.Location = new Point(23, 76);
            TotalHarga.Name = "TotalHarga";
            TotalHarga.Size = new Size(126, 20);
            TotalHarga.TabIndex = 8;
            TotalHarga.Text = "Total Harga (Rp) :";
            // 
            // FormInputComplete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(389, 247);
            Controls.Add(TotalHarga);
            Controls.Add(BeratAktual);
            Controls.Add(lblW);
            Controls.Add(txtWeight);
            Controls.Add(lblP);
            Controls.Add(txtPrice);
            Controls.Add(lblHint);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormInputComplete";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Selesaikan Booking";
            Load += FormInputComplete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblW;
        private Label lblP;
        private Label BeratAktual;
        private Label TotalHarga;
    }
}
