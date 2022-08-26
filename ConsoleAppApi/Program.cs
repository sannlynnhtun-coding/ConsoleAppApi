// See https://aka.ms/new-console-template for more information
using ConsoleAppApi;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");


await new RestClientService().v1();
await new HttpClientService().v1();
await new HttpClientService().v2();



public class Roi
{
    public double times { get; set; }
    public string currency { get; set; }
    public double percentage { get; set; }
}

public class TrendingCoinsV2
{
    public string id { get; set; }
    public string symbol { get; set; }
    public string name { get; set; }
    public string image { get; set; }
    public double current_price { get; set; }
    public object market_cap { get; set; }
    public int market_cap_rank { get; set; }
    public long? fully_diluted_valuation { get; set; }
    public object total_volume { get; set; }
    public double high_24h { get; set; }
    public double low_24h { get; set; }
    public double price_change_24h { get; set; }
    public double price_change_percentage_24h { get; set; }
    public double market_cap_change_24h { get; set; }
    public double market_cap_change_percentage_24h { get; set; }
    public double circulating_supply { get; set; }
    public double? total_supply { get; set; }
    public double? max_supply { get; set; }
    public double ath { get; set; }
    public double ath_change_percentage { get; set; }
    public DateTime ath_date { get; set; }
    public double atl { get; set; }
    public double atl_change_percentage { get; set; }
    public DateTime atl_date { get; set; }
    public Roi roi { get; set; }
    public DateTime last_updated { get; set; }
}

