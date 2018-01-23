// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.ClientAccount.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RefundAddressSettings
    {
        /// <summary>
        /// Initializes a new instance of the RefundAddressSettings class.
        /// </summary>
        public RefundAddressSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefundAddressSettings class.
        /// </summary>
        public RefundAddressSettings(string address = default(string), int? validDays = default(int?), bool? sendAutomatically = default(bool?))
        {
            Address = address;
            ValidDays = validDays;
            SendAutomatically = sendAutomatically;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ValidDays")]
        public int? ValidDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SendAutomatically")]
        public bool? SendAutomatically { get; set; }

    }
}
