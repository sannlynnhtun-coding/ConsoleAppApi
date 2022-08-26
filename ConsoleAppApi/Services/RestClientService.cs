using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppApi.Services
{
    public class RestClientService
    {
        public async Task v1()
        {
            RestClient restClient = new RestClient("https://api.coingecko.com");
            //RestRequest restRequest = new RestRequest();
            string resource = "api/v3/coins/markets?vs_currency=USD&order=market_cap_desc&per_page=100&page=1&sparkline=false";
            TrendingCoinsV2[] lst2 = await restClient.GetJsonAsync<TrendingCoinsV2[]>(resource);
            foreach (var item in lst2)
            {
                Console.WriteLine("{ id = " + item.id + " }");
            }
        }
    }
}
