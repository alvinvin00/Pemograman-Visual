using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_1822250016_Alvin_Leonardo
{
    public partial class FrmMenuUtama : Form
    {
        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnReload_ClickAsync(object sender, EventArgs e)
        {
            flpDashboard.Controls.Clear();

            await tampilDataCovid();
        }

        private async Task tampilDataCovid()
        {
            List<ValueData> listValueData = await Utility.getAllCovid19DataProvinsi();

            if (listValueData.Count > 0)
            {
                for (int i = 0; i < listValueData.Count; i++)
                {
                    Button btnData = new Button();
                    flpDashboard.Controls.Add(btnData);
                    btnData.Location = new Point(150 * i, 0);
                    btnData.Name = "btnData" + (i + 1).ToString();
                    btnData.Size = new Size(150, 120);
                    btnData.TabIndex = i;
                    btnData.Text = "";
                    btnData.UseVisualStyleBackColor = true;
                    btnData.FlatStyle = FlatStyle.Flat;

                    Bitmap bmp = new Bitmap(btnData.ClientRectangle.Width, btnData.ClientRectangle.Height);

                    using (Graphics G = Graphics.FromImage(bmp))
                    {
                        G.Clear(btnData.BackColor);

                        Covid19 covid19 = listValueData[i].attributes;

                        String FID = covid19.FID.ToString();
                        String kodeProvinsi = covid19.Kode_Provi.ToString();
                        String provinsi = covid19.Provinsi;
                        String kasusPosi = "Positif : " + covid19.Kasus_Posi;
                        String kasusSemb = "Sembuh : " + covid19.Kasus_Semb;
                        String kasusMeni = "Meninggal : " + covid19.Kasus_Meni;

                        StringFormat SF = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        Rectangle RC = btnData.ClientRectangle;

                        Font courier = new Font("MS Courier", 9.0F, FontStyle.Regular);
                        Font msSansSerif = new Font("Segoe UI", 12.0F, FontStyle.Bold);

                        float x = -35;
                        RC.Y = (int) x;
                        G.DrawString(provinsi, msSansSerif, Brushes.Black, RC, SF);
                        x += 10 + G.MeasureString(provinsi, courier).Height;

                        RC.Y = (int) x;
                        G.DrawString(kasusPosi, courier, Brushes.Maroon, RC, SF);
                        x += G.MeasureString(kasusPosi, courier).Height;

                        RC.Y = (int) x;
                        G.DrawString(kasusSemb, courier, Brushes.Green, RC, SF);
                        x += G.MeasureString(kasusSemb, courier).Height;

                        RC.Y = (int) x;
                        G.DrawString(kasusMeni, courier, Brushes.Red, RC, SF);
                        x += G.MeasureString(kasusMeni, courier).Height;
                    }

                    btnData.Image = bmp;
                    btnData.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }
        }


        private async void FrmMenuUtama_LoadAsync(object sender, EventArgs e)
        {
            await tampilDataCovid();
        }
    }
}