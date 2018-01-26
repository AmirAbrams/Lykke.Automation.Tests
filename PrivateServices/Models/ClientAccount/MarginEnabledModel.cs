// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.ClientAccount.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MarginEnabledModel
    {
        /// <summary>
        /// Initializes a new instance of the MarginEnabledModel class.
        /// </summary>
        public MarginEnabledModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MarginEnabledModel class.
        /// </summary>
        public MarginEnabledModel(bool enabled, bool enabledLive, bool termsOfUseAgreed, string clientId = default(string))
        {
            Enabled = enabled;
            EnabledLive = enabledLive;
            TermsOfUseAgreed = termsOfUseAgreed;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnabledLive")]
        public bool EnabledLive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TermsOfUseAgreed")]
        public bool TermsOfUseAgreed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
