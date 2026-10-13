#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Upload a file to the server<br/>
        /// Uploads a file, up to 10 GB. Other endpoints call it the source file.<br/>
        /// Use the `id` from the response as `source_id` to start tasks. One file can start several tasks.<br/>
        /// The file is deleted at the `expires` time from the response.
        /// </summary>
        /// <param name="contentDisposition"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.UploadResponse> UploadUploadAsync(
            string contentDisposition,

            byte[] request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file to the server<br/>
        /// Uploads a file, up to 10 GB. Other endpoints call it the source file.<br/>
        /// Use the `id` from the response as `source_id` to start tasks. One file can start several tasks.<br/>
        /// The file is deleted at the `expires` time from the response.
        /// </summary>
        /// <param name="contentDisposition"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.UploadResponse>> UploadUploadAsResponseAsync(
            string contentDisposition,

            byte[] request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}