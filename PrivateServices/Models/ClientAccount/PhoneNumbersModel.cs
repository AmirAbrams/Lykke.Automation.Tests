// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.ClientAccount.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PhoneNumbersModel
    {
        /// <summary>
        /// Initializes a new instance of the PhoneNumbersModel class.
        /// </summary>
        public PhoneNumbersModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhoneNumbersModel class.
        /// </summary>
        public PhoneNumbersModel(IList<string> values = default(IList<string>))
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IList<string> Values { get; set; }

    }
}
