// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.ClientAccount.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MyLykkeSettings
    {
        /// <summary>
        /// Initializes a new instance of the MyLykkeSettings class.
        /// </summary>
        public MyLykkeSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MyLykkeSettings class.
        /// </summary>
        public MyLykkeSettings(bool? myLykkeEnabled = default(bool?))
        {
            MyLykkeEnabled = myLykkeEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MyLykkeEnabled")]
        public bool? MyLykkeEnabled { get; set; }

    }
}
