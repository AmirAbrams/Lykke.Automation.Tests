// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetSingleAssetPairRateModel
    {
        /// <summary>
        /// Initializes a new instance of the GetSingleAssetPairRateModel
        /// class.
        /// </summary>
        public GetSingleAssetPairRateModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetSingleAssetPairRateModel
        /// class.
        /// </summary>
        public GetSingleAssetPairRateModel(ApiAssetPairRateBaseModel rate = default(ApiAssetPairRateBaseModel))
        {
            Rate = rate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rate")]
        public ApiAssetPairRateBaseModel Rate { get; set; }

    }
}
