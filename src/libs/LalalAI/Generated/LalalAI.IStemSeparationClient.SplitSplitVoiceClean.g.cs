#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Clean voice from background noise<br/>
        /// Removes background noise from speech: crowd, traffic, office and other non-musical noise.<br/>
        /// You get two files: the clean voice and the noise.<br/>
        /// For singing in a song use `/split/stem_separator/` with the `vocals` stem. For speech over music use `/split/demuser/`.<br/>
        /// The only stem is `voice`. With `splitter: auto` the request currently uses lynx, the model made for this stem.<br/>
        /// **noise_cancelling_level** sets how much to boost a quiet voice after the noise is removed:<br/>
        /// - `0` Mild (default): leaves the volume as is.<br/>
        /// - `1` Normal: moderate boost.<br/>
        /// - `2` Aggressive: noticeably stronger boost.<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "voice", "url": "..."}<br/>
        /// {"type": "back", "label": "no_voice", "url": "..."}    the noise<br/>
        /// ```
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
        /// Removes background noise from speech: crowd, traffic, office and other non-musical noise.<br/>
        /// You get two files: the clean voice and the noise.<br/>
        /// For singing in a song use `/split/stem_separator/` with the `vocals` stem. For speech over music use `/split/demuser/`.<br/>
        /// The only stem is `voice`. With `splitter: auto` the request currently uses lynx, the model made for this stem.<br/>
        /// **noise_cancelling_level** sets how much to boost a quiet voice after the noise is removed:<br/>
        /// - `0` Mild (default): leaves the volume as is.<br/>
        /// - `1` Normal: moderate boost.<br/>
        /// - `2` Aggressive: noticeably stronger boost.<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "voice", "url": "..."}<br/>
        /// {"type": "back", "label": "no_voice", "url": "..."}    the noise<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.Task>> SplitSplitVoiceCleanAsResponseAsync(

            global::LalalAI.VoiceCleanSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background noise<br/>
        /// Removes background noise from speech: crowd, traffic, office and other non-musical noise.<br/>
        /// You get two files: the clean voice and the noise.<br/>
        /// For singing in a song use `/split/stem_separator/` with the `vocals` stem. For speech over music use `/split/demuser/`.<br/>
        /// The only stem is `voice`. With `splitter: auto` the request currently uses lynx, the model made for this stem.<br/>
        /// **noise_cancelling_level** sets how much to boost a quiet voice after the noise is removed:<br/>
        /// - `0` Mild (default): leaves the volume as is.<br/>
        /// - `1` Normal: moderate boost.<br/>
        /// - `2` Aggressive: noticeably stronger boost.<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "voice", "url": "..."}<br/>
        /// {"type": "back", "label": "no_voice", "url": "..."}    the noise<br/>
        /// ```
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