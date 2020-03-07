using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmDeepyReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            txtNpm.Clear();
            txtNpm.MaxLength = 10;

            txtNama.Clear();
            txtTempatLahir.Clear();
            cbAgama.Items.Add("Islam");
            cbAgama.Items.Add("Kristen");
            cbAgama.Items.Add("Katolik");
            cbAgama.Items.Add("Buddha");
            cbAgama.Items.Add("Hindu");
            cbAgama.Items.Add("Khonghucu");
            cbAgama.SelectedIndex = 0;
            dtTanggalLahir.Format = DateTimePickerFormat.Long;
            dtTanggalLahir.Value = DateTime.Now;
            rbLaki.Checked = true;
        }


        private void txtNpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char) Keys.Enter)
            {
                txtNama.Focus();
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                rbLaki.Focus();
            }
        }

        private void txtTempatLahir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                dtTanggalLahir.Focus();
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            String nama = txtNama.Text;
            String npm = txtNpm.Text;
            String tempatLahir = txtTempatLahir.Text;
            String tanggalLahir = dtTanggalLahir.Text;
            String jenisKelamin = rbLaki.Checked ? rbLaki.Text : rbPerempuan.Text;
            String agama = cbAgama.Text;

            if (nama.Trim() == "" || npm.Trim() == "" || tempatLahir.Trim() == "" || tanggalLahir.Trim() == "" ||
                jenisKelamin.Trim() == "" || agama.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblHasilNama.Text = nama;
                lblHasilNpm.Text = npm;
                lblHasilAgama.Text = agama;
                lblHasilJK.Text = jenisKelamin;
                lblHasilTempatLahir.Text = tempatLahir;
                lblHasilTanggalLahir.Text = tanggalLahir;

                MessageBox.Show("Registrasi Berhasil", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}