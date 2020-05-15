using System;
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
            // if (koneksi.openConnection())
            // {
            //     this.Text = "Koneksi Database Sukses!";
            // }
        }

        private void masterUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMasterUser frmMasterUser = new FrmMasterUser {MdiParent = this};
            frmMasterUser.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void FrmMenuUtama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void laporanUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLaporanUser frmLaporanUser=new FrmLaporanUser();
            frmLaporanUser.MdiParent = this;
            frmLaporanUser.Show();
        }
    }
}