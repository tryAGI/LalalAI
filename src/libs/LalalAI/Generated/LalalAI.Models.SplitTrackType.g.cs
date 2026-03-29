
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SplitTrackType
    {
        /// <summary>
        /// 
        /// </summary>
        Back,
        /// <summary>
        /// 
        /// </summary>
        Stem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitTrackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitTrackType value)
        {
            return value switch
            {
                SplitTrackType.Back => "back",
                SplitTrackType.Stem => "stem",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitTrackType? ToEnum(string value)
        {
            return value switch
            {
                "back" => SplitTrackType.Back,
                "stem" => SplitTrackType.Stem,
                _ => null,
            };
        }
    }
}