
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DemuserSplitterPresetsV1
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
        /// Stem to extract. Only 'music' stem is supported.<br/>
        /// Example: music
        /// </summary>
        /// <default>"music"</default>
        /// <example>music</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem")]
        public string Stem { get; set; } = "music";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DemuserSplitterPresetsV1" /> class.
        /// </summary>
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
        /// <param name="stem">
        /// Stem to extract. Only 'music' stem is supported.<br/>
        /// Example: music
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DemuserSplitterPresetsV1(
            global::LalalAI.SplitterType? splitter,
            bool? dereverbEnabled,
            global::LalalAI.EncoderFormat? encoderFormat,
            string stem = "music")
        {
            this.Splitter = splitter;
            this.DereverbEnabled = dereverbEnabled;
            this.EncoderFormat = encoderFormat;
            this.Stem = stem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DemuserSplitterPresetsV1" /> class.
        /// </summary>
        public DemuserSplitterPresetsV1()
        {
        }
    }
}