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

    public partial class CryptoDepositAddressRespModel
    {
        /// <summary>
        /// Initializes a new instance of the CryptoDepositAddressRespModel
        /// class.
        /// </summary>
        public CryptoDepositAddressRespModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CryptoDepositAddressRespModel
        /// class.
        /// </summary>
        public CryptoDepositAddressRespModel(string address, string baseAddress, string addressExtension)
        {
            Address = address;
            BaseAddress = baseAddress;
            AddressExtension = addressExtension;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BaseAddress")]
        public string BaseAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AddressExtension")]
        public string AddressExtension { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Address == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Address");
            }
            if (BaseAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BaseAddress");
            }
            if (AddressExtension == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressExtension");
            }
        }
    }
}
