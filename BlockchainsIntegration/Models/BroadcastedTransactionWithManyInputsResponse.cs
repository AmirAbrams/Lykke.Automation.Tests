// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BroadcastedTransactionWithManyInputsResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BroadcastedTransactionWithManyInputsResponse class.
        /// </summary>
        public BroadcastedTransactionWithManyInputsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BroadcastedTransactionWithManyInputsResponse class.
        /// </summary>
        /// <param name="state">Possible values include: 'inProgress',
        /// 'completed', 'failed'</param>
        /// <param name="errorCode">Possible values include: 'unknown',
        /// 'amountIsTooSmall', 'notEnoughtBalance'</param>
        public BroadcastedTransactionWithManyInputsResponse(System.Guid operationId, BroadcastedTransactionState state, System.DateTime timestamp, long block, IList<TransactionInputContract> inputs = default(IList<TransactionInputContract>), string fee = default(string), string hash = default(string), string error = default(string), TransactionExecutionError? errorCode = default(TransactionExecutionError?))
        {
            Inputs = inputs;
            OperationId = operationId;
            State = state;
            Timestamp = timestamp;
            Fee = fee;
            Hash = hash;
            Error = error;
            ErrorCode = errorCode;
            Block = block;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<TransactionInputContract> Inputs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public System.Guid OperationId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'inProgress', 'completed',
        /// 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public BroadcastedTransactionState State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fee")]
        public string Fee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'unknown',
        /// 'amountIsTooSmall', 'notEnoughtBalance'
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public TransactionExecutionError? ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "block")]
        public long Block { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
