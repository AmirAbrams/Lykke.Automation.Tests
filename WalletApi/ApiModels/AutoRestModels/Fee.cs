// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Fee
    {
        /// <summary>
        /// Initializes a new instance of the Fee class.
        /// </summary>
        public Fee()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Fee class.
        /// </summary>
        public Fee(double? amount = default(double?), string type = default(string))
        {
            Amount = amount;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

    }
}