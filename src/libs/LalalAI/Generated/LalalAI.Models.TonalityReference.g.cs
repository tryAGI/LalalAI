
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TonalityReference
    {
        /// <summary>
        /// 
        /// </summary>
        SourceFile,
        /// <summary>
        /// 
        /// </summary>
        VoicePack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TonalityReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TonalityReference value)
        {
            return value switch
            {
                TonalityReference.SourceFile => "source_file",
                TonalityReference.VoicePack => "voice_pack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TonalityReference? ToEnum(string value)
        {
            return value switch
            {
                "source_file" => TonalityReference.SourceFile,
                "voice_pack" => TonalityReference.VoicePack,
                _ => null,
            };
        }
    }
}