using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WpfPrismSample.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Coin
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("marketCap")]
        public string MarketCap { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("listedAt")]
        public int ListedAt { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("change")]
        public string Change { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("sparkline")]
        public List<string> Sparkline { get; set; }

        [JsonPropertyName("lowVolume")]
        public bool LowVolume { get; set; }

        [JsonPropertyName("coinrankingUrl")]
        public string CoinrankingUrl { get; set; }

        [JsonPropertyName("24hVolume")]
        public string _24hVolume { get; set; }

        [JsonPropertyName("btcPrice")]
        public string BtcPrice { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("coins")]
        public List<Coin> Coins { get; set; }
    }

    public class CoinRoot
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Stats
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("totalCoins")]
        public int TotalCoins { get; set; }

        [JsonPropertyName("totalMarkets")]
        public int TotalMarkets { get; set; }

        [JsonPropertyName("totalExchanges")]
        public int TotalExchanges { get; set; }

        [JsonPropertyName("totalMarketCap")]
        public string TotalMarketCap { get; set; }

        [JsonPropertyName("total24hVolume")]
        public string Total24hVolume { get; set; }
    }


}
