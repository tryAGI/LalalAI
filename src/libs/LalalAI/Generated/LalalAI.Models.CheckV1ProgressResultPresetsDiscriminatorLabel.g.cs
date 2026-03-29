
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckV1ProgressResultPresetsDiscriminatorLabel
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
    public static class CheckV1ProgressResultPresetsDiscriminatorLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckV1ProgressResultPresetsDiscriminatorLabel value)
        {
            return value switch
            {
                CheckV1ProgressResultPresetsDiscriminatorLabel.Demuser => "demuser",
                CheckV1ProgressResultPresetsDiscriminatorLabel.Multistem => "multistem",
                CheckV1ProgressResultPresetsDiscriminatorLabel.StemSeparator => "stem_separator",
                CheckV1ProgressResultPresetsDiscriminatorLabel.VoiceClean => "voice_clean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckV1ProgressResultPresetsDiscriminatorLabel? ToEnum(string value)
        {
            return value switch
            {
                "demuser" => CheckV1ProgressResultPresetsDiscriminatorLabel.Demuser,
                "multistem" => CheckV1ProgressResultPresetsDiscriminatorLabel.Multistem,
                "stem_separator" => CheckV1ProgressResultPresetsDiscriminatorLabel.StemSeparator,
                "voice_clean" => CheckV1ProgressResultPresetsDiscriminatorLabel.VoiceClean,
                _ => null,
            };
        }
    }
}