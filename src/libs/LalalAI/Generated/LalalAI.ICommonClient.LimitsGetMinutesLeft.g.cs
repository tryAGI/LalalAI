#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Get number of processing minutes available to consume.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.LimitsResponse> LimitsGetMinutesLeftAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}