
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckV1ErrorResultPresetsDiscriminatorLabel
    {
        /// <summary>
        /// 
        /// </summary>
        Demuser,
        /// <summary>
        /// 
        /// </summary>
        Multistem,
        /// <summary>
        /// 
        /// </summary>
        StemSeparator,
        /// <summary>
        /// 
        /// </summary>
        VoiceClean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckV1ErrorResultPresetsDiscriminatorLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckV1ErrorResultPresetsDiscriminatorLabel value)
        {
            return value switch
            {
                CheckV1ErrorResultPresetsDiscriminatorLabel.Demuser => "demuser",
                CheckV1ErrorResultPresetsDiscriminatorLabel.Multistem => "multistem",
                CheckV1ErrorResultPresetsDiscriminatorLabel.StemSeparator => "stem_separator",
                CheckV1ErrorResultPresetsDiscriminatorLabel.VoiceClean => "voice_clean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckV1ErrorResultPresetsDiscriminatorLabel? ToEnum(string value)
        {
            return value switch
            {
                "demuser" => CheckV1ErrorResultPresetsDiscriminatorLabel.Demuser,
                "multistem" => CheckV1ErrorResultPresetsDiscriminatorLabel.Multistem,
                "stem_separator" => CheckV1ErrorResultPresetsDiscriminatorLabel.StemSeparator,
                "voice_clean" => CheckV1ErrorResultPresetsDiscriminatorLabel.VoiceClean,
                _ => null,
            };
        }
    }
}