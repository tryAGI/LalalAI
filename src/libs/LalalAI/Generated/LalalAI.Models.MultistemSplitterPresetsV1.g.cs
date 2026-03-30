
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultistemSplitterPresetsV1
    {
        /// <summary>
        /// Splitter model to use. If None - the latest available model for the selected stems will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splitter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.SplitterTypeJsonConverter))]
        public global::LalalAI.SplitterType? Splitter { get; set; }

        /// <summary>
        /// Enabling dereverb removes echo from the audio for clarity, which may slightly alter the voice.<br/>
        /// Disabling dereverb preserves the natural echo of the recording for authenticity.<br/>
        /// Only for {'vocals', 'voice'} stems.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dereverb_enabled")]
        public bool? DereverbEnabled { get; set; }

        /// <summary>
        /// Format for output audio. If None - convert to source file format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_format")]
        public global::LalalAI.EncoderFormat? EncoderFormat { get; set; }

        /// <summary>
        /// List of stems to extract. Any subset of supported stems is possible.<br/>
        /// Example: [vocals, drum, piano, bass, electric_guitar, acoustic_guitar]
        /// </summary>
        /// <example>[vocals, drum, piano, bass, electric_guitar, acoustic_guitar]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem_list")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LalalAI.MultistemSplitterPresetsV1StemListItem> StemList { get; set; }

        /// <summary>
        /// Clear Cut: minimizes cross-bleeding between stems, resulting in a cleaner output, but may suppress finer details.<br/>
        /// Deep Extraction: captures more intricate details but increases the risk of cross-bleeding, which may lead to some overlap between stems.<br/>
        /// Andromeda splitter is not affected by this parameter and has its own fixed extraction behavior.<br/>
        /// Default Value: deep_extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.ExtractionLevelJsonConverter))]
        public global::LalalAI.ExtractionLevel? ExtractionLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultistemSplitterPresetsV1" /> class.
        /// </summary>
        /// <param name="stemList">
        /// List of stems to extract. Any subset of supported stems is possible.<br/>
        /// Example: [vocals, drum, piano, bass, electric_guitar, acoustic_guitar]
        /// </param>
        /// <param name="splitter">
        /// Splitter model to use. If None - the latest available model for the selected stems will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dereverbEnabled">
        /// Enabling dereverb removes echo from the audio for clarity, which may slightly alter the voice.<br/>
        /// Disabling dereverb preserves the natural echo of the recording for authenticity.<br/>
        /// Only for {'vocals', 'voice'} stems.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderFormat">
        /// Format for output audio. If None - convert to source file format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="extractionLevel">
        /// Clear Cut: minimizes cross-bleeding between stems, resulting in a cleaner output, but may suppress finer details.<br/>
        /// Deep Extraction: captures more intricate details but increases the risk of cross-bleeding, which may lead to some overlap between stems.<br/>
        /// Andromeda splitter is not affected by this parameter and has its own fixed extraction behavior.<br/>
        /// Default Value: deep_extraction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultistemSplitterPresetsV1(
            global::System.Collections.Generic.IList<global::LalalAI.MultistemSplitterPresetsV1StemListItem> stemList,
            global::LalalAI.SplitterType? splitter,
            bool? dereverbEnabled,
            global::LalalAI.EncoderFormat? encoderFormat,
            global::LalalAI.ExtractionLevel? extractionLevel)
        {
            this.Splitter = splitter;
            this.DereverbEnabled = dereverbEnabled;
            this.EncoderFormat = encoderFormat;
            this.StemList = stemList ?? throw new global::System.ArgumentNullException(nameof(stemList));
            this.ExtractionLevel = extractionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultistemSplitterPresetsV1" /> class.
        /// </summary>
        public MultistemSplitterPresetsV1()
        {
        }
    }
}