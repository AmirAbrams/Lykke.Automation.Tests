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
    /// Response for uploading recovery selfie image.
    /// </summary>
    public partial class RecoveryUploadFileResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryUploadFileResponseModel
        /// class.
        /// </summary>
        public RecoveryUploadFileResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryUploadFileResponseModel
        /// class.
        /// </summary>
        /// <param name="fileId">Id of uploaded image.</param>
        public RecoveryUploadFileResponseModel(string fileId)
        {
            FileId = fileId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of uploaded image.
        /// </summary>
        [JsonProperty(PropertyName = "FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileId");
            }
        }
    }
}
