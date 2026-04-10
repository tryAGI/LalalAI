#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Check the status of a task by id<br/>
        ///     This endpoint allows you to check the status of a specific task by its ID.<br/>
        ///     Checking is only possible within 24h after task creation, otherwise an error will be returned.<br/>
        ///     The current rate limit for this endpoint is 30 requests per minute. This limit may be increased in the future.<br/>
        ///     
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
        ///     This endpoint allows you to check the status of a specific task by its ID.<br/>
        ///     Checking is only possible within 24h after task creation, otherwise an error will be returned.<br/>
        ///     The current rate limit for this endpoint is 30 requests per minute. This limit may be increased in the future.<br/>
        ///     
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