namespace WFABanka
{
    partial class BankaGise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvSiradakiMusteriler = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            btnSiradakiMusteri = new Button();
            lblSiraNo = new Label();
            btnIslemiTamamla = new Button();
            label2 = new Label();
            label3 = new Label();
            pbGiseMemuru = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            dgvIslemiTamamlananMusteriler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblVip = new Label();
            lblBireysel = new Label();
            lblGise = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dgvBekleyenMusteriler = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSiradakiMusteriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGiseMemuru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIslemiTamamlananMusteriler).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBekleyenMusteriler).BeginInit();
            SuspendLayout();
            // 
            // dgvSiradakiMusteriler
            // 
            dgvSiradakiMusteriler.AllowUserToAddRows = false;
            dgvSiradakiMusteriler.AllowUserToDeleteRows = false;
            dgvSiradakiMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiradakiMusteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiradakiMusteriler.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSiradakiMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSiradakiMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiradakiMusteriler.Columns.AddRange(new DataGridViewColumn[] { Column9 });
            dgvSiradakiMusteriler.Location = new Point(12, 12);
            dgvSiradakiMusteriler.MultiSelect = false;
            dgvSiradakiMusteriler.Name = "dgvSiradakiMusteriler";
            dgvSiradakiMusteriler.ReadOnly = true;
            dgvSiradakiMusteriler.RowHeadersVisible = false;
            dgvSiradakiMusteriler.RowTemplate.Height = 25;
            dgvSiradakiMusteriler.ScrollBars = ScrollBars.None;
            dgvSiradakiMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiradakiMusteriler.Size = new Size(204, 170);
            dgvSiradakiMusteriler.TabIndex = 17;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "SiraNo";
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.Format = "000";
            Column9.DefaultCellStyle = dataGridViewCellStyle2;
            Column9.HeaderText = "SIRA NO";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // btnSiradakiMusteri
            // 
            btnSiradakiMusteri.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiradakiMusteri.Location = new Point(45, 375);
            btnSiradakiMusteri.Name = "btnSiradakiMusteri";
            btnSiradakiMusteri.Size = new Size(171, 45);
            btnSiradakiMusteri.TabIndex = 18;
            btnSiradakiMusteri.Text = "Sıradaki Müşteri";
            btnSiradakiMusteri.UseVisualStyleBackColor = true;
            btnSiradakiMusteri.Click += btnSiradakiMusteri_Click;
            // 
            // lblSiraNo
            // 
            lblSiraNo.BackColor = Color.Black;
            lblSiraNo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiraNo.ForeColor = Color.Red;
            lblSiraNo.Location = new Point(458, 219);
            lblSiraNo.Name = "lblSiraNo";
            lblSiraNo.Size = new Size(106, 47);
            lblSiraNo.TabIndex = 19;
            lblSiraNo.Text = "000";
            lblSiraNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIslemiTamamla
            // 
            btnIslemiTamamla.Enabled = false;
            btnIslemiTamamla.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnIslemiTamamla.Location = new Point(324, 375);
            btnIslemiTamamla.Name = "btnIslemiTamamla";
            btnIslemiTamamla.Size = new Size(171, 45);
            btnIslemiTamamla.TabIndex = 18;
            btnIslemiTamamla.Text = "İşlemi Tamamla";
            btnIslemiTamamla.UseVisualStyleBackColor = true;
            btnIslemiTamamla.Click += btnIslemiTamamla_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkRed;
            label2.Location = new Point(495, 265);
            label2.Name = "label2";
            label2.Size = new Size(33, 287);
            label2.TabIndex = 20;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkRed;
            label3.Location = new Point(12, 357);
            label3.Name = "label3";
            label3.Size = new Size(483, 195);
            label3.TabIndex = 21;
            // 
            // pbGiseMemuru
            // 
            pbGiseMemuru.Image = Properties.Resources.bankaCalisani;
            pbGiseMemuru.Location = new Point(205, 241);
            pbGiseMemuru.Name = "pbGiseMemuru";
            pbGiseMemuru.Size = new Size(125, 116);
            pbGiseMemuru.SizeMode = PictureBoxSizeMode.Zoom;
            pbGiseMemuru.TabIndex = 22;
            pbGiseMemuru.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(179, 88);
            label4.TabIndex = 23;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Location = new Point(92, 329);
            label5.Name = "label5";
            label5.Size = new Size(20, 28);
            label5.TabIndex = 24;
            // 
            // dgvIslemiTamamlananMusteriler
            // 
            dgvIslemiTamamlananMusteriler.AllowUserToAddRows = false;
            dgvIslemiTamamlananMusteriler.AllowUserToDeleteRows = false;
            dgvIslemiTamamlananMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIslemiTamamlananMusteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvIslemiTamamlananMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIslemiTamamlananMusteriler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7 });
            dgvIslemiTamamlananMusteriler.Location = new Point(3, 270);
            dgvIslemiTamamlananMusteriler.MultiSelect = false;
            dgvIslemiTamamlananMusteriler.Name = "dgvIslemiTamamlananMusteriler";
            dgvIslemiTamamlananMusteriler.ReadOnly = true;
            dgvIslemiTamamlananMusteriler.RowHeadersVisible = false;
            dgvIslemiTamamlananMusteriler.RowTemplate.Height = 25;
            dgvIslemiTamamlananMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIslemiTamamlananMusteriler.Size = new Size(476, 186);
            dgvIslemiTamamlananMusteriler.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TcNo";
            Column1.HeaderText = "Tc No";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Ad";
            Column2.HeaderText = "Ad";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Soyad";
            Column3.HeaderText = "Soyad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SiraNo";
            Column4.HeaderText = "Sıra No";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "OncelikliMi";
            Column5.HeaderText = "VIP";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "YapilacakIslem";
            Column7.HeaderText = "İşlem";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(768, 12);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 26;
            label6.Text = "Bilgisayar Ekranı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(235, 96);
            label1.Name = "label1";
            label1.Size = new Size(293, 90);
            label1.TabIndex = 27;
            label1.Text = "XBANK";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblVip);
            panel1.Controls.Add(lblBireysel);
            panel1.Controls.Add(lblGise);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgvBekleyenMusteriler);
            panel1.Controls.Add(dgvIslemiTamamlananMusteriler);
            panel1.Location = new Point(590, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 512);
            panel1.TabIndex = 28;
            // 
            // lblVip
            // 
            lblVip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVip.Location = new Point(427, 480);
            lblVip.Name = "lblVip";
            lblVip.Size = new Size(34, 23);
            lblVip.TabIndex = 29;
            lblVip.Text = "0";
            // 
            // lblBireysel
            // 
            lblBireysel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBireysel.Location = new Point(289, 480);
            lblBireysel.Name = "lblBireysel";
            lblBireysel.Size = new Size(34, 23);
            lblBireysel.TabIndex = 29;
            lblBireysel.Text = "0";
            // 
            // lblGise
            // 
            lblGise.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGise.Location = new Point(120, 480);
            lblGise.Name = "lblGise";
            lblGise.Size = new Size(34, 23);
            lblGise.TabIndex = 29;
            lblGise.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(329, 480);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 28;
            label11.Text = "Vip İşlemler";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(160, 480);
            label10.Name = "label10";
            label10.Size = new Size(123, 21);
            label10.TabIndex = 28;
            label10.Text = "Bireysel İşlemler";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 480);
            label9.Name = "label9";
            label9.Size = new Size(103, 21);
            label9.TabIndex = 28;
            label9.Text = "Gişe İşlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 242);
            label8.Name = "label8";
            label8.Size = new Size(218, 21);
            label8.TabIndex = 27;
            label8.Text = "İşlemi Tamamlanan Müşteriler";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(141, 21);
            label7.TabIndex = 27;
            label7.Text = "Sıradaki Müşteriler";
            // 
            // dgvBekleyenMusteriler
            // 
            dgvBekleyenMusteriler.AllowUserToAddRows = false;
            dgvBekleyenMusteriler.AllowUserToDeleteRows = false;
            dgvBekleyenMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBekleyenMusteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBekleyenMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBekleyenMusteriler.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column6 });
            dgvBekleyenMusteriler.Location = new Point(3, 40);
            dgvBekleyenMusteriler.MultiSelect = false;
            dgvBekleyenMusteriler.Name = "dgvBekleyenMusteriler";
            dgvBekleyenMusteriler.ReadOnly = true;
            dgvBekleyenMusteriler.RowHeadersVisible = false;
            dgvBekleyenMusteriler.RowTemplate.Height = 25;
            dgvBekleyenMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBekleyenMusteriler.Size = new Size(476, 186);
            dgvBekleyenMusteriler.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "TcNo";
            dataGridViewTextBoxColumn1.HeaderText = "Tc No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Ad";
            dataGridViewTextBoxColumn2.HeaderText = "Ad";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Soyad";
            dataGridViewTextBoxColumn3.HeaderText = "Soyad";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "SiraNo";
            dataGridViewTextBoxColumn4.HeaderText = "Sıra No";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "OncelikliMi";
            dataGridViewTextBoxColumn5.HeaderText = "VIP";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "YapilacakIslem";
            Column6.HeaderText = "İşlem";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // BankaGise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pbGiseMemuru);
            Controls.Add(lblSiraNo);
            Controls.Add(btnIslemiTamamla);
            Controls.Add(btnSiradakiMusteri);
            Controls.Add(dgvSiradakiMusteriler);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "BankaGise";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gişe";
            ((System.ComponentModel.ISupportInitialize)dgvSiradakiMusteriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGiseMemuru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIslemiTamamlananMusteriler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBekleyenMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSiradakiMusteriler;
        private Button btnSiradakiMusteri;
        private Label lblSiraNo;
        private Button btnIslemiTamamla;
        private Label label2;
        private Label label3;
        private PictureBox pbGiseMemuru;
        private Label label4;
        private Label label5;
        private DataGridView dgvIslemiTamamlananMusteriler;
        private Label label6;
        private Label label1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private DataGridView dgvBekleyenMusteriler;
        private DataGridViewTextBoxColumn Column9;
        private Label lblVip;
        private Label lblBireysel;
        private Label lblGise;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
    }
}