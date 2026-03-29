
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceChangePresetsV1
    {
        /// <summary>
        /// ID of the voice pack to be used for voice conversion.<br/>
        /// Could be one of the legal packs, provided by us.<br/>
        /// Could be a custom voice pack from voice cloner, trained by the user(see /voice_packs/list/).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_pack_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoicePackId { get; set; }

        /// <summary>
        /// Float value, changing intensity in range from 0.0 to 1.0<br/>
        /// 0.0 preserves the source file accent and 1.0 applies the voice pack accent.<br/>
        /// Default Value: 1F<br/>
        /// Example: 0.33F
        /// </summary>
        /// <example>0.33F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public double? Accent { get; set; }

        /// <summary>
        /// Tonality reference for voice conversion.<br/>
        /// Default Value: source_file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tonality_reference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.TonalityReferenceJsonConverter))]
        public global::LalalAI.TonalityReference? TonalityReference { get; set; }

        /// <summary>
        /// Enabling dereverb removes echo from the audio for clarity, which may slightly alter the voice.<br/>
        /// Disabling dereverb preserves the natural echo of the recording for authenticity.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangePresetsV1" /> class.
        /// </summary>
        /// <param name="voicePackId">
        /// ID of the voice pack to be used for voice conversion.<br/>
        /// Could be one of the legal packs, provided by us.<br/>
        /// Could be a custom voice pack from voice cloner, trained by the user(see /voice_packs/list/).
        /// </param>
        /// <param name="accent">
        /// Float value, changing intensity in range from 0.0 to 1.0<br/>
        /// 0.0 preserves the source file accent and 1.0 applies the voice pack accent.<br/>
        /// Default Value: 1F<br/>
        /// Example: 0.33F
        /// </param>
        /// <param name="tonalityReference">
        /// Tonality reference for voice conversion.<br/>
        /// Default Value: source_file
        /// </param>
        /// <param name="dereverbEnabled">
        /// Enabling dereverb removes echo from the audio for clarity, which may slightly alter the voice.<br/>
        /// Disabling dereverb preserves the natural echo of the recording for authenticity.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderFormat">
        /// Format for output audio. If None - convert to source file format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceChangePresetsV1(
            string voicePackId,
            double? accent,
            global::LalalAI.TonalityReference? tonalityReference,
            bool? dereverbEnabled,
            global::LalalAI.EncoderFormat? encoderFormat)
        {
            this.VoicePackId = voicePackId ?? throw new global::System.ArgumentNullException(nameof(voicePackId));
            this.Accent = accent;
            this.TonalityReference = tonalityReference;
            this.DereverbEnabled = dereverbEnabled;
            this.EncoderFormat = encoderFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangePresetsV1" /> class.
        /// </summary>
        public VoiceChangePresetsV1()
        {
        }
    }
}