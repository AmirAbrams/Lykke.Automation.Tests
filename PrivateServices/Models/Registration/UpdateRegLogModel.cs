// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.Registration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateRegLogModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateRegLogModel class.
        /// </summary>
        public UpdateRegLogModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateRegLogModel class.
        /// </summary>
        public UpdateRegLogModel(string clientId = default(string), string country = default(string), string city = default(string), string isp = default(string))
        {
            ClientId = clientId;
            Country = country;
            City = city;
            Isp = isp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Isp")]
        public string Isp { get; set; }

    }
}
