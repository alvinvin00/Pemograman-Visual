using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiToko
{
    public partial class FrmMenuUtama : Form
    {
        private Connection koneksi = new Connection();

        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private void FrmMenuUtama_Load(object sender, EventArgs e)
        {
            if (koneksi.openConnection())
            {
                this.Text = "Koneksi Database Sukses!";
            }
        }
    }
}
