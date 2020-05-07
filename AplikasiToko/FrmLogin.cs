using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplikasiToko
{
    public partial class FrmLogin : Form
    {
        private Connection koneksi = new Connection();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Silahkan masukkan User ID dan Password anda!", "Perhatian", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            if (koneksi.openConnection())
            {
                string query = String.Format("SELECT * from users WHERE user_id = '{0}' AND password = sha1('{1}')",
                    txtUserId.Text, txtPassword.Text);

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();


                if (koneksi.dr.Read())
                {
                    this.Hide();
                    FrmMenuUtama frmMenuUtama = new FrmMenuUtama();
                    frmMenuUtama.Show();
                }
                else
                {
                    MessageBox.Show("Login Gagal!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                koneksi.dr.Close();
                koneksi.closeConnection();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}