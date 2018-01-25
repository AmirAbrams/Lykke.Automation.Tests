// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RecoveryTokenChallangeResponse
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryTokenChallangeResponse
        /// class.
        /// </summary>
        public RecoveryTokenChallangeResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryTokenChallangeResponse
        /// class.
        /// </summary>
        public RecoveryTokenChallangeResponse(string email = default(string), string signedMessage = default(string))
        {
            Email = email;
            SignedMessage = signedMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SignedMessage")]
        public string SignedMessage { get; set; }

    }
}