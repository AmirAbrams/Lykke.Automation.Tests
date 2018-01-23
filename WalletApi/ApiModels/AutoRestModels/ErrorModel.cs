// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        public ErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        /// <param name="code">Possible values include: 'InvalidInputField',
        /// 'InconsistentData', 'NotAuthenticated',
        /// 'InvalidUsernameOrPassword', 'AssetNotFound', 'NotEnoughFunds',
        /// 'VersionNotSupported', 'RuntimeProblem', 'WrongConfirmationCode',
        /// 'BackupWarning', 'BackupRequired', 'MaintananceMode', 'NoData',
        /// 'ShouldOpenNewChannel', 'ShouldProvideNewTempPubKey',
        /// 'ShouldProcesOffchainRequest', 'NoOffchainLiquidity',
        /// 'GeneralError', 'AddressShouldBeGenerated', 'ExpiredAccessToken',
        /// 'BadAccessToken', 'NoEncodedMainKey',
        /// 'PreviousTransactionsWereNotCompleted', 'LimitationCheckFailed',
        /// 'TransactionAlreadyExists', 'UnknownTrustedTransferDirection',
        /// 'InvalidGuidValue', 'BadTempAccessToken', 'BadRequest',
        /// 'NotEnoughGas'</param>
        public ErrorModel(string code = default(string), string field = default(string), string message = default(string))
        {
            Code = code;
            Field = field;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'InvalidInputField',
        /// 'InconsistentData', 'NotAuthenticated',
        /// 'InvalidUsernameOrPassword', 'AssetNotFound', 'NotEnoughFunds',
        /// 'VersionNotSupported', 'RuntimeProblem', 'WrongConfirmationCode',
        /// 'BackupWarning', 'BackupRequired', 'MaintananceMode', 'NoData',
        /// 'ShouldOpenNewChannel', 'ShouldProvideNewTempPubKey',
        /// 'ShouldProcesOffchainRequest', 'NoOffchainLiquidity',
        /// 'GeneralError', 'AddressShouldBeGenerated', 'ExpiredAccessToken',
        /// 'BadAccessToken', 'NoEncodedMainKey',
        /// 'PreviousTransactionsWereNotCompleted', 'LimitationCheckFailed',
        /// 'TransactionAlreadyExists', 'UnknownTrustedTransferDirection',
        /// 'InvalidGuidValue', 'BadTempAccessToken', 'BadRequest',
        /// 'NotEnoughGas'
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Field")]
        public string Field { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
