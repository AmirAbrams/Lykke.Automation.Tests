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

    public partial class ListOfAssetSettings
    {
        /// <summary>
        /// Initializes a new instance of the ListOfAssetSettings class.
        /// </summary>
        public ListOfAssetSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListOfAssetSettings class.
        /// </summary>
        public ListOfAssetSettings(IList<AssetSettings> items = default(IList<AssetSettings>))
        {
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Items")]
        public IList<AssetSettings> Items { get; set; }

    }
}
