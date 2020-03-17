using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.TextLength > 0)
            {
                DialogResult result = MessageBox.Show("Save this document?", "Attention", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {
                    txtEditor.Clear();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogDoc.Title = "Open File Document";
            openFileDialogDoc.FileName = "";
            openFileDialogDoc.DefaultExt = "txt";
            openFileDialogDoc.Filter = "txt Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogDoc.FilterIndex = 0;
            openFileDialogDoc.CheckFileExists = true;
            openFileDialogDoc.CheckPathExists = true;
            openFileDialogDoc.Multiselect = false;

            DialogResult result = openFileDialogDoc.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Text = this.Text + " - " + openFileDialogDoc.FileName;
                txtEditor.Text = File.ReadAllText(openFileDialogDoc.FileName);
            }
            else
            {
                MessageBox.Show("This file can't be opened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveFileDialogDoc_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogDoc.Title = "Save To?";
            saveFileDialogDoc.InitialDirectory = "@'C:\'";
            saveFileDialogDoc.RestoreDirectory = true;
            saveFileDialogDoc.DefaultExt = "txt";
            saveFileDialogDoc.Filter = "txt Files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogDoc.FilterIndex = 1;

            DialogResult result = saveFileDialogDoc.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Text = this.Text + " - " + saveFileDialogDoc.FileName;
                File.WriteAllText(saveFileDialogDoc.FileName, txtEditor.Text);
            }
            else
            {
                MessageBox.Show("This file can't be saved", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialogDoc.ShowColor = true;
            fontDialogDoc.ShowApply = true;
            fontDialogDoc.ShowEffects = true;
            fontDialogDoc.ShowHelp = true;
            DialogResult result = fontDialogDoc.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                txtEditor.Font = fontDialogDoc.Font;
                txtEditor.ForeColor = fontDialogDoc.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtEditor.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save this doument?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogDoc.AllowFullOpen = true;
            colorDialogDoc.AnyColor = true;
            colorDialogDoc.SolidColorOnly = true;
            colorDialogDoc.Color = Color.White;

            DialogResult result = colorDialogDoc.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = colorDialogDoc.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String aboutInfo = "Text Editor\n" +
                               "Version \t\t: 1.0.0\n" +
                               "Last Update \t: 16 Maret 2020\n" +
                               "Developed by \t: Corpus\n" +
                               "License \t\t: Freeware";
            MessageBox.Show(aboutInfo, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}