#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Delete source file and resulting tracks from storage<br/>
        /// Deletes the source file and all its result files from our servers.<br/>
        /// - Call it only when the tasks of this file are done: it cancels running tasks started with the same license key, and the others lose their file.<br/>
        /// - Only the files are deleted, not the processing history.<br/>
        /// - `/check/` keeps returning the task with its download links. Because of CDN caching the links can work for up to one hour after deletion, then they return 404.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.SuccessResponse> DeleteDeleteAsync(

            global::LalalAI.DeleteParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete source file and resulting tracks from storage<br/>
        /// Deletes the source file and all its result files from our servers.<br/>
        /// - Call it only when the tasks of this file are done: it cancels running tasks started with the same license key, and the others lose their file.<br/>
        /// - Only the files are deleted, not the processing history.<br/>
        /// - `/check/` keeps returning the task with its download links. Because of CDN caching the links can work for up to one hour after deletion, then they return 404.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.SuccessResponse>> DeleteDeleteAsResponseAsync(

            global::LalalAI.DeleteParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete source file and resulting tracks from storage<br/>
        /// Deletes the source file and all its result files from our servers.<br/>
        /// - Call it only when the tasks of this file are done: it cancels running tasks started with the same license key, and the others lose their file.<br/>
        /// - Only the files are deleted, not the processing history.<br/>
        /// - `/check/` keeps returning the task with its download links. Because of CDN caching the links can work for up to one hour after deletion, then they return 404.
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.SuccessResponse> DeleteDeleteAsync(
            string sourceId,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}