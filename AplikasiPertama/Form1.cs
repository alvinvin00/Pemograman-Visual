using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPertama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
        }


        private void btnDaftar_Click(object sender, EventArgs e)
        {
            String nama = txtNama.Text;
            String npm = txtNPM.Text;
            String jk = rbLaki.Checked ? rbLaki.Text : rbPerempuan.Text;
            String alamat = txtAlamat.Text;
            String golDar = cbGoldar.Text;
            String noTel = txtNoTel.Text;
            String status = rbBelumKawin.Checked ? rbBelumKawin.Text : rbKawin.Text;

            if (npm.Trim() == "" || nama.Trim() == "" || jk.Trim() == "" || alamat.Trim() == "" ||
                golDar.Trim() == "" || noTel.Trim() == "" || status.Trim() == "")
            {
                MessageBox.Show("Isian belum lengkap", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblHasilNama.Text = nama;
                lblHasilNPM.Text = npm;
                lblHasilJK.Text = jk;
                lblHasilAlamat.Text = alamat;
                lblHasilGolDar.Text = golDar;
                lblHasilNoTel.Text = noTel;
                lblHasilStatus.Text = status;

                MessageBox.Show("Selamat, anda telah terdatar!", "Perhatian!", MessageBoxButtons.OK);
            }
        }

        private void bersih()
        {
            txtNPM.MaxLength = 10;
            txtNama.Clear();
            txtNPM.Clear();
            rbLaki.Checked = true;
            cbGoldar.Items.Clear();
            cbGoldar.Items.Add("A");
            cbGoldar.Items.Add("B");
            cbGoldar.Items.Add("AB");
            cbGoldar.Items.Add("O");
            cbGoldar.SelectedIndex = 0;
            txtNoTel.Clear();
            rbBelumKawin.Checked = true;
        }


        private void txtNPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char) Keys.Enter)
            {
                txtNama.Focus();
            }
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}