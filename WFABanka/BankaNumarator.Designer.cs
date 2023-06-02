namespace WFABanka
{
    partial class BankaNumarator
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
            btnSiraAl = new Button();
            lblHosgeldin = new Label();
            label1 = new Label();
            txtTcNo = new TextBox();
            lblMusteri = new Label();
            btnGiseyeGit = new Button();
            btnMusterileriGoster = new Button();
            label2 = new Label();
            label3 = new Label();
            scMusteriler = new SplitContainer();
            dgvVipMusteriler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgvBireyselMusteriler = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)scMusteriler).BeginInit();
            scMusteriler.Panel1.SuspendLayout();
            scMusteriler.Panel2.SuspendLayout();
            scMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVipMusteriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBireyselMusteriler).BeginInit();
            SuspendLayout();
            // 
            // btnSiraAl
            // 
            btnSiraAl.Enabled = false;
            btnSiraAl.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiraAl.Location = new Point(28, 303);
            btnSiraAl.Name = "btnSiraAl";
            btnSiraAl.Size = new Size(529, 71);
            btnSiraAl.TabIndex = 9;
            btnSiraAl.Text = "SIRA AL";
            btnSiraAl.UseVisualStyleBackColor = true;
            btnSiraAl.Click += btnSiraAl_Click;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Font = new Font("Arial Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblHosgeldin.ForeColor = Color.DarkRed;
            lblHosgeldin.Location = new Point(161, 2);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(219, 68);
            lblHosgeldin.TabIndex = 8;
            lblHosgeldin.Text = "XBANK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 133);
            label1.Name = "label1";
            label1.Size = new Size(441, 65);
            label1.TabIndex = 7;
            label1.Text = "Lütfen Tc No Giriniz";
            // 
            // txtTcNo
            // 
            txtTcNo.BorderStyle = BorderStyle.FixedSingle;
            txtTcNo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtTcNo.Location = new Point(28, 213);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(529, 71);
            txtTcNo.TabIndex = 6;
            txtTcNo.TextChanged += txtTcNo_TextChanged;
            txtTcNo.KeyPress += txtTcNo_KeyPress;
            // 
            // lblMusteri
            // 
            lblMusteri.BackColor = Color.Silver;
            lblMusteri.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblMusteri.Location = new Point(28, 385);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.Size = new Size(529, 167);
            lblMusteri.TabIndex = 12;
            // 
            // btnGiseyeGit
            // 
            btnGiseyeGit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiseyeGit.Location = new Point(594, 473);
            btnGiseyeGit.Name = "btnGiseyeGit";
            btnGiseyeGit.Size = new Size(458, 79);
            btnGiseyeGit.TabIndex = 13;
            btnGiseyeGit.Text = "GİŞEYE GİT";
            btnGiseyeGit.UseVisualStyleBackColor = true;
            btnGiseyeGit.Click += btnGiseyeGit_Click;
            // 
            // btnMusterileriGoster
            // 
            btnMusterileriGoster.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusterileriGoster.Location = new Point(672, 12);
            btnMusterileriGoster.Name = "btnMusterileriGoster";
            btnMusterileriGoster.Size = new Size(305, 62);
            btnMusterileriGoster.TabIndex = 13;
            btnMusterileriGoster.Text = "MÜŞTERİLERİ GÖSTER";
            btnMusterileriGoster.UseVisualStyleBackColor = true;
            btnMusterileriGoster.Click += btnMusterileriGoster_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 15;
            label2.Text = "Vip Müşteriler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 15;
            label3.Text = "Bireysel Müşteriler";
            // 
            // scMusteriler
            // 
            scMusteriler.Location = new Point(594, 80);
            scMusteriler.Name = "scMusteriler";
            scMusteriler.Orientation = Orientation.Horizontal;
            // 
            // scMusteriler.Panel1
            // 
            scMusteriler.Panel1.Controls.Add(dgvVipMusteriler);
            scMusteriler.Panel1.Controls.Add(label2);
            // 
            // scMusteriler.Panel2
            // 
            scMusteriler.Panel2.Controls.Add(dgvBireyselMusteriler);
            scMusteriler.Panel2.Controls.Add(label3);
            scMusteriler.Size = new Size(458, 387);
            scMusteriler.SplitterDistance = 194;
            scMusteriler.TabIndex = 16;
            scMusteriler.Visible = false;
            // 
            // dgvVipMusteriler
            // 
            dgvVipMusteriler.AllowUserToAddRows = false;
            dgvVipMusteriler.AllowUserToDeleteRows = false;
            dgvVipMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVipMusteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVipMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVipMusteriler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvVipMusteriler.Location = new Point(0, 28);
            dgvVipMusteriler.MultiSelect = false;
            dgvVipMusteriler.Name = "dgvVipMusteriler";
            dgvVipMusteriler.ReadOnly = true;
            dgvVipMusteriler.RowHeadersVisible = false;
            dgvVipMusteriler.RowTemplate.Height = 25;
            dgvVipMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVipMusteriler.Size = new Size(458, 162);
            dgvVipMusteriler.TabIndex = 26;
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
            // dgvBireyselMusteriler
            // 
            dgvBireyselMusteriler.AllowUserToAddRows = false;
            dgvBireyselMusteriler.AllowUserToDeleteRows = false;
            dgvBireyselMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBireyselMusteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBireyselMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBireyselMusteriler.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvBireyselMusteriler.Location = new Point(0, 26);
            dgvBireyselMusteriler.MultiSelect = false;
            dgvBireyselMusteriler.Name = "dgvBireyselMusteriler";
            dgvBireyselMusteriler.ReadOnly = true;
            dgvBireyselMusteriler.RowHeadersVisible = false;
            dgvBireyselMusteriler.RowTemplate.Height = 25;
            dgvBireyselMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBireyselMusteriler.Size = new Size(458, 162);
            dgvBireyselMusteriler.TabIndex = 27;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(137, 68);
            label4.Name = "label4";
            label4.Size = new Size(276, 65);
            label4.TabIndex = 7;
            label4.Text = "Hoşgeldiniz";
            // 
            // BankaNumarator
            // 
            AcceptButton = btnSiraAl;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1084, 561);
            Controls.Add(scMusteriler);
            Controls.Add(btnMusterileriGoster);
            Controls.Add(btnGiseyeGit);
            Controls.Add(lblMusteri);
            Controls.Add(btnSiraAl);
            Controls.Add(lblHosgeldin);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtTcNo);
            Name = "BankaNumarator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Numaratör";
            scMusteriler.Panel1.ResumeLayout(false);
            scMusteriler.Panel1.PerformLayout();
            scMusteriler.Panel2.ResumeLayout(false);
            scMusteriler.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scMusteriler).EndInit();
            scMusteriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVipMusteriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBireyselMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiraAl;
        private Label lblHosgeldin;
        private Label label1;
        private TextBox txtTcNo;
        private Label lblMusteri;
        private Button btnGiseyeGit;
        private Button btnMusterileriGoster;
        private Label label2;
        private Label label3;
        private SplitContainer scMusteriler;
        private DataGridView dgvVipMusteriler;
        private DataGridView dgvBireyselMusteriler;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label4;
    }
}