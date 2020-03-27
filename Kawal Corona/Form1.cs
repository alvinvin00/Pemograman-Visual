using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Kawal_Corona
{
    public partial class FrmMenuUtama : Form
    {
        private List<ValueData> listValueData;

        private async Task<List<ValueData>> getAllDataCOVID19()
        {
            String url = "https://api.kawalcorona.com/";

            HttpClient client = new HttpClient {BaseAddress = new Uri(url)};
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (HttpResponseMessage responseMessage = await client.GetAsync(url))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    String data = await responseMessage.Content.ReadAsStringAsync();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<ValueData> valueData = javaScriptSerializer.Deserialize<List<ValueData>>(data);

                    return valueData;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }

        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private async void FrmMenuUtama_LoadAsync(object sender, EventArgs e)
        {
            listValueData = await getAllDataCOVID19();

            getAllCovidMap();

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
                    btnData.Click += new EventHandler(btnData_click);

                    Bitmap bmp = new Bitmap(btnData.ClientRectangle.Width, btnData.ClientRectangle.Height);

                    using (Graphics G = Graphics.FromImage(bmp))
                    {
                        G.Clear(btnData.BackColor);

                        Covid19 covid19 = listValueData[i].attributes;

                        String Country_Region = covid19.Country_Region;
                        String Confirmed = "Confirmed : " + covid19.Confirmed;
                        String Deaths = "Deaths : " + covid19.Deaths;
                        String Recovered = "Recovered : " + covid19.Recovered;
                        String Active = "Active : " + covid19.Active;

                        StringFormat SF = new StringFormat
                        {
                            Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center
                        };
                        Rectangle RC = btnData.ClientRectangle;

                        Font courier = new Font("MS Courier", 9.0F, FontStyle.Regular);
                        Font msSansSerif = new Font("Segoe UI", 12.0F, FontStyle.Bold);

                        float x = -35;
                        RC.Y = (int) x;
                        G.DrawString(Country_Region, msSansSerif, Brushes.Black, RC, SF);
                        x += 10 + G.MeasureString(Country_Region, courier).Height;
                        RC.Y = (int) x;
                        G.DrawString(Confirmed, courier, Brushes.Maroon, RC, SF);
                        x += G.MeasureString(Confirmed, courier).Height;
                        RC.Y = (int) x;
                        G.DrawString(Deaths, courier, Brushes.Red, RC, SF);
                        x += G.MeasureString(Deaths, courier).Height;
                        RC.Y = (int) x;
                        G.DrawString(Recovered, courier, Brushes.Green, RC, SF);
                        x += G.MeasureString(Recovered, courier).Height;
                        RC.Y = (int) x;
                        G.DrawString(Active, courier, Brushes.DarkOrange, RC, SF);
                    }

                    btnData.Image = bmp;
                    btnData.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void btnData_click(object sender, EventArgs e)
        {
            Button btnData = sender as Button;
            ValueData valueData = listValueData[btnData.TabIndex];

            // StringBuilder queryAddress = new StringBuilder();
            // queryAddress.Append("https://www.google.com/maps/@");
            // queryAddress.Append(valueData.attributes.Lat.ToString().Replace(",", ".") + "," +
            //                     valueData.attributes.Long_.ToString().Replace(",", ".") + ",5z");
            // System.Diagnostics.Process.Start(queryAddress.ToString());

            Covid19 covid19 = valueData.attributes;

            double lat = covid19.Lat;
            double lng = covid19.Long_;

            gMapControlCovid.Overlays.Clear();
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControlCovid.CacheLocation = @"cache";
            gMapControlCovid.DragButton = MouseButtons.Right;
            gMapControlCovid.ShowCenter = false;
            gMapControlCovid.MapProvider = GMapProviders.GoogleMap;
            gMapControlCovid.Position = new PointLatLng(lat, lng);
            gMapControlCovid.MinZoom = 0;
            gMapControlCovid.MaxZoom = 18;
            gMapControlCovid.Zoom = 5;

            GMapOverlay markers = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
            String name = String.Format("{0} \n" +
                                        "Confirmed : {1}\n" +
                                        "Deaths : {2}\n" +
                                        "Recovered : {3}\n" +
                                        "Active : {4}\n" +
                                        "Lat, Lng : {5},{6}", covid19.Country_Region,
                covid19.Confirmed, covid19.Deaths, covid19.Recovered,
                covid19.Active, lat, lng);
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipText = name;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markers.Markers.Add(marker);
            gMapControlCovid.Overlays.Add(markers);
        }

        private void getAllCovidMap()
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControlCovid.CacheLocation = @"cache";
            gMapControlCovid.DragButton = MouseButtons.Right;
            gMapControlCovid.ShowCenter = false;
            gMapControlCovid.MapProvider = GMapProviders.GoogleMap;
            gMapControlCovid.Position = new PointLatLng(0, 0);

            gMapControlCovid.Overlays.Clear();

            for (int i = 0; i < listValueData.Count; i++)
            {
                Covid19 covid19 = listValueData[i].attributes;

                double lat = covid19.Lat;
                double lng = covid19.Long_;


                GMapOverlay markers = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
                String name = String.Format("{0} \n" +
                                            "Confirmed : {1}\n" +
                                            "Deaths : {2}\n" +
                                            "Recovered : {3}\n" +
                                            "Active : {4}\n" +
                                            "Lat, Lng : {5},{6}", covid19.Country_Region,
                    covid19.Confirmed, covid19.Deaths, covid19.Recovered,
                    covid19.Active, lat, lng);
                marker.ToolTip = new GMapToolTip(marker);
                marker.ToolTipText = name;
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                markers.Markers.Add(marker);
                gMapControlCovid.Overlays.Add(markers);
            }

            gMapControlCovid.MinZoom = 0;
            gMapControlCovid.MaxZoom = 18;
            gMapControlCovid.Zoom = 2;
            gMapControlCovid.Zoom--;
            gMapControlCovid.Zoom++;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            getAllCovidMap();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}