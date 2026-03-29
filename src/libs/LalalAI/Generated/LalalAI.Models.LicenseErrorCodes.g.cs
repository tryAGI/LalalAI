
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum LicenseErrorCodes
    {
        /// <summary>
        /// 
        /// </summary>
        BatchNotAvaliable,
        /// <summary>
        /// 
        /// </summary>
        ExceededDuration,
        /// <summary>
        /// 
        /// </summary>
        ExceededSize,
        /// <summary>
        /// 
        /// </summary>
        MaxDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LicenseErrorCodesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseErrorCodes value)
        {
            return value switch
            {
                LicenseErrorCodes.BatchNotAvaliable => "batch_not_avaliable",
                LicenseErrorCodes.ExceededDuration => "exceeded_duration",
                LicenseErrorCodes.ExceededSize => "exceeded_size",
                LicenseErrorCodes.MaxDuration => "max_duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseErrorCodes? ToEnum(string value)
        {
            return value switch
            {
                "batch_not_avaliable" => LicenseErrorCodes.BatchNotAvaliable,
                "exceeded_duration" => LicenseErrorCodes.ExceededDuration,
                "exceeded_size" => LicenseErrorCodes.ExceededSize,
                "max_duration" => LicenseErrorCodes.MaxDuration,
                _ => null,
            };
        }
    }
}