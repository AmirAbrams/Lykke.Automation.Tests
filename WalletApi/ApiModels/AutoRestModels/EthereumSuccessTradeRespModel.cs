// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EthereumSuccessTradeRespModel
    {
        /// <summary>
        /// Initializes a new instance of the EthereumSuccessTradeRespModel
        /// class.
        /// </summary>
        public EthereumSuccessTradeRespModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EthereumSuccessTradeRespModel
        /// class.
        /// </summary>
        public EthereumSuccessTradeRespModel(ApiEthereumOrder order = default(ApiEthereumOrder))
        {
            Order = order;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Order")]
        public ApiEthereumOrder Order { get; set; }

    }
}
