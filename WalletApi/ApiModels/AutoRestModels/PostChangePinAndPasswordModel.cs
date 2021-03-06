// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PostChangePinAndPasswordModel
    {
        /// <summary>
        /// Initializes a new instance of the PostChangePinAndPasswordModel
        /// class.
        /// </summary>
        public PostChangePinAndPasswordModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostChangePinAndPasswordModel
        /// class.
        /// </summary>
        public PostChangePinAndPasswordModel(string partnerId = default(string), string email = default(string), string signedOwnershipMsg = default(string), string smsCode = default(string), string newPin = default(string), string newPassword = default(string), string newHint = default(string), string encodedPrivateKey = default(string))
        {
            PartnerId = partnerId;
            Email = email;
            SignedOwnershipMsg = signedOwnershipMsg;
            SmsCode = smsCode;
            NewPin = newPin;
            NewPassword = newPassword;
            NewHint = newHint;
            EncodedPrivateKey = encodedPrivateKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PartnerId")]
        public string PartnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SignedOwnershipMsg")]
        public string SignedOwnershipMsg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SmsCode")]
        public string SmsCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewPin")]
        public string NewPin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewHint")]
        public string NewHint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EncodedPrivateKey")]
        public string EncodedPrivateKey { get; set; }

    }
}
