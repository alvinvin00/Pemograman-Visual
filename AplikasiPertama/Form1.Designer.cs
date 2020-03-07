namespace AplikasiPertama
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
            this.lblNPM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblJK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGoldar = new System.Windows.Forms.Label();
            this.lblNoTel = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.panelJK = new System.Windows.Forms.Panel();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.rbKawin = new System.Windows.Forms.RadioButton();
            this.rbBelumKawin = new System.Windows.Forms.RadioButton();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cbGoldar = new System.Windows.Forms.ComboBox();
            this.txtNoTel = new System.Windows.Forms.TextBox();
            this.gbPendaftaran = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.gbHasilPendaftaran = new System.Windows.Forms.GroupBox();
            this.lblHasilNPM = new System.Windows.Forms.Label();
            this.lblHasilNama = new System.Windows.Forms.Label();
            this.lblHasilStatus = new System.Windows.Forms.Label();
            this.lblHasilJK = new System.Windows.Forms.Label();
            this.lblHasilNoTel = new System.Windows.Forms.Label();
            this.lblHasilAlamat = new System.Windows.Forms.Label();
            this.lblHasilGolDar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Aksi = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelJK.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.gbPendaftaran.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbHasilPendaftaran.SuspendLayout();
            this.Aksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNPM
            // 
            this.lblNPM.Location = new System.Drawing.Point(10, 24);
            this.lblNPM.Name = "lblNPM";
            this.lblNPM.Size = new System.Drawing.Size(86, 11);
            this.lblNPM.TabIndex = 0;
            this.lblNPM.Text = "NPM";
            // 
            // lblNama
            // 
            this.lblNama.Location = new System.Drawing.Point(10, 54);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(86, 11);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(110, 22);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(224, 20);
            this.txtNPM.TabIndex = 0;
            this.txtNPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPM_KeyPress);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(110, 51);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(224, 20);
            this.txtNama.TabIndex = 1;
            // 
            // lblJK
            // 
            this.lblJK.Location = new System.Drawing.Point(10, 94);
            this.lblJK.Name = "lblJK";
            this.lblJK.Size = new System.Drawing.Size(86, 11);
            this.lblJK.TabIndex = 4;
            this.lblJK.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 11);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alamat";
            // 
            // lblGoldar
            // 
            this.lblGoldar.Location = new System.Drawing.Point(10, 216);
            this.lblGoldar.Name = "lblGoldar";
            this.lblGoldar.Size = new System.Drawing.Size(86, 16);
            this.lblGoldar.TabIndex = 6;
            this.lblGoldar.Text = "Golongan Darah";
            // 
            // lblNoTel
            // 
            this.lblNoTel.Location = new System.Drawing.Point(10, 253);
            this.lblNoTel.Name = "lblNoTel";
            this.lblNoTel.Size = new System.Drawing.Size(86, 15);
            this.lblNoTel.TabIndex = 7;
            this.lblNoTel.Text = "Nomor Telepon";
            // 
            // lblS
            // 
            this.lblS.Location = new System.Drawing.Point(10, 300);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(86, 14);
            this.lblS.TabIndex = 8;
            this.lblS.Text = "Status";
            // 
            // panelJK
            // 
            this.panelJK.Controls.Add(this.rbPerempuan);
            this.panelJK.Controls.Add(this.rbLaki);
            this.panelJK.Location = new System.Drawing.Point(110, 82);
            this.panelJK.Name = "panelJK";
            this.panelJK.Size = new System.Drawing.Size(224, 35);
            this.panelJK.TabIndex = 2;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.Location = new System.Drawing.Point(105, 10);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(92, 16);
            this.rbPerempuan.TabIndex = 1;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLaki
            // 
            this.rbLaki.Location = new System.Drawing.Point(14, 11);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(68, 16);
            this.rbLaki.TabIndex = 0;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.rbKawin);
            this.panelStatus.Controls.Add(this.rbBelumKawin);
            this.panelStatus.Location = new System.Drawing.Point(110, 288);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(225, 38);
            this.panelStatus.TabIndex = 6;
            // 
            // rbKawin
            // 
            this.rbKawin.Location = new System.Drawing.Point(107, 10);
            this.rbKawin.Name = "rbKawin";
            this.rbKawin.Size = new System.Drawing.Size(63, 16);
            this.rbKawin.TabIndex = 1;
            this.rbKawin.TabStop = true;
            this.rbKawin.Text = "Kawin";
            this.rbKawin.UseVisualStyleBackColor = true;
            // 
            // rbBelumKawin
            // 
            this.rbBelumKawin.Location = new System.Drawing.Point(14, 10);
            this.rbBelumKawin.Name = "rbBelumKawin";
            this.rbBelumKawin.Size = new System.Drawing.Size(87, 16);
            this.rbBelumKawin.TabIndex = 0;
            this.rbBelumKawin.TabStop = true;
            this.rbBelumKawin.Text = "Belum Kawin";
            this.rbBelumKawin.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(110, 130);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(224, 70);
            this.txtAlamat.TabIndex = 3;
            // 
            // cbGoldar
            // 
            this.cbGoldar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoldar.FormattingEnabled = true;
            this.cbGoldar.Location = new System.Drawing.Point(110, 213);
            this.cbGoldar.Name = "cbGoldar";
            this.cbGoldar.Size = new System.Drawing.Size(224, 21);
            this.cbGoldar.TabIndex = 4;
            // 
            // txtNoTel
            // 
            this.txtNoTel.Location = new System.Drawing.Point(110, 250);
            this.txtNoTel.Name = "txtNoTel";
            this.txtNoTel.Size = new System.Drawing.Size(224, 20);
            this.txtNoTel.TabIndex = 5;
            // 
            // gbPendaftaran
            // 
            this.gbPendaftaran.Controls.Add(this.txtNoTel);
            this.gbPendaftaran.Controls.Add(this.cbGoldar);
            this.gbPendaftaran.Controls.Add(this.txtAlamat);
            this.gbPendaftaran.Controls.Add(this.panelStatus);
            this.gbPendaftaran.Controls.Add(this.panelJK);
            this.gbPendaftaran.Controls.Add(this.lblS);
            this.gbPendaftaran.Controls.Add(this.lblNoTel);
            this.gbPendaftaran.Controls.Add(this.lblGoldar);
            this.gbPendaftaran.Controls.Add(this.label2);
            this.gbPendaftaran.Controls.Add(this.lblJK);
            this.gbPendaftaran.Controls.Add(this.txtNama);
            this.gbPendaftaran.Controls.Add(this.txtNPM);
            this.gbPendaftaran.Controls.Add(this.lblNama);
            this.gbPendaftaran.Controls.Add(this.lblNPM);
            this.gbPendaftaran.Location = new System.Drawing.Point(10, 90);
            this.gbPendaftaran.Name = "gbPendaftaran";
            this.gbPendaftaran.Size = new System.Drawing.Size(361, 379);
            this.gbPendaftaran.TabIndex = 14;
            this.gbPendaftaran.TabStop = false;
            this.gbPendaftaran.Text = "Pendaftaran";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 64);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "PENDAFTARAN MAHASISWA BARU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(5, 19);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(170, 22);
            this.btnDaftar.TabIndex = 0;
            this.btnDaftar.Text = "&DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // gbHasilPendaftaran
            // 
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilNPM);
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilNama);
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilStatus);
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilJK);
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilNoTel);
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilAlamat);
            this.gbHasilPendaftaran.Controls.Add(this.lblHasilGolDar);
            this.gbHasilPendaftaran.Controls.Add(this.label3);
            this.gbHasilPendaftaran.Controls.Add(this.label4);
            this.gbHasilPendaftaran.Controls.Add(this.label9);
            this.gbHasilPendaftaran.Controls.Add(this.label5);
            this.gbHasilPendaftaran.Controls.Add(this.label8);
            this.gbHasilPendaftaran.Controls.Add(this.label6);
            this.gbHasilPendaftaran.Controls.Add(this.label7);
            this.gbHasilPendaftaran.Location = new System.Drawing.Point(377, 91);
            this.gbHasilPendaftaran.Name = "gbHasilPendaftaran";
            this.gbHasilPendaftaran.Size = new System.Drawing.Size(314, 378);
            this.gbHasilPendaftaran.TabIndex = 17;
            this.gbHasilPendaftaran.TabStop = false;
            this.gbHasilPendaftaran.Text = "Hasil Pendaftaran";
            // 
            // lblHasilNPM
            // 
            this.lblHasilNPM.Location = new System.Drawing.Point(132, 24);
            this.lblHasilNPM.Name = "lblHasilNPM";
            this.lblHasilNPM.Size = new System.Drawing.Size(86, 11);
            this.lblHasilNPM.TabIndex = 9;
            // 
            // lblHasilNama
            // 
            this.lblHasilNama.Location = new System.Drawing.Point(132, 54);
            this.lblHasilNama.Name = "lblHasilNama";
            this.lblHasilNama.Size = new System.Drawing.Size(86, 11);
            this.lblHasilNama.TabIndex = 10;
            // 
            // lblHasilStatus
            // 
            this.lblHasilStatus.Location = new System.Drawing.Point(132, 300);
            this.lblHasilStatus.Name = "lblHasilStatus";
            this.lblHasilStatus.Size = new System.Drawing.Size(86, 14);
            this.lblHasilStatus.TabIndex = 15;
            // 
            // lblHasilJK
            // 
            this.lblHasilJK.Location = new System.Drawing.Point(132, 94);
            this.lblHasilJK.Name = "lblHasilJK";
            this.lblHasilJK.Size = new System.Drawing.Size(86, 11);
            this.lblHasilJK.TabIndex = 11;
            // 
            // lblHasilNoTel
            // 
            this.lblHasilNoTel.Location = new System.Drawing.Point(132, 253);
            this.lblHasilNoTel.Name = "lblHasilNoTel";
            this.lblHasilNoTel.Size = new System.Drawing.Size(86, 15);
            this.lblHasilNoTel.TabIndex = 14;
            // 
            // lblHasilAlamat
            // 
            this.lblHasilAlamat.Location = new System.Drawing.Point(132, 133);
            this.lblHasilAlamat.Name = "lblHasilAlamat";
            this.lblHasilAlamat.Size = new System.Drawing.Size(86, 11);
            this.lblHasilAlamat.TabIndex = 12;
            // 
            // lblHasilGolDar
            // 
            this.lblHasilGolDar.Location = new System.Drawing.Point(132, 216);
            this.lblHasilGolDar.Name = "lblHasilGolDar";
            this.lblHasilGolDar.Size = new System.Drawing.Size(86, 16);
            this.lblHasilGolDar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 11);
            this.label3.TabIndex = 0;
            this.label3.Text = "NPM";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 11);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 11);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nomor Telepon";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 11);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Golongan Darah";
            // 
            // Aksi
            // 
            this.Aksi.Controls.Add(this.btnBatal);
            this.Aksi.Controls.Add(this.btnDaftar);
            this.Aksi.Location = new System.Drawing.Point(10, 474);
            this.Aksi.Name = "Aksi";
            this.Aksi.Size = new System.Drawing.Size(681, 55);
            this.Aksi.TabIndex = 7;
            this.Aksi.TabStop = false;
            this.Aksi.Text = "Aksi";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(190, 19);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(170, 22);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "&BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 539);
            this.Controls.Add(this.Aksi);
            this.Controls.Add(this.gbHasilPendaftaran);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbPendaftaran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelJK.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.gbPendaftaran.ResumeLayout(false);
            this.gbPendaftaran.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbHasilPendaftaran.ResumeLayout(false);
            this.Aksi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.Label lblNPM;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGoldar;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.ComboBox cbGoldar;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Panel panelJK;
        private System.Windows.Forms.GroupBox gbPendaftaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBelumKawin;
        private System.Windows.Forms.RadioButton rbKawin;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.GroupBox Aksi;
        private System.Windows.Forms.GroupBox gbHasilPendaftaran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHasilGolDar;
        private System.Windows.Forms.Label lblHasilAlamat;
        private System.Windows.Forms.Label lblHasilJK;
        private System.Windows.Forms.Label lblHasilStatus;
        private System.Windows.Forms.Label lblHasilNama;
        private System.Windows.Forms.Label lblHasilNPM;
        private System.Windows.Forms.Label lblJK;
        private System.Windows.Forms.Label lblHasilNoTel;
        private System.Windows.Forms.TextBox txtNoTel;
        private System.Windows.Forms.Label lblNoTel;
        private System.Windows.Forms.Button btnBatal;
    }
}