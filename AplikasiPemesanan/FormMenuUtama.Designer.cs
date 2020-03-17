namespace AplikasiPemesanan
{
    partial class FormMenuUtama
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
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.numericJumlah = new System.Windows.Forms.NumericUpDown();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.gbAksi = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.lvPesanan = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).BeginInit();
            this.gbAksi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 127);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi Pemesanan Makanan";
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.numericJumlah);
            this.gbMenu.Controls.Add(this.cbMenu);
            this.gbMenu.Controls.Add(this.txtHarga);
            this.gbMenu.Controls.Add(this.lblJumlah);
            this.gbMenu.Controls.Add(this.lblHarga);
            this.gbMenu.Controls.Add(this.lblMenu);
            this.gbMenu.Location = new System.Drawing.Point(12, 133);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(357, 133);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Data Menu";
            // 
            // numericJumlah
            // 
            this.numericJumlah.Location = new System.Drawing.Point(132, 71);
            this.numericJumlah.Name = "numericJumlah";
            this.numericJumlah.Size = new System.Drawing.Size(35, 20);
            this.numericJumlah.TabIndex = 8;
            // 
            // cbMenu
            // 
            this.cbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(132, 19);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(184, 21);
            this.cbMenu.TabIndex = 6;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(132, 45);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(111, 20);
            this.txtHarga.TabIndex = 5;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(12, 74);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(40, 13);
            this.lblJumlah.TabIndex = 2;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(12, 48);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 1;
            this.lblHarga.Text = "Harga";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(12, 22);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(82, 13);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Makanan";
            // 
            // gbAksi
            // 
            this.gbAksi.Controls.Add(this.btnBatal);
            this.gbAksi.Controls.Add(this.btnTambah);
            this.gbAksi.Location = new System.Drawing.Point(375, 152);
            this.gbAksi.Name = "gbAksi";
            this.gbAksi.Size = new System.Drawing.Size(413, 114);
            this.gbAksi.TabIndex = 12;
            this.gbAksi.TabStop = false;
            this.gbAksi.Text = "Aksi";
            // 
            // btnBatal
            // 
            this.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBatal.Location = new System.Drawing.Point(217, 19);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(190, 46);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "&BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTambah.Location = new System.Drawing.Point(0, 19);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(190, 46);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "&TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotalBayar);
            this.groupBox1.Controls.Add(this.lvPesanan);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 237);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Item";
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Location = new System.Drawing.Point(71, 221);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(13, 13);
            this.lblTotalItem.TabIndex = 3;
            this.lblTotalItem.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Bayar";
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Location = new System.Drawing.Point(644, 221);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(13, 13);
            this.lblTotalBayar.TabIndex = 1;
            this.lblTotalBayar.Text = "0";
            // 
            // lvPesanan
            // 
            this.lvPesanan.HideSelection = false;
            this.lvPesanan.Location = new System.Drawing.Point(6, 19);
            this.lvPesanan.Name = "lvPesanan";
            this.lvPesanan.Size = new System.Drawing.Size(758, 187);
            this.lvPesanan.TabIndex = 0;
            this.lvPesanan.UseCompatibleStateImageBehavior = false;
            this.lvPesanan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPesanan_KeyDown);
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAksi);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMenuUtama";
            this.Text = "Aplikasi Pemesanan";
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJumlah)).EndInit();
            this.gbAksi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.NumericUpDown numericJumlah;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.GroupBox gbAksi;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.ListView lvPesanan;
    }
}

