
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EncoderFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EncoderFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EncoderFormat value)
        {
            return value switch
            {
                EncoderFormat.Aac => "aac",
                EncoderFormat.Flac => "flac",
                EncoderFormat.Mp3 => "mp3",
                EncoderFormat.Ogg => "ogg",
                EncoderFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EncoderFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac" => EncoderFormat.Aac,
                "flac" => EncoderFormat.Flac,
                "mp3" => EncoderFormat.Mp3,
                "ogg" => EncoderFormat.Ogg,
                "wav" => EncoderFormat.Wav,
                _ => null,
            };
        }
    }
}