// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ClientKeysModel
    {
        /// <summary>
        /// Initializes a new instance of the ClientKeysModel class.
        /// </summary>
        public ClientKeysModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientKeysModel class.
        /// </summary>
        public ClientKeysModel(string pubKey = default(string), string encodedPrivateKey = default(string), string privateKey = default(string), string tempKey = default(string))
        {
            PubKey = pubKey;
            EncodedPrivateKey = encodedPrivateKey;
            PrivateKey = privateKey;
            TempKey = tempKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PubKey")]
        public string PubKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EncodedPrivateKey")]
        public string EncodedPrivateKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrivateKey")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TempKey")]
        public string TempKey { get; set; }

    }
}
