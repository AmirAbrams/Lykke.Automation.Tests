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

    public partial class TransferRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the TransferRequestModel class.
        /// </summary>
        public TransferRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferRequestModel class.
        /// </summary>
        public TransferRequestModel(string destClientId, string sourceClientId, double amount, string assetId, string transferTypeCode = default(string), string additionalActionsDest = default(string), string additionalActionsSrc = default(string), string additionalData = default(string), string operationId = default(string), InternalFeeModel fee = default(InternalFeeModel), double? overdraft = default(double?))
        {
            DestClientId = destClientId;
            SourceClientId = sourceClientId;
            Amount = amount;
            AssetId = assetId;
            TransferTypeCode = transferTypeCode;
            AdditionalActionsDest = additionalActionsDest;
            AdditionalActionsSrc = additionalActionsSrc;
            AdditionalData = additionalData;
            OperationId = operationId;
            Fee = fee;
            Overdraft = overdraft;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }

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
        /// </summary>
        [JsonProperty(PropertyName = "additionalData")]
        public string AdditionalData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fee")]
        public InternalFeeModel Fee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overdraft")]
        public double? Overdraft { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DestClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestClientId");
            }
            if (SourceClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceClientId");
            }
            if (AssetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetId");
            }
        }
    }
}
