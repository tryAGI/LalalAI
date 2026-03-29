
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MultistemSplitterPresetsV1StemListItem
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
        /// 
        /// </summary>
        ElectricGuitar,
        /// <summary>
        /// 
        /// </summary>
        Piano,
        /// <summary>
        /// 
        /// </summary>
        Vocals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultistemSplitterPresetsV1StemListItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultistemSplitterPresetsV1StemListItem value)
        {
            return value switch
            {
                MultistemSplitterPresetsV1StemListItem.AcousticGuitar => "acoustic_guitar",
                MultistemSplitterPresetsV1StemListItem.Bass => "bass",
                MultistemSplitterPresetsV1StemListItem.Drum => "drum",
                MultistemSplitterPresetsV1StemListItem.ElectricGuitar => "electric_guitar",
                MultistemSplitterPresetsV1StemListItem.Piano => "piano",
                MultistemSplitterPresetsV1StemListItem.Vocals => "vocals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultistemSplitterPresetsV1StemListItem? ToEnum(string value)
        {
            return value switch
            {
                "acoustic_guitar" => MultistemSplitterPresetsV1StemListItem.AcousticGuitar,
                "bass" => MultistemSplitterPresetsV1StemListItem.Bass,
                "drum" => MultistemSplitterPresetsV1StemListItem.Drum,
                "electric_guitar" => MultistemSplitterPresetsV1StemListItem.ElectricGuitar,
                "piano" => MultistemSplitterPresetsV1StemListItem.Piano,
                "vocals" => MultistemSplitterPresetsV1StemListItem.Vocals,
                _ => null,
            };
        }
    }
}