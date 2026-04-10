#nullable enable

namespace LalalAI
{
    public partial interface IBatchStemSeparationClient
    {
        /// <summary>
        /// Clean voice from background noise for multiple files<br/>
        ///     Batch version of /split/voice_clean/. Accepts a list of split parameters and returns results for each item.<br/>
        ///     Each item is processed independently - if one fails, others will still be processed.<br/>
        ///     Results are returned in the same order as input items.<br/>
        ///     Each result contains either:<br/>
        ///     - success: {"status": "success", "task_id": "...", "source_id": "..."}<br/>
        ///     - error: {"status": "error", "error": "...", "code": "...", "source_id": "..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchVoiceCleanAsync(

            global::LalalAI.BatchVoiceCleanSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background noise for multiple files<br/>
        ///     Batch version of /split/voice_clean/. Accepts a list of split parameters and returns results for each item.<br/>
        ///     Each item is processed independently - if one fails, others will still be processed.<br/>
        ///     Results are returned in the same order as input items.<br/>
        ///     Each result contains either:<br/>
        ///     - success: {"status": "success", "task_id": "...", "source_id": "..."}<br/>
        ///     - error: {"status": "error", "error": "...", "code": "...", "source_id": "..."}<br/>
        ///     
        /// </summary>
        /// <param name="items">
        /// List of split parameters to process.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchVoiceCleanAsync(
            global::System.Collections.Generic.IList<global::LalalAI.VoiceCleanSplitParameters> items,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}