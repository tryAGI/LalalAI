#nullable enable

namespace LalalAI
{
    public partial interface IBatchStemSeparationClient
    {
        /// <summary>
        /// Clean voice from background music for multiple files<br/>
        /// Batch version of `/split/demuser/`: starts up to 100 tasks in one request.<br/>
        /// Each item takes the same parameters as `/split/demuser/`.<br/>
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
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchDemuserAsync(

            global::LalalAI.BatchDemuserSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background music for multiple files<br/>
        /// Batch version of `/split/demuser/`: starts up to 100 tasks in one request.<br/>
        /// Each item takes the same parameters as `/split/demuser/`.<br/>
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
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.BatchTasksResponse>> BatchSplitSplitBatchDemuserAsResponseAsync(

            global::LalalAI.BatchDemuserSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background music for multiple files<br/>
        /// Batch version of `/split/demuser/`: starts up to 100 tasks in one request.<br/>
        /// Each item takes the same parameters as `/split/demuser/`.<br/>
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
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchDemuserAsync(
            global::System.Collections.Generic.IList<global::LalalAI.DemuserSplitParameters> items,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}