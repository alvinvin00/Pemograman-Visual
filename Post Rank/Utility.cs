using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Post_Rank
{
    public class Utility
    {
        public static String baseURL = "https://bisaditunggu.000webhostapp.com/index.php/api/";

        public static async Task<ValueData<PostRank>> getAllRank()
        {
            Dictionary<String, String> query = new Dictionary<String, String> {{"key", "dirumahaja"}};

            HttpContent q = new FormUrlEncodedContent(query);

            HttpClient client = new HttpClient {BaseAddress = new Uri(baseURL)};

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (HttpResponseMessage responseMessage = await client.PostAsync(baseURL + "getAllPost", q))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    String data = await responseMessage.Content.ReadAsStringAsync();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

                    ValueData<PostRank> valueData = javaScriptSerializer.Deserialize<ValueData<PostRank>>(data);

                    return valueData;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }

        public static async Task<ValueNoData> postRank(String username, String about)
        {
            Dictionary<String, String> query = new Dictionary<String, String>
            {
                {"key", "dirumahaja"}, {"username", username}, {"content", about}
            };


            HttpContent q = new FormUrlEncodedContent(query);

            HttpClient client = new HttpClient {BaseAddress = new Uri(baseURL)};


            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (HttpResponseMessage responseMessage = await client.PostAsync(baseURL + "post", q))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    String data = await responseMessage.Content.ReadAsStringAsync();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

                    ValueNoData valueNoData = javaScriptSerializer.Deserialize<ValueNoData>(data);

                    return valueNoData;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}