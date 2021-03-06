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

    public partial class FxPaygatePaymentUrlRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the FxPaygatePaymentUrlRequestModel
        /// class.
        /// </summary>
        public FxPaygatePaymentUrlRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FxPaygatePaymentUrlRequestModel
        /// class.
        /// </summary>
        /// <param name="amount">Amount in currency defined by
        /// CurrencyCode</param>
        public FxPaygatePaymentUrlRequestModel(double amount, string assetId, string walletId, string firstName, string lastName, string city, string zip, string address, string country, string email, string phone, string okUrl, string failUrl, string cancelUrl)
        {
            Amount = amount;
            AssetId = assetId;
            WalletId = walletId;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Zip = zip;
            Address = address;
            Country = country;
            Email = email;
            Phone = phone;
            OkUrl = okUrl;
            FailUrl = failUrl;
            CancelUrl = cancelUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets amount in currency defined by CurrencyCode
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WalletId")]
        public string WalletId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Zip")]
        public string Zip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OkUrl")]
        public string OkUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FailUrl")]
        public string FailUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CancelUrl")]
        public string CancelUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AssetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssetId");
            }
            if (WalletId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WalletId");
            }
            if (FirstName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FirstName");
            }
            if (LastName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastName");
            }
            if (City == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "City");
            }
            if (Zip == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Zip");
            }
            if (Address == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Address");
            }
            if (Country == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Country");
            }
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (Phone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Phone");
            }
            if (OkUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OkUrl");
            }
            if (FailUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FailUrl");
            }
            if (CancelUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CancelUrl");
            }
        }
    }
}
