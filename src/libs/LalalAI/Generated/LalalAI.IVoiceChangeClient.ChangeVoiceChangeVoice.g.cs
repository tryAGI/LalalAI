#nullable enable

namespace LalalAI
{
    public partial interface IVoiceChangeClient
    {
        /// <summary>
        /// Changes voice in the audio file using voice pack<br/>
        ///     For 'voice_pack_id' parameter use 'pack_id' from /voice_packs/list/ endpoint or one of legal packs: ['ALEX_KAYE', 'STASIA_FAYE', 'NICOLAAS_HAAS', 'NIK_ZEL', 'OLIA_CHEBO', 'YVAR_DE_GROOT', 'VETRANA']<br/>
        ///     Result of /check/ includes 1 track with label 'converted_mix'.<br/>
        ///     {"label":"converted_mix", "type":"back", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.TaskResponse> ChangeVoiceChangeVoiceAsync(

            global::LalalAI.VoiceChangeParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Changes voice in the audio file using voice pack<br/>
        ///     For 'voice_pack_id' parameter use 'pack_id' from /voice_packs/list/ endpoint or one of legal packs: ['ALEX_KAYE', 'STASIA_FAYE', 'NICOLAAS_HAAS', 'NIK_ZEL', 'OLIA_CHEBO', 'YVAR_DE_GROOT', 'VETRANA']<br/>
        ///     Result of /check/ includes 1 track with label 'converted_mix'.<br/>
        ///     {"label":"converted_mix", "type":"back", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file to be processed.<br/>
        /// Example: 2fe8f214-1771-4900-9e7e-570f823bd359
        /// </param>
        /// <param name="presets">
        /// Presets for converting the source file.
        /// </param>
        /// <param name="idempotencyKey">
        /// Unique uuid4 key to ensure idempotent requests.<br/>
        /// Prevents duplicate task execution with the same parameters.<br/>
        /// Can be reused until the task starts. Once processing begins, reusing this key will return an error.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.TaskResponse> ChangeVoiceChangeVoiceAsync(
            string sourceId,
            global::LalalAI.VoiceChangePresetsV1 presets,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}