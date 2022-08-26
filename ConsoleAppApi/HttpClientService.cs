using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppApi
{
    public class HttpClientService
    {
        public async Task v1()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.coingecko.com");

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "api/v3/coins/markets?vs_currency=USD&order=market_cap_desc&per_page=100&page=1&sparkline=false");
            var res = await client.SendAsync(message);
            if (res != null)
            {
                string result = await res.Content.ReadAsStringAsync();
                List<TrendingCoinsV2> lst = JsonConvert.DeserializeObject<List<TrendingCoinsV2>>(result);
                foreach (var item in lst)
                {
                    Console.WriteLine("{ id = " + item.id + " }");
                }
            }
        }

        public async Task v2()
        {
            HttpClient client3 = new HttpClient();
            client3.BaseAddress = new Uri("https://api.coingecko.com");
            var lst3 = await client3.GetFromJsonAsync<TrendingCoinsV2[]>("api/v3/coins/markets?vs_currency=USD&order=market_cap_desc&per_page=100&page=1&sparkline=false");
            foreach (var item in lst3)
            {
                Console.WriteLine("{ id = " + item.id + " }");
            }

        }
    }
}
