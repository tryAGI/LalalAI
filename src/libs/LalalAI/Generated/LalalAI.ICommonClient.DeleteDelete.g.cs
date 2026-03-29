#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Delete source file and resulting tracks from storage.<br/>
        ///     WARNING: All running tasks related to the source file will be cancelled. Do not call delete on source files with processing tasks.<br/>
        ///     This only deletes the media files, not the database records.<br/>
        ///     The files are removed from storage immediately, but download links will remain valid for one hour after deletion due to CDN caching.<br/>
        ///     The /check/ endpoint will still return a valid check result for 24 hours, but the download links will lead to a 404 error after deletion.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.SuccessResponse> DeleteDeleteAsync(

            global::LalalAI.DeleteParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete source file and resulting tracks from storage.<br/>
        ///     WARNING: All running tasks related to the source file will be cancelled. Do not call delete on source files with processing tasks.<br/>
        ///     This only deletes the media files, not the database records.<br/>
        ///     The files are removed from storage immediately, but download links will remain valid for one hour after deletion due to CDN caching.<br/>
        ///     The /check/ endpoint will still return a valid check result for 24 hours, but the download links will lead to a 404 error after deletion.<br/>
        ///     
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.SuccessResponse> DeleteDeleteAsync(
            string sourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}