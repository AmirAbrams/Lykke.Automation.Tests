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

    public partial class PaginationResponseWalletBalanceContract
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PaginationResponseWalletBalanceContract class.
        /// </summary>
        public PaginationResponseWalletBalanceContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PaginationResponseWalletBalanceContract class.
        /// </summary>
        public PaginationResponseWalletBalanceContract(string continuation = default(string), IList<WalletBalanceContract> items = default(IList<WalletBalanceContract>))
        {
            Continuation = continuation;
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "continuation")]
        public string Continuation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<WalletBalanceContract> Items { get; set; }

    }
}
