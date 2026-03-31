
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StemSeparatorSplitterPresetsV1
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
        /// Only for {'voice', 'vocals'} stems.<br/>
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
        /// Stem to extract. ['synthesizer', 'strings', 'wind'] are available only phoenix splitter.<br/>
        /// Example: vocals
        /// </summary>
        /// <example>vocals</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.StemSeparatorSplitterPresetsV1StemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LalalAI.StemSeparatorSplitterPresetsV1Stem Stem { get; set; }

        /// <summary>
        /// Use parameter 'lead_back' and receive both lead and backing vocals as separate stems vocals@0 and vocals@1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivocal")]
        public string? Multivocal { get; set; }

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
        /// Initializes a new instance of the <see cref="StemSeparatorSplitterPresetsV1" /> class.
        /// </summary>
        /// <param name="stem">
        /// Stem to extract. ['synthesizer', 'strings', 'wind'] are available only phoenix splitter.<br/>
        /// Example: vocals
        /// </param>
        /// <param name="splitter">
        /// Splitter model to use. If None - the latest available model for the selected stems will be used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dereverbEnabled">
        /// Enabling dereverb removes echo from the audio for clarity, which may slightly alter the voice.<br/>
        /// Disabling dereverb preserves the natural echo of the recording for authenticity.<br/>
        /// Only for {'voice', 'vocals'} stems.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderFormat">
        /// Format for output audio. If None - convert to source file format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="multivocal">
        /// Use parameter 'lead_back' and receive both lead and backing vocals as separate stems vocals@0 and vocals@1<br/>
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
        public StemSeparatorSplitterPresetsV1(
            global::LalalAI.StemSeparatorSplitterPresetsV1Stem stem,
            global::LalalAI.SplitterType? splitter,
            bool? dereverbEnabled,
            global::LalalAI.EncoderFormat? encoderFormat,
            string? multivocal,
            global::LalalAI.ExtractionLevel? extractionLevel)
        {
            this.Splitter = splitter;
            this.DereverbEnabled = dereverbEnabled;
            this.EncoderFormat = encoderFormat;
            this.Stem = stem;
            this.Multivocal = multivocal;
            this.ExtractionLevel = extractionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StemSeparatorSplitterPresetsV1" /> class.
        /// </summary>
        public StemSeparatorSplitterPresetsV1()
        {
        }
    }
}