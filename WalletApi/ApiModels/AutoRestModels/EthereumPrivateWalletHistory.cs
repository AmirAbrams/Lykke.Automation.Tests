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

    public partial class EthereumPrivateWalletHistory
    {
        /// <summary>
        /// Initializes a new instance of the EthereumPrivateWalletHistory
        /// class.
        /// </summary>
        public EthereumPrivateWalletHistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EthereumPrivateWalletHistory
        /// class.
        /// </summary>
        public EthereumPrivateWalletHistory(IList<EthPrivateWalletHistoryRecord> history = default(IList<EthPrivateWalletHistoryRecord>))
        {
            History = history;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "History")]
        public IList<EthPrivateWalletHistoryRecord> History { get; set; }

    }
}
