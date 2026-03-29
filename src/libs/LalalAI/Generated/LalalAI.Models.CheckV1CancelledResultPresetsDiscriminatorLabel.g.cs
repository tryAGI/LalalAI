
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckV1CancelledResultPresetsDiscriminatorLabel
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
    public static class CheckV1CancelledResultPresetsDiscriminatorLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckV1CancelledResultPresetsDiscriminatorLabel value)
        {
            return value switch
            {
                CheckV1CancelledResultPresetsDiscriminatorLabel.Demuser => "demuser",
                CheckV1CancelledResultPresetsDiscriminatorLabel.Multistem => "multistem",
                CheckV1CancelledResultPresetsDiscriminatorLabel.StemSeparator => "stem_separator",
                CheckV1CancelledResultPresetsDiscriminatorLabel.VoiceClean => "voice_clean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckV1CancelledResultPresetsDiscriminatorLabel? ToEnum(string value)
        {
            return value switch
            {
                "demuser" => CheckV1CancelledResultPresetsDiscriminatorLabel.Demuser,
                "multistem" => CheckV1CancelledResultPresetsDiscriminatorLabel.Multistem,
                "stem_separator" => CheckV1CancelledResultPresetsDiscriminatorLabel.StemSeparator,
                "voice_clean" => CheckV1CancelledResultPresetsDiscriminatorLabel.VoiceClean,
                _ => null,
            };
        }
    }
}