using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mr_Wong
{
    public partial class Form1 : Form
    {
        String biasa = "Biasa";
        String paket = "Paket";

        private long _harga = 0;
        private long _total = 0;

        private static readonly List<string> _listPempekBiasa = new List<String>
        {
            "Pempek Lenjer Kecil", "Pempek Telur Kecil", "Pempek Adaan", "Pempek Kulit", "Pempek Keriting",
            "Pempek Pistel", "Pempek Kapal Selam", "Pempek Lenjer Besar"
        };

        private static readonly List<string> _listPempekPaket = new List<string>
        {
            "Paket Pempek Kecil 100", "Paket Pempek Kecil 150", "Paket Pempek Kecil 200", "Paket Pempek Kecil 250",
            "Paket Pempek Kecil 300", "Paket Pempek Kecil 350", "Paket Pempek Kecil 400",
            "Paket Pempek Kecil 500", "Paket Pempek Besar 100", "Paket Pempek Besar 150", "Paket Pempek Besar 200",
            "Paket Pempek Besar 250", "Paket Pempek Besar 300",
            "Paket Pempek Besar 350", "Paket Pempek Besar 400", "Paket Pempek Besar 500"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void bersih()
        {
            cbJenis.Items.Add(biasa);
            cbJenis.Items.Add(paket);
            cbJenis.SelectedIndex = 0;

            txtDeskripsi.Clear();

            txtHarga.Clear();

            lblBayar.Text = "0";
            lblItem.Text = "0";

            numJumlah.Minimum = 1;
        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPilihan.Items.Clear();

            switch (cbJenis.Text)
            {
                case "Biasa":
                    _listPempekBiasa.ForEach((item) => cbPilihan.Items.Add(item));
                    break;
                case "Paket":
                    _listPempekPaket.ForEach((item) => cbPilihan.Items.Add(item));
                    break;
            }

            cbPilihan.SelectedIndex = 0;
        }

        private void cbPilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPilihan.Text)
            {
                case "Pempek Lenjer Kecil":
                    _harga = 4000;
                    txtDeskripsi.Text = "Pempek Lenjer Kecil";
                    break;
                case "Pempek Telur Kecil":
                    _harga = 4000;
                    txtDeskripsi.Text = "Pempek Telur Kecil";
                    break;
                case "Pempek Adaan":
                    _harga = 4000;
                    txtDeskripsi.Text = "Pempek Adaan";
                    break;
                case "Pempek Kulit":
                    _harga = 4000;
                    txtDeskripsi.Text = "Pempek Kulit";
                    break;
                case "Pempek Keriting":
                    _harga = 4000;
                    txtDeskripsi.Text = "Pempek Keriting";
                    break;
                case "Pempek Pistel":
                    _harga = 4000;
                    txtDeskripsi.Text = "Pempek Pistel";
                    break;
                case "Pempek Kapal Selam":
                    _harga = 17500;
                    txtDeskripsi.Text = "Pempek Kapal Selam";
                    break;
                case "Pempek Lenjer Besar":
                    _harga = 40000;
                    txtDeskripsi.Text = "Pempek Lenjer Besar";
                    break;
                case "Paket Pempek Kecil 100":
                    _harga = 100000;
                    txtDeskripsi.Text = "5 Telor Kecil\r\n10 Adaan\r\n10 Lenjer Potong\r\nCuko Pempek\r\nBerat 1 kg";
                    break;
                case "Paket Pempek Kecil 150":
                    _harga = 150000;
                    txtDeskripsi.Text = "10 Telor Kecil\r\n10 Adaan\r\n17 Lenjer Potong\r\nCuko Pempek\r\nBerat 2 kg";
                    break;
                case "Paket Pempek Kecil 200":
                    _harga = 200000;
                    txtDeskripsi.Text = "15 Telor Kecil\r\n15 Adaan\r\n20 Lenjer Potong\r\nCuko Pempek\r\nBerat 3 kg";
                    break;
                case "Paket Pempek Kecil 250":
                    _harga = 250000;
                    txtDeskripsi.Text = "20 Telor Kecil\r\n20 Adaan\r\n22 Lenjer Potong\r\nCuko Pempek\r\nBerat 3 kg";
                    break;
                case "Paket Pempek Kecil 300":
                    _harga = 300000;
                    txtDeskripsi.Text = "25 Telor Kecil\r\n25 Adaan\r\n25 Lenjer Potong\r\nCuko Pempek\r\nBerat 4 kg";
                    break;
                case "Paket Pempek Kecil 350":
                    _harga = 350000;
                    txtDeskripsi.Text = "29 Telor Kecil\r\n29 Adaan\r\n29 Lenjer Potong\r\nCuko Pempek\r\nBerat 4 kg";
                    break;
                case "Paket Pempek Kecil 400":
                    _harga = 400000;
                    txtDeskripsi.Text = "35 Telor Kecil\r\n30 Adaan\r\n35 Lenjer Potong\r\nCuko Pempek\r\nBerat 5 kg";
                    break;
                case "Paket Pempek Kecil 500":
                    _harga = 500000;
                    txtDeskripsi.Text = "40 Telor Kecil\r\n40 Adaan\r\n45 Lenjer Potong\r\nCuko Pempek\r\nBerat 6 kg";
                    break;
                case "Paket Pempek Besar 100":
                    _harga = 100000;
                    txtDeskripsi.Text =
                        "1 Lenjer Besar\r\n2 Telor Besar/Kapal Selam\r\n3 Telor Kecil\r\n3 Adaan\r\nCuko Pempek\r\nBerat 1 kg";
                    break;
                case "Paket Pempek Besar 150":
                    _harga = 150000;
                    txtDeskripsi.Text =
                        "1 Lenjer Besar\r\n3 Telor Besar/Kapal Selam\r\n7 Telor Kecil\r\n7 Adaan\r\nCuko Pempek\r\nBerat 2 kg";
                    break;
                case "Paket Pempek Besar 200":
                    _harga = 200000;
                    txtDeskripsi.Text =
                        "2 Lenjer Besar\r\n4 Telor Besar/Kapal Selam\r\n6 Telor Kecil\r\n6 Adaan\r\nCuko Pempek\r\nBerat 3 kg";
                    break;
                case "Paket Pempek Besar 250":
                    _harga = 250000;
                    txtDeskripsi.Text =
                        "3 Lenjer Besar\r\n4 Telor Besar/Kapal Selam\r\n6 Telor Kecil\r\n6 Adaan\r\nCuko Pempek\r\nBerat 3 kg";
                    break;
                case "Paket Pempek Besar 300":
                    _harga = 300000;
                    txtDeskripsi.Text =
                        "3 Lenjer Besar\r\n4 Telor Besar/Kapal Selam\r\n8 Telor Kecil\r\n6 Adaan\r\nCuko Pempek\r\nBerat 4 kg";
                    break;
                case "Paket Pempek Besar 350":
                    _harga = 350000;
                    txtDeskripsi.Text =
                        "4 Lenjer Besar\r\n6 Telor Besar/Kapal Selam\r\n11 Telor Kecil\r\n10 Adaan\r\nCuko Pempek\r\nBerat 4 kg";
                    break;
                case "Paket Pempek Besar 400":
                    _harga = 400000;
                    txtDeskripsi.Text =
                        "5 Lenjer Besar\r\n5 Telor Besar/Kapal Selam\r\n14 Telor Kecil\r\n14 Adaan\r\nCuko Pempek\r\nBerat 5 kg";
                    break;
                case "Paket Pempek Besar 500":
                    _harga = 500000;
                    txtDeskripsi.Text =
                        "6 Lenjer Besar\r\n8 Telor Besar/Kapal Selam\r\n15 Telor Kecil\r\n15 Adaan\r\nCuko Pempek\r\nBerat 6 kg";
                    break;
                default:
                    throw new Exception("Menu tidak diketahui");
            }

            txtHarga.Text = _harga.ToString();
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            _total = (long) (_harga * numJumlah.Value);
            txtHarga.Text = _total.ToString();
        }

        private void numJumlah_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bool isFounded = false;
            int position = -1;

            for (int i = 0; i < dgvPesanan.Rows.Count; i++)
            {
                if (cbPilihan.Text.Trim().Equals(dgvPesanan.Rows[i].Cells[1].Value.ToString()))
                {
                    isFounded = true;
                    position = i;
                    break;
                }
            }

            if (isFounded)
            {
                DialogResult result = MessageBox.Show("Item menu ini sudah ada, apakah anda ingin mengubahnya?"
                    , "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    editItem(position);
                }
            }
            else
            {
                AddItem();
            }

            CalculateTotals();
        }

        private void CalculateTotals()
        {
            long _totalBayar = 0;
            long _totalItem = 0;

            foreach (DataGridViewRow row in dgvPesanan.Rows)
            {
                _totalItem += Convert.ToInt64(row.Cells[3].Value.ToString());
                _totalBayar += Convert.ToInt64(row.Cells[5].Value.ToString());
            }

            lblBayar.Text = _totalBayar.ToString();
            lblItem.Text = _totalItem.ToString();
        }

        private void editItem(int position)
        {
            dgvPesanan.Rows[position].Cells[3].Value = numJumlah.Value.ToString();
            dgvPesanan.Rows[position].Cells[5].Value = _total.ToString();
        }

        private void AddItem()
        {
            int pos = dgvPesanan.Rows.Count;

            dgvPesanan.Rows.Add();
            dgvPesanan.Rows[pos].Cells[0].Value = pos + 1;
            dgvPesanan.Rows[pos].Cells[1].Value = cbPilihan.Text;
            dgvPesanan.Rows[pos].Cells[2].Value = cbJenis.Text;
            dgvPesanan.Rows[pos].Cells[3].Value = numJumlah.Value.ToString();
            dgvPesanan.Rows[pos].Cells[4].Value = _harga.ToString();
            dgvPesanan.Rows[pos].Cells[5].Value = _total.ToString();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            dgvPesanan.Rows.Clear();
            txtHarga.Clear();
            lblBayar.Text = "0";
            lblItem.Text = "0";
        }
    }
}