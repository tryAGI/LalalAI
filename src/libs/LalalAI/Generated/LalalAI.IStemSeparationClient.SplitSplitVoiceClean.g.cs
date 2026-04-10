#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Clean voice from background noise<br/>
        ///     Typical usage case - is voice with background noise.<br/>
        ///     Voice clean will separate clean voice (stem) and noise (back).<br/>
        ///     Result of /check/ includes 2 tracks:<br/>
        ///     - stem:{"type":"stem", "label":"voice", "url":"..."}<br/>
        ///     - back:{"type":"back", "label":"no_voice", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitVoiceCleanAsync(

            global::LalalAI.VoiceCleanSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background noise<br/>
        ///     Typical usage case - is voice with background noise.<br/>
        ///     Voice clean will separate clean voice (stem) and noise (back).<br/>
        ///     Result of /check/ includes 2 tracks:<br/>
        ///     - stem:{"type":"stem", "label":"voice", "url":"..."}<br/>
        ///     - back:{"type":"back", "label":"no_voice", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file to be processed.<br/>
        /// Example: 2fe8f214-1771-4900-9e7e-570f823bd359
        /// </param>
        /// <param name="presets"></param>
        /// <param name="idempotencyKey">
        /// Unique uuid4 key to ensure idempotent requests.<br/>
        /// Prevents duplicate task execution with the same parameters.<br/>
        /// Can be reused until the task starts. Once processing begins, reusing this key will return an error.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitVoiceCleanAsync(
            string sourceId,
            global::LalalAI.VoiceCleanPresetsV1 presets,
            string? idempotencyKey = default,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}