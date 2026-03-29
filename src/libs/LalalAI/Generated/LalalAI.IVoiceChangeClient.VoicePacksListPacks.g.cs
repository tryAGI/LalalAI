#nullable enable

namespace LalalAI
{
    public partial interface IVoiceChangeClient
    {
        /// <summary>
        /// Lists voice packs available to the user<br/>
        /// Helps to find pack_id for /change_voice/ endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.VoicePackListResponse> VoicePacksListPacksAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}