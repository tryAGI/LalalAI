
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckV1Response
    {
        /// <summary>
        /// Mapping of task IDs to their respective status and details.<br/>
        /// Example: {"2fe8f214-1771-4900-9e7e-570f823bd359":{"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"result":{"duration":16,"tracks":[{"label":"vocals","type":"stem","url":"http://d.lalal.ai/2fe8f214-1771-4900-9e7e-570f823bd359/abcd1234/vocals"},{"label":"no_vocals","type":"back","url":"http://d.lalal.ai/2fe8f214-1771-4900-9e7e-570f823bd359/abcd1234/no_vocals"}]},"source_id":"ecb6c2c5-6263-48b9-80c9-f54248e30892","status":"success"},"8cad7e3d-a5a3-4e79-9463-59cd4da16977":{"error":"[\u0027The file has not been uploaded properly or has already been deleted. Please upload it again.\u0027]","status":"server_error"},"cb443802-e5be-44c2-bdd8-cb1d343c7d25":{"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"progress":42,"source_id":"9dec9880-12ad-4a7e-89af-c50c9380ec14","status":"progress"},"f4978ff5-8e0b-4fdc-913a-e350eeb16d31":{"error":{"code":"inference_error","detail":"Unable to detect voice/vocals in the uploaded files","id":"\u003Cerror_id\u003E"},"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"source_id":"7ab9e030-c472-4281-8b08-108c3bd019bf","status":"error"}}
        /// </summary>
        /// <example>{"2fe8f214-1771-4900-9e7e-570f823bd359":{"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"result":{"duration":16,"tracks":[{"label":"vocals","type":"stem","url":"http://d.lalal.ai/2fe8f214-1771-4900-9e7e-570f823bd359/abcd1234/vocals"},{"label":"no_vocals","type":"back","url":"http://d.lalal.ai/2fe8f214-1771-4900-9e7e-570f823bd359/abcd1234/no_vocals"}]},"source_id":"ecb6c2c5-6263-48b9-80c9-f54248e30892","status":"success"},"8cad7e3d-a5a3-4e79-9463-59cd4da16977":{"error":"[\u0027The file has not been uploaded properly or has already been deleted. Please upload it again.\u0027]","status":"server_error"},"cb443802-e5be-44c2-bdd8-cb1d343c7d25":{"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"progress":42,"source_id":"9dec9880-12ad-4a7e-89af-c50c9380ec14","status":"progress"},"f4978ff5-8e0b-4fdc-913a-e350eeb16d31":{"error":{"code":"inference_error","detail":"Unable to detect voice/vocals in the uploaded files","id":"\u003Cerror_id\u003E"},"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"source_id":"7ab9e030-c472-4281-8b08-108c3bd019bf","status":"error"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1Response" /> class.
        /// </summary>
        /// <param name="result">
        /// Mapping of task IDs to their respective status and details.<br/>
        /// Example: {"2fe8f214-1771-4900-9e7e-570f823bd359":{"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"result":{"duration":16,"tracks":[{"label":"vocals","type":"stem","url":"http://d.lalal.ai/2fe8f214-1771-4900-9e7e-570f823bd359/abcd1234/vocals"},{"label":"no_vocals","type":"back","url":"http://d.lalal.ai/2fe8f214-1771-4900-9e7e-570f823bd359/abcd1234/no_vocals"}]},"source_id":"ecb6c2c5-6263-48b9-80c9-f54248e30892","status":"success"},"8cad7e3d-a5a3-4e79-9463-59cd4da16977":{"error":"[\u0027The file has not been uploaded properly or has already been deleted. Please upload it again.\u0027]","status":"server_error"},"cb443802-e5be-44c2-bdd8-cb1d343c7d25":{"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"progress":42,"source_id":"9dec9880-12ad-4a7e-89af-c50c9380ec14","status":"progress"},"f4978ff5-8e0b-4fdc-913a-e350eeb16d31":{"error":{"code":"inference_error","detail":"Unable to detect voice/vocals in the uploaded files","id":"\u003Cerror_id\u003E"},"presets":{"dereverb_enabled":false,"encoder_format":null,"enhanced_processing_enabled":false,"label":"enhanced","multivocal":null,"splitter":"perseus","stem":"vocals","task_type":"split"},"source_id":"7ab9e030-c472-4281-8b08-108c3bd019bf","status":"error"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckV1Response(
            object result)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1Response" /> class.
        /// </summary>
        public CheckV1Response()
        {
        }
    }
}