
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SplitterType
    {
        /// <summary>
        /// 
        /// </summary>
        Andromeda,
        /// <summary>
        /// 
        /// </summary>
        Lyra,
        /// <summary>
        /// 
        /// </summary>
        Orion,
        /// <summary>
        /// 
        /// </summary>
        Perseus,
        /// <summary>
        /// 
        /// </summary>
        Phoenix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitterType value)
        {
            return value switch
            {
                SplitterType.Andromeda => "andromeda",
                SplitterType.Lyra => "lyra",
                SplitterType.Orion => "orion",
                SplitterType.Perseus => "perseus",
                SplitterType.Phoenix => "phoenix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitterType? ToEnum(string value)
        {
            return value switch
            {
                "andromeda" => SplitterType.Andromeda,
                "lyra" => SplitterType.Lyra,
                "orion" => SplitterType.Orion,
                "perseus" => SplitterType.Perseus,
                "phoenix" => SplitterType.Phoenix,
                _ => null,
            };
        }
    }
}