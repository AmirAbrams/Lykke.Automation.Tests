// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreditVoucherContent
    {
        /// <summary>
        /// Initializes a new instance of the CreditVoucherContent class.
        /// </summary>
        public CreditVoucherContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreditVoucherContent class.
        /// </summary>
        public CreditVoucherContent(string contentBase64 = default(string), string url = default(string))
        {
            ContentBase64 = contentBase64;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContentBase64")]
        public string ContentBase64 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Url")]
        public string Url { get; set; }

    }
}