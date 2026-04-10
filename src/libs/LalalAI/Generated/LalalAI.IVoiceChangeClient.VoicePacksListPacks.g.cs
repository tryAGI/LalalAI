#nullable enable

namespace LalalAI
{
    public partial interface IVoiceChangeClient
    {
        /// <summary>
        /// Lists voice packs available to the user<br/>
        /// Helps to find pack_id for /change_voice/ endpoint.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.VoicePackListResponse> VoicePacksListPacksAsync(
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}