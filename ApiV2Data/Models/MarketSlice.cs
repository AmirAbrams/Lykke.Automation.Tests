// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.ApiV2.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A model representing the current state of the Spot (only) market in
    /// terms of a particular asset pair.
    /// </summary>
    public partial class MarketSlice
    {
        /// <summary>
        /// Initializes a new instance of the MarketSlice class.
        /// </summary>
        public MarketSlice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MarketSlice class.
        /// </summary>
        /// <param name="assetPair">Asset pair ID.</param>
        /// <param name="volume24H">Trading volume for the current day. Is
        /// obtained from asset pair's Day Trade candle for today.</param>
        /// <param name="priceChange24H">Trade price change for the current
        /// day. Is calculated by the formula: (Close - Open) / Open, where
        /// Open and Close are the corresponding prices for today's Day Trade
        /// candle.</param>
        /// <param name="lastPrice">The last trade price. Is obtained from
        /// asset pair's Day Trade candle for today and is equal to its Close
        /// price.</param>
        /// <param name="bid">The actual Bid price for the asset pair.</param>
        /// <param name="ask">The actual Ask price for the asset pair.</param>
        public MarketSlice(string assetPair, double volume24H, double priceChange24H, double lastPrice, double bid, double ask)
        {
            AssetPair = assetPair;
            Volume24H = volume24H;
            PriceChange24H = priceChange24H;
            LastPrice = lastPrice;
            Bid = bid;
            Ask = ask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets asset pair ID.
        /// </summary>
        [JsonProperty(PropertyName = "AssetPair")]
        public string AssetPair { get; set; }

        /// <summary>
        /// Gets or sets trading volume for the current day. Is obtained from
        /// asset pair's Day Trade candle for today.
        /// </summary>
        [JsonProperty(PropertyName = "Volume24H")]
        public double Volume24H { get; set; }

        /// <summary>
        /// Gets or sets trade price change for the current day. Is calculated
        /// by the formula: (Close - Open) / Open, where Open and Close are the
        /// corresponding prices for today's Day Trade candle.
        /// </summary>
        [JsonProperty(PropertyName = "PriceChange24H")]
        public double PriceChange24H { get; set; }

        /// <summary>
        /// Gets or sets the last trade price. Is obtained from asset pair's
        /// Day Trade candle for today and is equal to its Close price.
        /// </summary>
        [JsonProperty(PropertyName = "LastPrice")]
        public double LastPrice { get; set; }

        /// <summary>
        /// Gets or sets the actual Bid price for the asset pair.
        /// </summary>
        [JsonProperty(PropertyName = "Bid")]
        public double Bid { get; set; }

        /// <summary>
        /// Gets or sets the actual Ask price for the asset pair.
        /// </summary>
        [JsonProperty(PropertyName = "Ask")]
        public double Ask { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AssetPair == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetPair");
            }
        }
    }
}
