// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.ApiV2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OperationResult.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationResult
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Ok")]
        Ok,
        [EnumMember(Value = "InvalidInputParameters")]
        InvalidInputParameters,
        [EnumMember(Value = "NoLiquidity")]
        NoLiquidity
    }
    internal static class OperationResultEnumExtension
    {
        internal static string ToSerializedValue(this OperationResult? value)
        {
            return value == null ? null : ((OperationResult)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OperationResult value)
        {
            switch( value )
            {
                case OperationResult.Unknown:
                    return "Unknown";
                case OperationResult.Ok:
                    return "Ok";
                case OperationResult.InvalidInputParameters:
                    return "InvalidInputParameters";
                case OperationResult.NoLiquidity:
                    return "NoLiquidity";
            }
            return null;
        }

        internal static OperationResult? ParseOperationResult(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return OperationResult.Unknown;
                case "Ok":
                    return OperationResult.Ok;
                case "InvalidInputParameters":
                    return OperationResult.InvalidInputParameters;
                case "NoLiquidity":
                    return OperationResult.NoLiquidity;
            }
            return null;
        }
    }
}
