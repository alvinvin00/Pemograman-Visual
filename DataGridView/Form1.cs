using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvDataKontak.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDataKontak.Columns[0].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);
            dgvDataKontak.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDataKontak.Columns[1].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgvDataKontak.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDataKontak.Columns[2].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgvDataKontak.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDataKontak.Columns[3].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgvDataKontak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bersih();
        }

        private void bersih() {
            txtNama.Clear();
            txtNoHP.Clear();
            txtKeterangan.Clear();
            dgvDataKontak.Rows.Clear();
            txtNama.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e) {
            bool isFounded = false;
            int position = -1;
            for (int i = 0; i < dgvDataKontak.Rows.Count; i++) {
                if (txtNama.Text.Trim().Equals(dgvDataKontak.Rows[i].Cells[1].Value.ToString())) {
                    isFounded = true;
                    position = i;
                    break;
                }
            }

            if (isFounded) {
                DialogResult result =
                    MessageBox.Show(
                        "'" + dgvDataKontak.Rows[position].Cells[1].Value.ToString() +
                        "' already exists. Do you want to update?", "Confirm?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes) {
                    dgvDataKontak.Rows[position].Cells[2].Value = txtNoHP.Text;
                    dgvDataKontak.Rows[position].Cells[3].Value = txtKeterangan.Text;
                }
            }
            else {
                int pos = dgvDataKontak.Rows.Count;

                dgvDataKontak.Rows.Add();
                dgvDataKontak.Rows[pos].Cells[0].Value = pos + 1;
                dgvDataKontak.Rows[pos].Cells[1].Value = txtNama.Text;
                dgvDataKontak.Rows[pos].Cells[2].Value = txtNoHP.Text;
                dgvDataKontak.Rows[pos].Cells[3].Value = txtKeterangan.Text;

                txtNama.Clear();
                txtNoHP.Clear();
                txtKeterangan.Clear();
                txtNama.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            bersih();
        }

        private void dgvDataKontak_KeyDown(object sender, KeyEventArgs e) {
            if (dgvDataKontak.Rows.Count > 0) {
                if (e.KeyCode == Keys.Delete) {
                    int selectedIndex = dgvDataKontak.CurrentCell.RowIndex;
                    DialogResult result =
                        MessageBox.Show(
                            "Are you sure to delete '" + dgvDataKontak.Rows[selectedIndex].Cells[1].Value.ToString() +
                            "' ?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes) {
                        dgvDataKontak.Rows.RemoveAt(selectedIndex);

                        for (int i = selectedIndex; i < dgvDataKontak.Rows.Count; i++) {
                            dgvDataKontak.Rows[i].Cells[0].Value = (i + 1).ToString();
                        }
                    }
                }
            }
        }
    }
}