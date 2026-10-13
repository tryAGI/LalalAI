#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Check the status of a task by id<br/>
        /// Returns the status of your tasks: in progress, done, failed or cancelled. Done tasks include the URLs of the result files.<br/>
        /// - Pass all your `task_ids` in one request, up to 200: the limit is 30 requests per minute.<br/>
        /// - A task stays here for 24 hours after it finishes. After that `/check/` returns an error for it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.CheckV1Response> CheckCheckAsync(

            global::LalalAI.CheckV1Request request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the status of a task by id<br/>
        /// Returns the status of your tasks: in progress, done, failed or cancelled. Done tasks include the URLs of the result files.<br/>
        /// - Pass all your `task_ids` in one request, up to 200: the limit is 30 requests per minute.<br/>
        /// - A task stays here for 24 hours after it finishes. After that `/check/` returns an error for it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.CheckV1Response>> CheckCheckAsResponseAsync(

            global::LalalAI.CheckV1Request request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the status of a task by id<br/>
        /// Returns the status of your tasks: in progress, done, failed or cancelled. Done tasks include the URLs of the result files.<br/>
        /// - Pass all your `task_ids` in one request, up to 200: the limit is 30 requests per minute.<br/>
        /// - A task stays here for 24 hours after it finishes. After that `/check/` returns an error for it.
        /// </summary>
        /// <param name="taskIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.CheckV1Response> CheckCheckAsync(
            global::System.Collections.Generic.IList<string> taskIds,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}