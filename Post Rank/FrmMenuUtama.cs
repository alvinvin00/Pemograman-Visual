using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post_Rank
{
    public partial class FrmMenuUtama : Form
    {
        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private async Task tampilDataRank()
        {
            ValueData<PostRank> responseData = await Utility.getAllRank();
            int success = responseData.success;

            if (success == 1)
            {
                dgvPostRank.Rows.Clear();

                for (int i = 0; i < responseData.data.Count; i++)
                {
                    dgvPostRank.Rows.Add();
                    dgvPostRank.Rows[i].Cells[0].Value = responseData.data[i].id;
                    dgvPostRank.Rows[i].Cells[1].Value = responseData.data[i].username;
                    dgvPostRank.Rows[i].Cells[2].Value = responseData.data[i].content;

                    if (responseData.data[i].username.Equals(lblNPM.Text))
                    {
                        lblRank.Text = responseData.data[i].id.ToString();
                    }
                }

                dgvPostRank.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPostRank.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show(responseData.message, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task insertPostRank(String username, String about)
        {
            ValueNoData responseData = await Utility.postRank(username, about);

            int success = responseData.success;

            if (success == 1)
            {
                lblRank.Text = responseData.rank;
            }
            else
            {
                MessageBox.Show(responseData.message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await tampilDataRank();
        }

        private async void FrmMenuUtama_LoadAsync(object sender, EventArgs e)
        {
            bersih();
            dgvPostRank.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPostRank.Columns[0].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);
            dgvPostRank.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPostRank.Columns[1].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgvPostRank.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPostRank.Columns[2].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            await tampilDataRank();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnPost_ClickAsync(object sender, EventArgs e)
        {
            if (txtAbout.Text.Trim().Length > 0)
            {
                await insertPostRank(lblNPM.Text, txtAbout.Text);
            }
            else
            {
                MessageBox.Show(@"Message can't be empty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnReload_ClickAsync(object sender, EventArgs e)
        {
            await tampilDataRank();
        }

        private void bersih()
        {
            lblRank.Text = "-";
            txtAbout.Clear();
        }
    }
}