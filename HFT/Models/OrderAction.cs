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
    /// Defines values for OrderAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderAction
    {
        [EnumMember(Value = "Buy")]
        Buy,
        [EnumMember(Value = "Sell")]
        Sell
    }
    internal static class OrderActionEnumExtension
    {
        internal static string ToSerializedValue(this OrderAction? value)
        {
            return value == null ? null : ((OrderAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OrderAction value)
        {
            switch( value )
            {
                case OrderAction.Buy:
                    return "Buy";
                case OrderAction.Sell:
                    return "Sell";
            }
            return null;
        }

        internal static OrderAction? ParseOrderAction(this string value)
        {
            switch( value )
            {
                case "Buy":
                    return OrderAction.Buy;
                case "Sell":
                    return OrderAction.Sell;
            }
            return null;
        }
    }
}
