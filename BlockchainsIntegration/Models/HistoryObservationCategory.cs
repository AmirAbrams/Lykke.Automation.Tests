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
    /// Defines values for HistoryObservationCategory.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HistoryObservationCategory
    {
        [EnumMember(Value = "from")]
        From,
        [EnumMember(Value = "to")]
        To
    }
    internal static class HistoryObservationCategoryEnumExtension
    {
        internal static string ToSerializedValue(this HistoryObservationCategory? value)
        {
            return value == null ? null : ((HistoryObservationCategory)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this HistoryObservationCategory value)
        {
            switch( value )
            {
                case HistoryObservationCategory.From:
                    return "from";
                case HistoryObservationCategory.To:
                    return "to";
            }
            return null;
        }

        internal static HistoryObservationCategory? ParseHistoryObservationCategory(this string value)
        {
            switch( value )
            {
                case "from":
                    return HistoryObservationCategory.From;
                case "to":
                    return HistoryObservationCategory.To;
            }
            return null;
        }
    }
}
