// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResponseModelGetBaseAssetsRespModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResponseModelGetBaseAssetsRespModel class.
        /// </summary>
        public ResponseModelGetBaseAssetsRespModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResponseModelGetBaseAssetsRespModel class.
        /// </summary>
        public ResponseModelGetBaseAssetsRespModel(GetBaseAssetsRespModel result = default(GetBaseAssetsRespModel), ErrorModel error = default(ErrorModel))
        {
            Result = result;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public GetBaseAssetsRespModel Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public ErrorModel Error { get; set; }

    }
}
