#nullable enable

namespace LalalAI
{
    public partial interface IBatchStemSeparationClient
    {
        /// <summary>
        /// Split multiple files into stems using the stem separator presets<br/>
        ///     Batch version of /split/stem_separator/. Accepts a list of split parameters and returns results for each item.<br/>
        ///     Each item is processed independently - if one fails, others will still be processed.<br/>
        ///     Results are returned in the same order as input items.<br/>
        ///     Each result contains either:<br/>
        ///     - success: {"status": "success", "task_id": "...", "source_id": "..."}<br/>
        ///     - error: {"status": "error", "error": "...", "code": "...", "source_id": "..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchEnhancedAsync(

            global::LalalAI.BatchStemSeparatorSplitParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split multiple files into stems using the stem separator presets<br/>
        ///     Batch version of /split/stem_separator/. Accepts a list of split parameters and returns results for each item.<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.BatchTasksResponse> BatchSplitSplitBatchEnhancedAsync(
            global::System.Collections.Generic.IList<global::LalalAI.StemSeparatorSplitParameters> items,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}