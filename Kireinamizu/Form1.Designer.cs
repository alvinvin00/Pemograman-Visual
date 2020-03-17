namespace Kireinamizu
{
    partial class Form1
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
            this.lblRek = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblGolongan = new System.Windows.Forms.Label();
            this.lblBeban = new System.Windows.Forms.Label();
            this.lblKembali = new System.Windows.Forms.Label();
            this.lblTglBayar = new System.Windows.Forms.Label();
            this.lblBayar = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDenda = new System.Windows.Forms.Label();
            this.lblAir = new System.Windows.Forms.Label();
            this.lblDibayar = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtGolongan = new System.Windows.Forms.TextBox();
            this.numAir = new System.Windows.Forms.NumericUpDown();
            this.txtBeban = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.txtNoRek = new System.Windows.Forms.TextBox();
            this.txtDenda = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBayar = new System.Windows.Forms.DateTimePicker();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 111);
            this.panel1.TabIndex = 0;
            // 
            // lblRek
            // 
            this.lblRek.AutoSize = true;
            this.lblRek.Location = new System.Drawing.Point(12, 130);
            this.lblRek.Name = "lblRek";
            this.lblRek.Size = new System.Drawing.Size(87, 13);
            this.lblRek.TabIndex = 1;
            this.lblRek.Text = "Nomor Rekening";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 156);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(89, 13);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Pelanggan";
            // 
            // lblGolongan
            // 
            this.lblGolongan.AutoSize = true;
            this.lblGolongan.Location = new System.Drawing.Point(12, 182);
            this.lblGolongan.Name = "lblGolongan";
            this.lblGolongan.Size = new System.Drawing.Size(53, 13);
            this.lblGolongan.TabIndex = 3;
            this.lblGolongan.Text = "Golongan";
            // 
            // lblBeban
            // 
            this.lblBeban.AutoSize = true;
            this.lblBeban.Location = new System.Drawing.Point(12, 208);
            this.lblBeban.Name = "lblBeban";
            this.lblBeban.Size = new System.Drawing.Size(67, 13);
            this.lblBeban.TabIndex = 4;
            this.lblBeban.Text = "Biaya Beban";
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Location = new System.Drawing.Point(309, 234);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(44, 13);
            this.lblKembali.TabIndex = 5;
            this.lblKembali.Text = "Kembali";
            // 
            // lblTglBayar
            // 
            this.lblTglBayar.AutoSize = true;
            this.lblTglBayar.Location = new System.Drawing.Point(12, 289);
            this.lblTglBayar.Name = "lblTglBayar";
            this.lblTglBayar.Size = new System.Drawing.Size(108, 13);
            this.lblTglBayar.TabIndex = 6;
            this.lblTglBayar.Text = "Tanggal Pembayaran";
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = true;
            this.lblBayar.Location = new System.Drawing.Point(309, 182);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(61, 13);
            this.lblBayar.TabIndex = 7;
            this.lblBayar.Text = "Total Bayar";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(12, 234);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(68, 13);
            this.lblHarga.TabIndex = 8;
            this.lblHarga.Text = "Harga per m³";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(309, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // lblDenda
            // 
            this.lblDenda.AutoSize = true;
            this.lblDenda.Location = new System.Drawing.Point(309, 156);
            this.lblDenda.Name = "lblDenda";
            this.lblDenda.Size = new System.Drawing.Size(39, 13);
            this.lblDenda.TabIndex = 10;
            this.lblDenda.Text = "Denda";
            // 
            // lblAir
            // 
            this.lblAir.AutoSize = true;
            this.lblAir.Location = new System.Drawing.Point(12, 259);
            this.lblAir.Name = "lblAir";
            this.lblAir.Size = new System.Drawing.Size(75, 13);
            this.lblAir.TabIndex = 11;
            this.lblAir.Text = "Pemakaian Air";
            // 
            // lblDibayar
            // 
            this.lblDibayar.AutoSize = true;
            this.lblDibayar.Location = new System.Drawing.Point(309, 208);
            this.lblDibayar.Name = "lblDibayar";
            this.lblDibayar.Size = new System.Drawing.Size(43, 13);
            this.lblDibayar.TabIndex = 12;
            this.lblDibayar.Text = "Dibayar";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(126, 153);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 1;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // txtGolongan
            // 
            this.txtGolongan.Location = new System.Drawing.Point(126, 179);
            this.txtGolongan.Name = "txtGolongan";
            this.txtGolongan.Size = new System.Drawing.Size(100, 20);
            this.txtGolongan.TabIndex = 14;
            // 
            // numAir
            // 
            this.numAir.Location = new System.Drawing.Point(126, 257);
            this.numAir.Name = "numAir";
            this.numAir.Size = new System.Drawing.Size(36, 20);
            this.numAir.TabIndex = 3;
            this.numAir.ValueChanged += new System.EventHandler(this.numAir_ValueChanged);
            // 
            // txtBeban
            // 
            this.txtBeban.Enabled = false;
            this.txtBeban.Location = new System.Drawing.Point(126, 205);
            this.txtBeban.Name = "txtBeban";
            this.txtBeban.Size = new System.Drawing.Size(62, 20);
            this.txtBeban.TabIndex = 16;
            this.txtBeban.TextChanged += new System.EventHandler(this.txtBeban_TextChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(126, 231);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(62, 20);
            this.txtHarga.TabIndex = 2;
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.Enabled = false;
            this.txtTotalBayar.Location = new System.Drawing.Point(382, 179);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBayar.TabIndex = 19;
            // 
            // txtNoRek
            // 
            this.txtNoRek.Location = new System.Drawing.Point(126, 127);
            this.txtNoRek.Name = "txtNoRek";
            this.txtNoRek.Size = new System.Drawing.Size(100, 20);
            this.txtNoRek.TabIndex = 0;
            this.txtNoRek.TextChanged += new System.EventHandler(this.txtNoRek_TextChanged);
            this.txtNoRek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoRek_KeyPress);
            // 
            // txtDenda
            // 
            this.txtDenda.Enabled = false;
            this.txtDenda.Location = new System.Drawing.Point(382, 153);
            this.txtDenda.Name = "txtDenda";
            this.txtDenda.Size = new System.Drawing.Size(100, 20);
            this.txtDenda.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(382, 127);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "m³";
            // 
            // dtBayar
            // 
            this.dtBayar.Location = new System.Drawing.Point(126, 283);
            this.dtBayar.Name = "dtBayar";
            this.dtBayar.Size = new System.Drawing.Size(160, 20);
            this.dtBayar.TabIndex = 4;
            this.dtBayar.Value = new System.DateTime(2020, 3, 15, 19, 21, 8, 0);
            this.dtBayar.ValueChanged += new System.EventHandler(this.dtBayar_ValueChanged);
            // 
            // txtKembali
            // 
            this.txtKembali.Enabled = false;
            this.txtKembali.Location = new System.Drawing.Point(382, 231);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(100, 20);
            this.txtKembali.TabIndex = 25;
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(382, 205);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(100, 20);
            this.txtBayar.TabIndex = 5;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBayar_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(312, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 46);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "&CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Aplikasi Pembayaran Rekening Air";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(154, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "\"Kireinamizu\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 313);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.dtBayar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDenda);
            this.Controls.Add(this.txtNoRek);
            this.Controls.Add(this.txtTotalBayar);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtBeban);
            this.Controls.Add(this.numAir);
            this.Controls.Add(this.txtGolongan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblDibayar);
            this.Controls.Add(this.lblAir);
            this.Controls.Add(this.lblDenda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblBayar);
            this.Controls.Add(this.lblTglBayar);
            this.Controls.Add(this.lblKembali);
            this.Controls.Add(this.lblBeban);
            this.Controls.Add(this.lblGolongan);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblRek);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Menu Pembayaran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRek;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblGolongan;
        private System.Windows.Forms.Label lblBeban;
        private System.Windows.Forms.Label lblKembali;
        private System.Windows.Forms.Label lblTglBayar;
        private System.Windows.Forms.Label lblBayar;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDenda;
        private System.Windows.Forms.Label lblAir;
        private System.Windows.Forms.Label lblDibayar;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtGolongan;
        private System.Windows.Forms.NumericUpDown numAir;
        private System.Windows.Forms.TextBox txtBeban;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.TextBox txtNoRek;
        private System.Windows.Forms.TextBox txtDenda;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBayar;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

