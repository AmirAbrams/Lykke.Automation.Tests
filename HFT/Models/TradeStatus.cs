// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TradeStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TradeStatus
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Finished")]
        Finished,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class TradeStatusEnumExtension
    {
        internal static string ToSerializedValue(this TradeStatus? value)
        {
            return value == null ? null : ((TradeStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TradeStatus value)
        {
            switch( value )
            {
                case TradeStatus.Unknown:
                    return "Unknown";
                case TradeStatus.InProgress:
                    return "InProgress";
                case TradeStatus.Finished:
                    return "Finished";
                case TradeStatus.Canceled:
                    return "Canceled";
                case TradeStatus.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static TradeStatus? ParseTradeStatus(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return TradeStatus.Unknown;
                case "InProgress":
                    return TradeStatus.InProgress;
                case "Finished":
                    return TradeStatus.Finished;
                case "Canceled":
                    return TradeStatus.Canceled;
                case "Failed":
                    return TradeStatus.Failed;
            }
            return null;
        }
    }
}
