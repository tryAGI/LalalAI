
#nullable enable

namespace LalalAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceCleanPresetsV1
    {
        /// <summary>
        /// Splitter model to use. 'auto' selects the latest available model for the selected stems.<br/>
        /// Keep 'auto' unless you have tested another model on your audio: it switches to new models as they are released.<br/>
        /// Exception: for the 'voice' stem 'auto' currently stays on lynx; cepheus, a newer model for 'voice', is available by name only.<br/>
        /// 'auto' is not listed in the SplitterType enum, but the API accepts it: send it explicitly or omit the field.<br/>
        /// Main model series, from oldest to newest: phoenix (v3) → orion (v4) → perseus (v5) → andromeda (v6).<br/>
        /// Newer models give better separation quality: for vocals, andromeda is better than perseus.<br/>
        /// Older models sometimes work better on certain recordings: for example, orion can give better results<br/>
        /// on noisy vintage recordings. Test with your own audio.<br/>
        /// lynx (v7) is a specialized lightweight model for the 'voice' stem, outside this series despite its higher version number.<br/>
        /// cepheus is another specialized model for the 'voice' stem.<br/>
        /// Its results can differ noticeably from lynx: compare both models on your recordings before switching.<br/>
        /// lyra is a separate model for the 'music' stem.<br/>
        /// Default Value: auto
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
        /// Stem to extract. Only 'voice' stem is supported.<br/>
        /// Example: voice
        /// </summary>
        /// <default>"voice"</default>
        /// <example>voice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem")]
        public string Stem { get; set; } = "voice";

        /// <summary>
        /// Works differently depending on the splitter.<br/>
        /// lynx, andromeda and phoenix: 0 (Mild) and 1 (Normal) preserve the original voice volume;<br/>
        /// 2 (Aggressive) compresses and normalizes the voice to make its quiet parts louder.<br/>
        /// cepheus, perseus and orion: 0 (Mild) preserves more voice detail, but may keep some background noise;<br/>
        /// 1 (Normal) removes noise more strictly, but some of the voice may go to the noise track;<br/>
        /// 2 (Aggressive) is the same as 1, plus compression and normalization of the voice.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_cancelling_level")]
        public int? NoiseCancellingLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCleanPresetsV1" /> class.
        /// </summary>
        /// <param name="splitter">
        /// Splitter model to use. 'auto' selects the latest available model for the selected stems.<br/>
        /// Keep 'auto' unless you have tested another model on your audio: it switches to new models as they are released.<br/>
        /// Exception: for the 'voice' stem 'auto' currently stays on lynx; cepheus, a newer model for 'voice', is available by name only.<br/>
        /// 'auto' is not listed in the SplitterType enum, but the API accepts it: send it explicitly or omit the field.<br/>
        /// Main model series, from oldest to newest: phoenix (v3) → orion (v4) → perseus (v5) → andromeda (v6).<br/>
        /// Newer models give better separation quality: for vocals, andromeda is better than perseus.<br/>
        /// Older models sometimes work better on certain recordings: for example, orion can give better results<br/>
        /// on noisy vintage recordings. Test with your own audio.<br/>
        /// lynx (v7) is a specialized lightweight model for the 'voice' stem, outside this series despite its higher version number.<br/>
        /// cepheus is another specialized model for the 'voice' stem.<br/>
        /// Its results can differ noticeably from lynx: compare both models on your recordings before switching.<br/>
        /// lyra is a separate model for the 'music' stem.<br/>
        /// Default Value: auto
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
        /// <param name="noiseCancellingLevel">
        /// Works differently depending on the splitter.<br/>
        /// lynx, andromeda and phoenix: 0 (Mild) and 1 (Normal) preserve the original voice volume;<br/>
        /// 2 (Aggressive) compresses and normalizes the voice to make its quiet parts louder.<br/>
        /// cepheus, perseus and orion: 0 (Mild) preserves more voice detail, but may keep some background noise;<br/>
        /// 1 (Normal) removes noise more strictly, but some of the voice may go to the noise track;<br/>
        /// 2 (Aggressive) is the same as 1, plus compression and normalization of the voice.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="stem">
        /// Stem to extract. Only 'voice' stem is supported.<br/>
        /// Example: voice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCleanPresetsV1(
            global::LalalAI.SplitterType? splitter,
            bool? dereverbEnabled,
            global::LalalAI.EncoderFormat? encoderFormat,
            int? noiseCancellingLevel,
            string stem = "voice")
        {
            this.Splitter = splitter;
            this.DereverbEnabled = dereverbEnabled;
            this.EncoderFormat = encoderFormat;
            this.Stem = stem;
            this.NoiseCancellingLevel = noiseCancellingLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCleanPresetsV1" /> class.
        /// </summary>
        public VoiceCleanPresetsV1()
        {
        }

    }
}