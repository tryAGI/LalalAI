
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// Stem to extract.<br/>
    /// 'vocals' extracts vocals from music, typically songs. To extract speech from non-musical noise, use /split/voice_clean/.<br/>
    /// Choose the stem that best matches your task: to extract guitars of any type, use 'guitar', not 'electric_guitar',<br/>
    /// even if you expect only an electric guitar.<br/>
    /// A broader stem can work better with a newer model: even if you only want electric guitar,<br/>
    /// 'guitar' on andromeda gives better results than 'electric_guitar' on perseus,<br/>
    /// as long as there is no acoustic guitar you need to separate from it.<br/>
    /// 'guitar' is available only with andromeda. 'synthesizer', 'strings', and 'wind' are available only with phoenix.<br/>
    /// Example: vocals
    /// </summary>
    public enum StemSeparatorSplitterPresetsV1Stem
    {
        /// <summary>
        ///
        /// </summary>
        AcousticGuitar,
        /// <summary>
        ///
        /// </summary>
        Bass,
        /// <summary>
        ///
        /// </summary>
        Drum,
        /// <summary>
        /// to extract guitars of any type, use 'guitar', not 'electric_guitar',
        /// </summary>
        ElectricGuitar,
        /// <summary>
        /// to extract guitars of any type, use 'guitar', not 'electric_guitar',
        /// </summary>
        Guitar,
        /// <summary>
        ///
        /// </summary>
        Piano,
        /// <summary>
        ///
        /// </summary>
        Strings,
        /// <summary>
        ///
        /// </summary>
        Synthesizer,
        /// <summary>
        ///
        /// </summary>
        Vocals,
        /// <summary>
        ///
        /// </summary>
        Wind,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StemSeparatorSplitterPresetsV1StemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StemSeparatorSplitterPresetsV1Stem value)
        {
            return value switch
            {
                StemSeparatorSplitterPresetsV1Stem.AcousticGuitar => "acoustic_guitar",
                StemSeparatorSplitterPresetsV1Stem.Bass => "bass",
                StemSeparatorSplitterPresetsV1Stem.Drum => "drum",
                StemSeparatorSplitterPresetsV1Stem.ElectricGuitar => "electric_guitar",
                StemSeparatorSplitterPresetsV1Stem.Guitar => "guitar",
                StemSeparatorSplitterPresetsV1Stem.Piano => "piano",
                StemSeparatorSplitterPresetsV1Stem.Strings => "strings",
                StemSeparatorSplitterPresetsV1Stem.Synthesizer => "synthesizer",
                StemSeparatorSplitterPresetsV1Stem.Vocals => "vocals",
                StemSeparatorSplitterPresetsV1Stem.Wind => "wind",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StemSeparatorSplitterPresetsV1Stem? ToEnum(string value)
        {
            return value switch
            {
                "acoustic_guitar" => StemSeparatorSplitterPresetsV1Stem.AcousticGuitar,
                "bass" => StemSeparatorSplitterPresetsV1Stem.Bass,
                "drum" => StemSeparatorSplitterPresetsV1Stem.Drum,
                "electric_guitar" => StemSeparatorSplitterPresetsV1Stem.ElectricGuitar,
                "guitar" => StemSeparatorSplitterPresetsV1Stem.Guitar,
                "piano" => StemSeparatorSplitterPresetsV1Stem.Piano,
                "strings" => StemSeparatorSplitterPresetsV1Stem.Strings,
                "synthesizer" => StemSeparatorSplitterPresetsV1Stem.Synthesizer,
                "vocals" => StemSeparatorSplitterPresetsV1Stem.Vocals,
                "wind" => StemSeparatorSplitterPresetsV1Stem.Wind,
                _ => null,
            };
        }
    }
}