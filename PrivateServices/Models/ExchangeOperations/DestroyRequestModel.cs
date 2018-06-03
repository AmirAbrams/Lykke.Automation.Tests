// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DestroyRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the DestroyRequestModel class.
        /// </summary>
        public DestroyRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DestroyRequestModel class.
        /// </summary>
        public DestroyRequestModel(string clientId, string addressFrom, string addressTo, double amount, string assetId)
        {
            ClientId = clientId;
            AddressFrom = addressFrom;
            AddressTo = addressTo;
            Amount = amount;
            AssetId = assetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressFrom")]
        public string AddressFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressTo")]
        public string AddressTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (AddressFrom == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressFrom");
            }
            if (AddressTo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressTo");
            }
            if (AssetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetId");
            }
        }
    }
}
