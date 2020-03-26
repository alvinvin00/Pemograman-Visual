namespace DataGridView {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKontak = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDaftar = new System.Windows.Forms.GroupBox();
            this.dgvDataKontak = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbKontak.SuspendLayout();
            this.gbDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDataKontak)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(362, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Data Kontak";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbKontak
            // 
            this.gbKontak.Controls.Add(this.btnClear);
            this.gbKontak.Controls.Add(this.btnTambah);
            this.gbKontak.Controls.Add(this.txtNoHP);
            this.gbKontak.Controls.Add(this.txtKeterangan);
            this.gbKontak.Controls.Add(this.txtNama);
            this.gbKontak.Controls.Add(this.label4);
            this.gbKontak.Controls.Add(this.label3);
            this.gbKontak.Controls.Add(this.label2);
            this.gbKontak.Location = new System.Drawing.Point(12, 132);
            this.gbKontak.Name = "gbKontak";
            this.gbKontak.Size = new System.Drawing.Size(909, 233);
            this.gbKontak.TabIndex = 1;
            this.gbKontak.TabStop = false;
            this.gbKontak.Text = "Kontak";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(549, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(353, 80);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(549, 35);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(353, 80);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(93, 73);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(266, 23);
            this.txtNoHP.TabIndex = 1;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(93, 110);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(408, 106);
            this.txtKeterangan.TabIndex = 2;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(93, 35);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(266, 23);
            this.txtNama.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nomor HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // gbDaftar
            // 
            this.gbDaftar.Controls.Add(this.dgvDataKontak);
            this.gbDaftar.Location = new System.Drawing.Point(12, 382);
            this.gbDaftar.Name = "gbDaftar";
            this.gbDaftar.Size = new System.Drawing.Size(909, 237);
            this.gbDaftar.TabIndex = 2;
            this.gbDaftar.TabStop = false;
            this.gbDaftar.Text = "Daftar Data Kontak";
            // 
            // dgvDataKontak
            // 
            this.dgvDataKontak.AllowUserToAddRows = false;
            this.dgvDataKontak.AllowUserToDeleteRows = false;
            this.dgvDataKontak.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataKontak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.no, this.nama, this.noHP, this.keterangan});
            this.dgvDataKontak.Location = new System.Drawing.Point(6, 23);
            this.dgvDataKontak.Name = "dgvDataKontak";
            this.dgvDataKontak.ReadOnly = true;
            this.dgvDataKontak.RowHeadersVisible = false;
            this.dgvDataKontak.Size = new System.Drawing.Size(897, 208);
            this.dgvDataKontak.TabIndex = 0;
            this.dgvDataKontak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDataKontak_KeyDown);
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 80;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 150;
            // 
            // noHP
            // 
            this.noHP.HeaderText = "Nomor HP";
            this.noHP.Name = "noHP";
            this.noHP.ReadOnly = true;
            // 
            // keterangan
            // 
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            this.keterangan.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 631);
            this.Controls.Add(this.gbDaftar);
            this.Controls.Add(this.gbKontak);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Aplikasi Data Kontak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbKontak.ResumeLayout(false);
            this.gbKontak.PerformLayout();
            this.gbDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvDataKontak)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbKontak;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbDaftar;
        private System.Windows.Forms.DataGridView dgvDataKontak;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
    }
}