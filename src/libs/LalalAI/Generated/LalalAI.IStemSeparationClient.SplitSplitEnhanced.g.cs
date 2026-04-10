#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Split a file into stems using the stem separator presets<br/>
        ///     Result of /check/ includes 2 tracks:<br/>
        ///     - stem:{"type":"stem", "label":"&lt;stem_name&gt;", "url":"..."}<br/>
        ///     - without stem:{"type":"back", "label":"no_&lt;stem_name&gt;", "url":"..."}<br/>
        ///     LEAD_BACK VOCALS:<br/>
        ///     For 'vocals' stem you can use parameter multivocal="lead_back" and receive both lead and backing vocals as separate stems.<br/>
        ///     Result of /check/ includes 4 tracks. Backing vocals track is optional and could be suppressed if not found in the audio:<br/>
        ///     lead vocals:{"type":"stem", "label":"vocals@0", "url":"..."}<br/>
        ///     backing vocals:{"type":"stem", "label":"vocals@1", "url":"..."}<br/>
        ///     instrumental:{"type":"back", "label":"no_vocals", "url":"..."}<br/>
        ///     instrumental + backing vocals:{"type":"back", "label":"mix_no_lead", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitEnhancedAsync(

            global::LalalAI.StemSeparatorSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split a file into stems using the stem separator presets<br/>
        ///     Result of /check/ includes 2 tracks:<br/>
        ///     - stem:{"type":"stem", "label":"&lt;stem_name&gt;", "url":"..."}<br/>
        ///     - without stem:{"type":"back", "label":"no_&lt;stem_name&gt;", "url":"..."}<br/>
        ///     LEAD_BACK VOCALS:<br/>
        ///     For 'vocals' stem you can use parameter multivocal="lead_back" and receive both lead and backing vocals as separate stems.<br/>
        ///     Result of /check/ includes 4 tracks. Backing vocals track is optional and could be suppressed if not found in the audio:<br/>
        ///     lead vocals:{"type":"stem", "label":"vocals@0", "url":"..."}<br/>
        ///     backing vocals:{"type":"stem", "label":"vocals@1", "url":"..."}<br/>
        ///     instrumental:{"type":"back", "label":"no_vocals", "url":"..."}<br/>
        ///     instrumental + backing vocals:{"type":"back", "label":"mix_no_lead", "url":"..."}<br/>
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
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitEnhancedAsync(
            string sourceId,
            global::LalalAI.StemSeparatorSplitterPresetsV1 presets,
            string? idempotencyKey = default,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}