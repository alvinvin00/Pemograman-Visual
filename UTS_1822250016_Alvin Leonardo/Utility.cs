using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace UTS_1822250016_Alvin_Leonardo
{
    class Utility
    {
        private static readonly String baseUrl = "https://api.kawalcorona.com/";

        public static async Task<List<ValueData>> getAllCovid19DataProvinsi()
        {
            HttpClient client = new HttpClient {BaseAddress = new Uri(baseUrl)};

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (HttpResponseMessage responseMessage = await client.GetAsync(baseUrl + "indonesia/provinsi"))
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
    }
}