namespace AplikasiToko
{
    partial class FrmLaporanUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvUser = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvUser
            // 
            this.crvUser.ActiveViewIndex = -1;
            this.crvUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUser.Location = new System.Drawing.Point(0, 0);
            this.crvUser.Name = "crvUser";
            this.crvUser.Size = new System.Drawing.Size(800, 450);
            this.crvUser.TabIndex = 0;
            // 
            // FrmLaporanUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvUser);
            this.Name = "FrmLaporanUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan User";
            this.Load += new System.EventHandler(this.FrmLaporanUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUser;
    }
}