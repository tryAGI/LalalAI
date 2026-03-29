
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtractionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        ClearCut,
        /// <summary>
        /// 
        /// </summary>
        DeepExtraction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionLevel value)
        {
            return value switch
            {
                ExtractionLevel.ClearCut => "clear_cut",
                ExtractionLevel.DeepExtraction => "deep_extraction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionLevel? ToEnum(string value)
        {
            return value switch
            {
                "clear_cut" => ExtractionLevel.ClearCut,
                "deep_extraction" => ExtractionLevel.DeepExtraction,
                _ => null,
            };
        }
    }
}