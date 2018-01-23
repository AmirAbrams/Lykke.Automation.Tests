// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiBalanceChangeModel
    {
        /// <summary>
        /// Initializes a new instance of the ApiBalanceChangeModel class.
        /// </summary>
        public ApiBalanceChangeModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiBalanceChangeModel class.
        /// </summary>
        /// <param name="state">Possible values include: 'InProcessOnchain',
        /// 'SettledOnchain', 'InProcessOffchain', 'SettledOffchain',
        /// 'SettledNoChain'</param>
        public ApiBalanceChangeModel(string id = default(string), double? amount = default(double?), string dateTime = default(string), string asset = default(string), string iconId = default(string), string blockChainHash = default(string), bool? isRefund = default(bool?), string addressFrom = default(string), string addressTo = default(string), bool? isSettled = default(bool?), string type = default(string), string state = default(string))
        {
            Id = id;
            Amount = amount;
            DateTime = dateTime;
            Asset = asset;
            IconId = iconId;
            BlockChainHash = blockChainHash;
            IsRefund = isRefund;
            AddressFrom = addressFrom;
            AddressTo = addressTo;
            IsSettled = isSettled;
            Type = type;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Asset")]
        public string Asset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconId")]
        public string IconId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BlockChainHash")]
        public string BlockChainHash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsRefund")]
        public bool? IsRefund { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AddressFrom")]
        public string AddressFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AddressTo")]
        public string AddressTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSettled")]
        public bool? IsSettled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'InProcessOnchain',
        /// 'SettledOnchain', 'InProcessOffchain', 'SettledOffchain',
        /// 'SettledNoChain'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

    }
}
