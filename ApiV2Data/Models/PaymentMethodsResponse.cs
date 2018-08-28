// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.ApiV2.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PaymentMethodsResponse
    {
        /// <summary>
        /// Initializes a new instance of the PaymentMethodsResponse class.
        /// </summary>
        public PaymentMethodsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaymentMethodsResponse class.
        /// </summary>
        public PaymentMethodsResponse(IList<PaymentMethod> paymentMethods)
        {
            PaymentMethods = paymentMethods;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentMethods")]
        public IList<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PaymentMethods == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PaymentMethods");
            }
            if (PaymentMethods != null)
            {
                foreach (var element in PaymentMethods)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
