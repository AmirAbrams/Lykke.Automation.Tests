// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ToBaseConvertionRequest
    {
        /// <summary>
        /// Initializes a new instance of the ToBaseConvertionRequest class.
        /// </summary>
        public ToBaseConvertionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ToBaseConvertionRequest class.
        /// </summary>
        public ToBaseConvertionRequest(string baseAssetId = default(string), IList<AssetWithAmount> assetsFrom = default(IList<AssetWithAmount>), string orderAction = default(string))
        {
            BaseAssetId = baseAssetId;
            AssetsFrom = assetsFrom;
            OrderAction = orderAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BaseAssetId")]
        public string BaseAssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetsFrom")]
        public IList<AssetWithAmount> AssetsFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderAction")]
        public string OrderAction { get; set; }

    }
}