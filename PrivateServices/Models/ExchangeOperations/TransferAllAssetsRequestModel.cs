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

    public partial class TransferAllAssetsRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the TransferAllAssetsRequestModel
        /// class.
        /// </summary>
        public TransferAllAssetsRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferAllAssetsRequestModel
        /// class.
        /// </summary>
        public TransferAllAssetsRequestModel(string clientId, string srcAddress, string destAddress)
        {
            ClientId = clientId;
            SrcAddress = srcAddress;
            DestAddress = destAddress;
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
        [JsonProperty(PropertyName = "srcAddress")]
        public string SrcAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destAddress")]
        public string DestAddress { get; set; }

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
            if (SrcAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SrcAddress");
            }
            if (DestAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestAddress");
            }
        }
    }
}
