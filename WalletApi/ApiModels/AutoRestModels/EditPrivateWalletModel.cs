// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EditPrivateWalletModel
    {
        /// <summary>
        /// Initializes a new instance of the EditPrivateWalletModel class.
        /// </summary>
        public EditPrivateWalletModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EditPrivateWalletModel class.
        /// </summary>
        public EditPrivateWalletModel(string address = default(string), string name = default(string))
        {
            Address = address;
            Name = name;
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
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}
