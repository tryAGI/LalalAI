
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckV1SuccessResultPresetsDiscriminatorLabel
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
    public static class CheckV1SuccessResultPresetsDiscriminatorLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckV1SuccessResultPresetsDiscriminatorLabel value)
        {
            return value switch
            {
                CheckV1SuccessResultPresetsDiscriminatorLabel.Demuser => "demuser",
                CheckV1SuccessResultPresetsDiscriminatorLabel.Multistem => "multistem",
                CheckV1SuccessResultPresetsDiscriminatorLabel.StemSeparator => "stem_separator",
                CheckV1SuccessResultPresetsDiscriminatorLabel.VoiceClean => "voice_clean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckV1SuccessResultPresetsDiscriminatorLabel? ToEnum(string value)
        {
            return value switch
            {
                "demuser" => CheckV1SuccessResultPresetsDiscriminatorLabel.Demuser,
                "multistem" => CheckV1SuccessResultPresetsDiscriminatorLabel.Multistem,
                "stem_separator" => CheckV1SuccessResultPresetsDiscriminatorLabel.StemSeparator,
                "voice_clean" => CheckV1SuccessResultPresetsDiscriminatorLabel.VoiceClean,
                _ => null,
            };
        }
    }
}