using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPemesanan
{
    public partial class FormMenuUtama : Form
    {
        long _harga;

        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void bersih()
        {
            cbMenu.Items.Clear();
            cbMenu.Items.Add("Mie Goreng");
            cbMenu.Items.Add("Nasi Ayam Bakar");
            cbMenu.Items.Add("Nasi Goreng Sosis");
            cbMenu.Items.Add("Bakso Spesial");
            cbMenu.Items.Add("Bakpau");
            cbMenu.Items.Add("Es Teh Manis");
            cbMenu.Items.Add("Es Jeruk");
            cbMenu.Items.Add("Es Campur");
            cbMenu.Items.Add("Kopi Susu");
            cbMenu.SelectedIndex = 0;

            txtHarga.Enabled = false;

            numericJumlah.Minimum = 1;
            numericJumlah.Value = 1;
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            bersih();
            clearListView();
        }

        private void clearListView()
        {
            lvPesanan.Clear();
            lvPesanan.Columns.Add("No", 30, HorizontalAlignment.Right);
            lvPesanan.Columns.Add("Nama", 250, HorizontalAlignment.Left);
            lvPesanan.Columns.Add("Jumlah", 80, HorizontalAlignment.Left);
            lvPesanan.Columns.Add("Harga", 80, HorizontalAlignment.Left);
            lvPesanan.Columns.Add("Subtotal", 80, HorizontalAlignment.Left);
            lvPesanan.View = View.Details;
            lvPesanan.GridLines = true;
            lvPesanan.FullRowSelect = true;
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMenu.Text)
            {
                case "Mie Goreng":
                    _harga = 5000;
                    break;
                case "Nasi Ayam Bakar":
                    _harga = 15000;
                    break;
                case "Nasi Goreng Sosis":
                    _harga = 14000;
                    break;
                case "Bakso Spesial":
                    _harga = 19000;
                    break;
                case "Bakpau":
                    _harga = 9000;
                    break;
                case "Es Teh Manis":
                    _harga = 3000;
                    break;
                case "Es Jeruk":
                    _harga = 6000;
                    break;
                case "Es Campur":
                    _harga = 9000;
                    break;
                case "Kopi Susu":
                    _harga = 5000;
                    break;
            }

            txtHarga.Text = _harga.ToString("#,##0");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (lvPesanan.Items.Count == 0)
            {
                createItem();
            }
            else
            {
                foreach (ListViewItem item in lvPesanan.Items)
                {
                    if (cbMenu.SelectedItem.Equals(item.SubItems[1].Text))
                    {
                        updateItem(item);
                    }
                    else
                    {
                        createItem();
                    }
                }
            }

            long total = 0;
            long items = 0;

            foreach (ListViewItem item in lvPesanan.Items)
            {
                total += Convert.ToInt64(item.SubItems[4].Text.Replace(".", ""));
                items += Convert.ToInt64(item.SubItems[2].Text);
            }

            lblTotalItem.Text = items.ToString();
            lblTotalBayar.Text = total.ToString("#,##0");
        }

        private void updateItem(ListViewItem item)
        {
            item.SubItems[2].Text =
                (Convert.ToInt64(item.SubItems[2].Text) +
                 Convert.ToInt64(numericJumlah.Value))
                .ToString();
            item.SubItems[4].Text =
                (Convert.ToInt64(item.SubItems[2].Text) *
                 Convert.ToInt64(item.SubItems[3].Text.Replace(".", ""))).ToString("#,##0");
        }

        private void createItem()
        {
            ListViewItem newItem = new ListViewItem((lvPesanan.Items.Count + 1).ToString());
            newItem.SubItems.Add(cbMenu.SelectedItem.ToString());
            newItem.SubItems.Add(numericJumlah.Value.ToString());
            newItem.SubItems.Add(txtHarga.Text);

            long subTotal = Convert.ToInt64(txtHarga.Text.Replace(".", "")) *
                            Convert.ToInt64(numericJumlah.Value.ToString());
            newItem.SubItems.Add(subTotal.ToString("#,##0"));

            lvPesanan.Items.Add(newItem);
        }

        private void lvPesanan_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}