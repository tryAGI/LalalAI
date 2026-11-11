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
        /// The only supported stem is `voice`.<br/>
        /// The specialized voice models are lynx and cepheus. The general-purpose models (andromeda, perseus, orion and phoenix) also support this stem.<br/>
        /// With `splitter: auto`, lynx is currently selected.<br/>
        /// cepheus is a newer model for this stem. Its results can differ noticeably from lynx, so compare both models on your recordings before switching.<br/>
        /// **noise_cancelling_level** works differently depending on the splitter.<br/>
        /// lynx, andromeda and phoenix:<br/>
        /// - `0` Mild (default) and `1` Normal: preserve the original voice volume.<br/>
        /// - `2` Aggressive: compresses and normalizes the voice to make its quiet parts louder.<br/>
        /// cepheus, perseus and orion:<br/>
        /// - `0` Mild (default): preserves more voice detail, but may keep some background noise.<br/>
        /// - `1` Normal: removes noise more strictly, but some of the voice may go to the noise track.<br/>
        /// - `2` Aggressive: the same as `1`, plus compression and normalization of the voice.<br/>
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
        /// The only supported stem is `voice`.<br/>
        /// The specialized voice models are lynx and cepheus. The general-purpose models (andromeda, perseus, orion and phoenix) also support this stem.<br/>
        /// With `splitter: auto`, lynx is currently selected.<br/>
        /// cepheus is a newer model for this stem. Its results can differ noticeably from lynx, so compare both models on your recordings before switching.<br/>
        /// **noise_cancelling_level** works differently depending on the splitter.<br/>
        /// lynx, andromeda and phoenix:<br/>
        /// - `0` Mild (default) and `1` Normal: preserve the original voice volume.<br/>
        /// - `2` Aggressive: compresses and normalizes the voice to make its quiet parts louder.<br/>
        /// cepheus, perseus and orion:<br/>
        /// - `0` Mild (default): preserves more voice detail, but may keep some background noise.<br/>
        /// - `1` Normal: removes noise more strictly, but some of the voice may go to the noise track.<br/>
        /// - `2` Aggressive: the same as `1`, plus compression and normalization of the voice.<br/>
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
        /// The only supported stem is `voice`.<br/>
        /// The specialized voice models are lynx and cepheus. The general-purpose models (andromeda, perseus, orion and phoenix) also support this stem.<br/>
        /// With `splitter: auto`, lynx is currently selected.<br/>
        /// cepheus is a newer model for this stem. Its results can differ noticeably from lynx, so compare both models on your recordings before switching.<br/>
        /// **noise_cancelling_level** works differently depending on the splitter.<br/>
        /// lynx, andromeda and phoenix:<br/>
        /// - `0` Mild (default) and `1` Normal: preserve the original voice volume.<br/>
        /// - `2` Aggressive: compresses and normalizes the voice to make its quiet parts louder.<br/>
        /// cepheus, perseus and orion:<br/>
        /// - `0` Mild (default): preserves more voice detail, but may keep some background noise.<br/>
        /// - `1` Normal: removes noise more strictly, but some of the voice may go to the noise track.<br/>
        /// - `2` Aggressive: the same as `1`, plus compression and normalization of the voice.<br/>
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