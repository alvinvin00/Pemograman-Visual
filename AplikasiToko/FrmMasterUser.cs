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
    public partial class FrmMasterUser : Form
    {
        private Connection koneksi = new Connection();

        public FrmMasterUser()
        {
            InitializeComponent();
        }

        private void FrmMasterUser_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void bersih()
        {
            txtUserId.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            rbActive.Checked = true;
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Staff");
            cbRole.SelectedIndex = 0;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (koneksi.openConnection())
            {
                String query =
                    string.Format(
                        "INSERT INTO users(user_id, user_name, password, status, role) VALUES('{0}','{1}',sha1('{2}'),'{3}','{4}')",
                        txtUserId.Text,txtUserName.Text, txtPassword.Text, rbActive.Checked ? '1' : '0',
                        cbRole.Text.Equals("Admin") ? "1" : "2");
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.cmd.ExecuteNonQuery();
                koneksi.closeConnection();

                MessageBox.Show("Success");
                bersih();
            }
        }
    }
}