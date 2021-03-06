// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.ApiV2.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for starting recovery process.
    /// </summary>
    public partial class RecoveryStartResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryStartResponseModel class.
        /// </summary>
        public RecoveryStartResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryStartResponseModel class.
        /// </summary>
        /// <param name="stateToken">JWE token containing current state of
        /// recovery process.</param>
        public RecoveryStartResponseModel(string stateToken)
        {
            StateToken = stateToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets JWE token containing current state of recovery
        /// process.
        /// </summary>
        [JsonProperty(PropertyName = "StateToken")]
        public string StateToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StateToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StateToken");
            }
        }
    }
}
