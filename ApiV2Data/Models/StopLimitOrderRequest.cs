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

    public partial class StopLimitOrderRequest
    {
        /// <summary>
        /// Initializes a new instance of the StopLimitOrderRequest class.
        /// </summary>
        public StopLimitOrderRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StopLimitOrderRequest class.
        /// </summary>
        /// <param name="orderAction">Possible values include: 'Buy',
        /// 'Sell'</param>
        public StopLimitOrderRequest(string assetPairId, double volume, double lowerLimitPrice, double lowerPrice, double upperLimitPrice, double upperPrice, OrderAction orderAction)
        {
            AssetPairId = assetPairId;
            Volume = volume;
            LowerLimitPrice = lowerLimitPrice;
            LowerPrice = lowerPrice;
            UpperLimitPrice = upperLimitPrice;
            UpperPrice = upperPrice;
            OrderAction = orderAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetPairId")]
        public string AssetPairId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Volume")]
        public double Volume { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LowerLimitPrice")]
        public double LowerLimitPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LowerPrice")]
        public double LowerPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UpperLimitPrice")]
        public double UpperLimitPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UpperPrice")]
        public double UpperPrice { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Buy', 'Sell'
        /// </summary>
        [JsonProperty(PropertyName = "OrderAction")]
        public OrderAction OrderAction { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AssetPairId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetPairId");
            }
        }
    }
}