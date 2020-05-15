using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

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
            setDgvStyle();
        }

        private void setDgvStyle()
        {
            dgvUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUser.Columns[0].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);
            dgvUser.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[1].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvUser.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[2].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvUser.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[3].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvUser.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[4].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvUser.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[5].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
        }

        private void tampilData()
        {
            if (koneksi.openConnection())
            {
                String query = String.Format("SELECT user_id, user_name, password, status, role FROM users");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);

                koneksi.da = new MySqlDataAdapter {SelectCommand = koneksi.cmd};

                koneksi.ds = new DataSet();

                koneksi.da.Fill(koneksi.ds, "datauser");

                int row = koneksi.ds.Tables["dataUser"].Rows.Count;

                dgvUser.Rows.Clear();

                for (int i = 0; i < row; i++)
                {
                    object[] itemArray = koneksi.ds.Tables["dataUser"].Rows[i].ItemArray;

                    dgvUser.Rows.Add();
                    dgvUser.Rows[i].Cells[0].Value = i + 1;
                    dgvUser.Rows[i].Cells[1].Value = itemArray[0];
                    dgvUser.Rows[i].Cells[2].Value = itemArray[1];
                    dgvUser.Rows[i].Cells[3].Value = itemArray[2];
                    dgvUser.Rows[i].Cells[4].Value = itemArray[3];
                    dgvUser.Rows[i].Cells[5].Value = itemArray[4];
                }

                dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUser.AllowUserToAddRows = false;
                koneksi.closeConnection();
            }
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

            txtUserId.Enabled = true;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            panelStatus.Enabled = false;
            cbRole.Enabled = false;

            btnSimpan.Text = "SIMPAN";
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            tampilData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (koneksi.openConnection())
            {
                if (btnSimpan.Text.Equals("SIMPAN"))
                {
                    String query =
                        string.Format(
                            "INSERT INTO users(user_id, user_name, password, status, role) VALUES('{0}','{1}',sha1('{2}'),'{3}','{4}')",
                            txtUserId.Text, txtUserName.Text, txtPassword.Text, rbActive.Checked ? '1' : '0',
                            cbRole.Text.Equals("Admin") ? "1" : "2");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.closeConnection();

                    MessageBox.Show("Success Insert Data");
                }

                if (btnSimpan.Text.Equals("UPDATE"))
                {
                    bool passwordChanged = false;

                    String query =
                        String.Format(
                            "SELECT password FROM users WHERE user_id = '{0}' AND (password = '{1}' OR password = sha1('{1}'))",
                            txtUserId.Text, txtPassword.Text);

                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.dr = koneksi.cmd.ExecuteReader();

                    if (!koneksi.dr.Read())
                    {
                        passwordChanged = true;
                    }

                    koneksi.dr.Close();

                    query = string.Format(
                        passwordChanged
                            ? "UPDATE users SET user_name = '{1}', password = sha1('{2}'), status = '{3}', role = '{4}' WHERE user_id = '{0}'"
                            : "UPDATE users SET user_name = '{1}', password = '{2}', status = '{3}', role = '{4}' WHERE user_id = '{0}'",
                        txtUserId.Text, txtUserName.Text, txtPassword.Text, rbActive.Checked ? '1' : '0',
                        cbRole.Text.Equals("Admin") ? "1" : "2");

                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.closeConnection();


                    MessageBox.Show("Success Update Data");
                }

                bersih();
            }
        }


        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                if (txtUserId.Text.Trim().Length == 0)
                {
                    return;
                }

                if (koneksi.openConnection())
                {
                    String query = String.Format("SELECT * FROM users WHERE user_id = '{0}'", txtUserId.Text);

                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.dr = koneksi.cmd.ExecuteReader();

                    if (koneksi.dr.Read())
                    {
                        txtUserName.Text = koneksi.dr["user_name"].ToString();
                        txtPassword.Text = koneksi.dr["password"].ToString();

                        if (koneksi.dr["status"].ToString().Equals("1"))
                        {
                            rbActive.Checked = true;
                        }
                        else
                        {
                            rbNonActive.Checked = true;
                        }

                        switch (koneksi.dr["role"].ToString())
                        {
                            case "1":
                                cbRole.SelectedIndex = 0;
                                break;
                            case "2":
                                cbRole.SelectedIndex = 1;
                                break;
                        }

                        txtUserId.Enabled = false;


                        btnSimpan.Text = "UPDATE";
                    }
                    else
                    {
                        txtUserId.Enabled = true;


                        btnSimpan.Text = "SIMPAN";
                    }

                    txtUserName.Enabled = true;
                    txtPassword.Enabled = true;
                    panelStatus.Enabled = true;
                    cbRole.Enabled = true;
                    btnSimpan.Enabled = true;
                    btnHapus.Enabled = true;

                    txtUserName.Focus();

                    koneksi.dr.Close();
                    koneksi.closeConnection();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bersih();
            txtUserId.Text = generateCode();
            txtUserId.Enabled = false;
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            panelStatus.Enabled = true;
            cbRole.Enabled = true;

            btnSimpan.Text = "SIMPAN";
            btnSimpan.Enabled = true;

            txtUserName.Focus();
        }

        private String generateCode()
        {
            if (koneksi.openConnection())
            {
                String kode;
                String query = "SELECT RIGHT(user_id,3)+1 as kode FROM users order by user_id desc limit 1";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                if (koneksi.dr.Read())
                {
                    if (koneksi.dr.GetInt32("kode") <= 9)
                    {
                        kode = String.Format("U00{0}", koneksi.dr["kode"]);
                    }
                    else if (koneksi.dr.GetInt32("kode") <= 99)
                    {
                        kode = String.Format("U0{0}", koneksi.dr["kode"]);
                    }
                    else
                    {
                        kode = String.Format("U{0}", koneksi.dr["kode"]);
                    }
                }
                else
                {
                    kode = "U001";
                }

                koneksi.dr.Close();
                koneksi.closeConnection();
                return kode;
            }
            else
            {
                return null;
            }
        }


        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUserId.Text = dgvUser.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells["Password"].Value.ToString();

                if (dgvUser.Rows[e.RowIndex].Cells["Status"].Value.ToString().Equals("1"))
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbNonActive.Checked = true;
                }

                cbRole.SelectedIndex = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["Role"].Value.ToString()) - 1;

                txtUserId.Enabled = false;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                panelStatus.Enabled = true;
                cbRole.Enabled = true;

                btnSimpan.Text = "UPDATE";
                btnSimpan.Enabled = true;
                btnHapus.Enabled = true;

                txtUserName.Focus();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (koneksi.openConnection())
            {
                String query =
                    String.Format("SELECT * from users WHERE user_id LIKE '%{0}%' OR user_name LIKE '%{0}%'",
                        txtCari.Text);
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.da = new MySqlDataAdapter {SelectCommand = koneksi.cmd};
                koneksi.ds = new DataSet();
                koneksi.da.Fill(koneksi.ds, "cariuser");

                int row = koneksi.ds.Tables["cariuser"].Rows.Count;

                dgvUser.Rows.Clear();

                for (int i = 0; i < row; i++)
                {
                    dgvUser.Rows.Add();
                    dgvUser.Rows[i].Cells[0].Value = i + 1;
                    dgvUser.Rows[i].Cells[1].Value = koneksi.ds.Tables["cariuser"].Rows[i].ItemArray[0];
                    dgvUser.Rows[i].Cells[2].Value = koneksi.ds.Tables["cariuser"].Rows[i].ItemArray[1];
                    dgvUser.Rows[i].Cells[3].Value = koneksi.ds.Tables["cariuser"].Rows[i].ItemArray[2];
                    dgvUser.Rows[i].Cells[4].Value = koneksi.ds.Tables["cariuser"].Rows[i].ItemArray[3];
                    dgvUser.Rows[i].Cells[5].Value = koneksi.ds.Tables["cariuser"].Rows[i].ItemArray[4];
                }

                dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUser.AllowUserToAddRows = false;
                koneksi.closeConnection();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Yakin ingin hapus data {txtUserId.Text}?",
                "Hapus?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                if (koneksi.openConnection())
                {
                    string query = String.Concat("DELETE FROM users WHERE user_id = '", txtUserId.Text, "'");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();

                    koneksi.closeConnection();
                    MessageBox.Show("Delete Data Success!");
                    bersih();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Data User";

            for (int i = 1; i < dgvUser.ColumnCount + 1; i++)
            {
                worksheet.Cells[1, i] = dgvUser.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvUser.RowCount ; i++)
            {
                for (int j = 0; j < dgvUser.ColumnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvUser.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
    }
}