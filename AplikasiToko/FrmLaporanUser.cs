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
    public partial class FrmLaporanUser : Form
    {
        public FrmLaporanUser()
        {
            InitializeComponent();
        }

        private void FrmLaporanUser_Load(object sender, EventArgs e)
        {
            CRUsers crUser = new CRUsers();
            crUser.SummaryInfo.ReportTitle = "Laporan User";
            crvUser.ReportSource = crUser;
            crvUser.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            crvUser.Refresh();
            
        }
    }
}
