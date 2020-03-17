using System;
using System.Globalization;
using System.Windows.Forms;

namespace Kireinamizu
{
    public partial class Form1 : Form
    {
        private long denda;
        private long beban;
        private long bayar;
        private long total;
        private long harga;
        private long kembali;
        private long totalBayar;
        private long jumlahAir;

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


            txtBeban.Text = 0.ToString("C");
            txtBeban.Enabled = false;

            txtDenda.Text = 0.ToString("C");

            txtGolongan.Clear();
            txtGolongan.Enabled = false;

            txtHarga.Text = 0.ToString("C");

            dtBayar.Value = DateTime.Now;

            numAir.Value = 0;
            numAir.Minimum = 0;

            txtKembali.Text = 0.ToString("C");

            txtTotal.Text = 0.ToString("C");

            txtTotalBayar.Text = 0.ToString("C");

            txtBayar.Clear();

            denda = 0;
            beban = 0;
            bayar = 0;
            total = 0;
            harga = 0;
            kembali = 0;
            totalBayar = 0;
            jumlahAir = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void txtNoRek_TextChanged(object sender, EventArgs e)
        {
            String noRek = txtNoRek.Text;

            if (noRek.Length >= 3)
            {
                switch (noRek.Substring(0, 3))
                {
                    case "PAB":
                        txtGolongan.Text = "Pelanggan Pabrik";
                        beban = 48000;
                        harga = 1725;
                        break;
                    case "SUP":
                        txtGolongan.Text = "Pelanggan Supermarket";
                        beban = 32500;
                        harga = 1250;
                        break;
                    case "TOK":
                        txtGolongan.Text = "Pelanggan Toko";
                        beban = 27000;
                        harga = 800;
                        break;
                    case "BIA":
                        txtGolongan.Text = "Pelanggan Biasa";
                        beban = 22500;
                        harga = 575;
                        break;
                    default:
                        txtGolongan.Text = "Tidak Terdefinisi";
                        beban = 0;
                        harga = 0;
                        break;
                }

                txtBeban.Text = beban.ToString("C");
                txtHarga.Text = harga.ToString("C");
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
            if (dtBayar.Value.Day > 15)
            {
                denda = (long) (0.1 * total);
            }

            totalBayar = (total + denda);

            txtDenda.Text = denda.ToString("C");
            txtTotalBayar.Text = totalBayar.ToString("C");
        }

        private void numAir_ValueChanged(object sender, EventArgs e)
        {
            jumlahAir = (long) numAir.Value;

            total = harga * jumlahAir + beban;
            txtTotal.Text = total.ToString("C");
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char) Keys.Enter)
            {
                if (long.TryParse(txtBayar.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out bayar))
                {
                    if (bayar > totalBayar)
                    {
                        kembali = bayar - totalBayar;
                        txtKembali.Text = kembali.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Uang Kurang", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Input invalid", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
        }
    }
}