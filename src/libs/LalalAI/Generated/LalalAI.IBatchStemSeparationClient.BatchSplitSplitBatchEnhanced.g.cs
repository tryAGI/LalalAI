#nullable enable

namespace LalalAI
{
    public partial interface IBatchStemSeparationClient
    {
        /// <summary>
        /// Split multiple files into stems using the stem separator presets<br/>
        /// Batch version of `/split/stem_separator/`: starts up to 100 tasks in one request.<br/>
        /// Each item takes the same parameters as `/split/stem_separator/`.<br/>
        /// The whole request is rejected if any item has invalid parameters.<br/>
        /// Valid items are started independently: if one fails to start, the others still start.<br/>
        /// `results` keeps the order of `items`, and each result is either of:<br/>
        /// ```<br/>
        /// {"status": "success", "task_id": "...", "source_id": "..."}<br/>
        /// {"status": "error", "error": "...", "code": "...", "source_id": "..."}<br/>
        /// ```<br/>
        /// Poll the `task_id` values with `/check/`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchEnhancedAsync(

            global::LalalAI.BatchStemSeparatorSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split multiple files into stems using the stem separator presets<br/>
        /// Batch version of `/split/stem_separator/`: starts up to 100 tasks in one request.<br/>
        /// Each item takes the same parameters as `/split/stem_separator/`.<br/>
        /// The whole request is rejected if any item has invalid parameters.<br/>
        /// Valid items are started independently: if one fails to start, the others still start.<br/>
        /// `results` keeps the order of `items`, and each result is either of:<br/>
        /// ```<br/>
        /// {"status": "success", "task_id": "...", "source_id": "..."}<br/>
        /// {"status": "error", "error": "...", "code": "...", "source_id": "..."}<br/>
        /// ```<br/>
        /// Poll the `task_id` values with `/check/`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.BatchTasksResponse>> BatchSplitSplitBatchEnhancedAsResponseAsync(

            global::LalalAI.BatchStemSeparatorSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split multiple files into stems using the stem separator presets<br/>
        /// Batch version of `/split/stem_separator/`: starts up to 100 tasks in one request.<br/>
        /// Each item takes the same parameters as `/split/stem_separator/`.<br/>
        /// The whole request is rejected if any item has invalid parameters.<br/>
        /// Valid items are started independently: if one fails to start, the others still start.<br/>
        /// `results` keeps the order of `items`, and each result is either of:<br/>
        /// ```<br/>
        /// {"status": "success", "task_id": "...", "source_id": "..."}<br/>
        /// {"status": "error", "error": "...", "code": "...", "source_id": "..."}<br/>
        /// ```<br/>
        /// Poll the `task_id` values with `/check/`.
        /// </summary>
        /// <param name="items">
        /// List of split parameters to process.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchEnhancedAsync(
            global::System.Collections.Generic.IList<global::LalalAI.StemSeparatorSplitParameters> items,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}