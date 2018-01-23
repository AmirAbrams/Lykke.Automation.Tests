// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetKycStatusRespModel
    {
        /// <summary>
        /// Initializes a new instance of the GetKycStatusRespModel class.
        /// </summary>
        public GetKycStatusRespModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetKycStatusRespModel class.
        /// </summary>
        /// <param name="kycStatus">Possible values include: 'NeedToFillData',
        /// 'Pending', 'Ok', 'RestrictedArea'</param>
        public GetKycStatusRespModel(string kycStatus = default(string), ApiPersonalDataModel personalData = default(ApiPersonalDataModel))
        {
            KycStatus = kycStatus;
            PersonalData = personalData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NeedToFillData', 'Pending',
        /// 'Ok', 'RestrictedArea'
        /// </summary>
        [JsonProperty(PropertyName = "KycStatus")]
        public string KycStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PersonalData")]
        public ApiPersonalDataModel PersonalData { get; set; }

    }
}
