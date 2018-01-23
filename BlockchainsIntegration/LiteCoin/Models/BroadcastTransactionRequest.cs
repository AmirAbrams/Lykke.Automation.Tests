// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BroadcastTransactionRequest
    {
        /// <summary>
        /// Initializes a new instance of the BroadcastTransactionRequest
        /// class.
        /// </summary>
        public BroadcastTransactionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BroadcastTransactionRequest
        /// class.
        /// </summary>
        public BroadcastTransactionRequest(System.Guid operationId, string signedTransaction = default(string))
        {
            OperationId = operationId;
            SignedTransaction = signedTransaction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public System.Guid OperationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signedTransaction")]
        public string SignedTransaction { get; set; }

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
