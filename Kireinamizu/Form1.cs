using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kireinamizu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void bersih()
        {
            txtNoRek.CharacterCasing = CharacterCasing.Upper;
            txtNoRek.Clear();
            txtNoRek.MaxLength = 8;

            txtNama.Clear();
            txtBayar.Text = "0";

            txtBeban.Text = "0";
            txtBeban.Enabled = false;

            txtDenda.Text = "0";

            txtGolongan.Clear();
            txtGolongan.Enabled = false;

            txtHarga.Text = "0";

            dtBayar.Value = DateTime.Now;

            numAir.Value = 0;

            txtKembali.Text = "0";

            txtTotal.Text = "0";

            txtTotalBayar.Text = "0";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void txtNoRek_TextChanged(object sender, EventArgs e)
        {
            String noRek = txtNoRek.Text;
            Console.WriteLine($"Nama : {noRek}");

            if (noRek.Length >= 3)
            {
                switch (noRek.Substring(0, 3))
                {
                    case "PAB":
                        txtGolongan.Text = "Pelanggan Pabrik";
                        txtBeban.Text = "48000";
                        txtHarga.Text = "1725";
                        break;
                    case "SUP":
                        txtGolongan.Text = "Pelanggan Supermarket";
                        txtBeban.Text = "32500";
                        txtHarga.Text = "1250";
                        break;
                    case "TOK":
                        txtGolongan.Text = "Pelanggan Toko";
                        txtBeban.Text = "27000";
                        txtHarga.Text = "800";
                        break;
                    case "BIA":
                        txtGolongan.Text = "Pelanggan Biasa";
                        txtBeban.Text = "22500";
                        txtHarga.Text = "575";
                        break;
                    default:
                        txtGolongan.Text = "Tidak Terdefinisi";
                        txtBeban.Text = "0";
                        txtHarga.Text = "0";
                        break;
                }
            }
        }

        private void txtNoRek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtNama.Focus();
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                dtBayar.Focus();
            }
        }

        private void txtBeban_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtBayar_ValueChanged(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotal.Text);
            double denda;

            if (dtBayar.Value.Day > 15)
            {
                denda = (0.1 * total);
            }
            else
            {
                denda = 0;
            }

            double totalBayar = (total + denda);

            txtDenda.Text = denda.ToString();
            txtTotalBayar.Text = totalBayar.ToString();
        }

        private void numAir_ValueChanged(object sender, EventArgs e)
        {
            int harga = int.Parse(txtHarga.Text);
            int beban = int.Parse(txtBeban.Text);

            txtTotal.Text = (harga * numAir.Value + beban).ToString();
        }

        private void numAir_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}