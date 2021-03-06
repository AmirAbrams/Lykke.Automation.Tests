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

    public partial class StartTransferRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the StartTransferRequestModel class.
        /// </summary>
        public StartTransferRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartTransferRequestModel class.
        /// </summary>
        public StartTransferRequestModel(string offchainTransferId, string destClientId, string sourceClientId, string transferTypeCode = default(string), string additionalActionsDest = default(string), string additionalActionsSrc = default(string))
        {
            OffchainTransferId = offchainTransferId;
            DestClientId = destClientId;
            SourceClientId = sourceClientId;
            TransferTypeCode = transferTypeCode;
            AdditionalActionsDest = additionalActionsDest;
            AdditionalActionsSrc = additionalActionsSrc;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "offchainTransferId")]
        public string OffchainTransferId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destClientId")]
        public string DestClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceClientId")]
        public string SourceClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transferTypeCode")]
        public string TransferTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalActionsDest")]
        public string AdditionalActionsDest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalActionsSrc")]
        public string AdditionalActionsSrc { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OffchainTransferId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OffchainTransferId");
            }
            if (DestClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestClientId");
            }
            if (SourceClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceClientId");
            }
        }
    }
}
