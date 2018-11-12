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
    /// Defines values for HistoryState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HistoryState
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Finished")]
        Finished,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class HistoryStateEnumExtension
    {
        internal static string ToSerializedValue(this HistoryState? value)
        {
            return value == null ? null : ((HistoryState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this HistoryState value)
        {
            switch( value )
            {
                case HistoryState.None:
                    return "None";
                case HistoryState.InProgress:
                    return "InProgress";
                case HistoryState.Finished:
                    return "Finished";
                case HistoryState.Canceled:
                    return "Canceled";
                case HistoryState.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static HistoryState? ParseHistoryState(this string value)
        {
            switch( value )
            {
                case "None":
                    return HistoryState.None;
                case "InProgress":
                    return HistoryState.InProgress;
                case "Finished":
                    return HistoryState.Finished;
                case "Canceled":
                    return HistoryState.Canceled;
                case "Failed":
                    return HistoryState.Failed;
            }
            return null;
        }
    }
}