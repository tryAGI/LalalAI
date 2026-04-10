#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Upload a file to the server.<br/>
        ///     The uploaded file in other endpoints is called a "source file".<br/>
        ///     You can use the source file ID from the response to create split tasks.<br/>
        ///     The file will be deleted when the expiration time from the response is reached.<br/>
        ///     Upload limit is 10GB per request.<br/>
        ///     
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
    }
}