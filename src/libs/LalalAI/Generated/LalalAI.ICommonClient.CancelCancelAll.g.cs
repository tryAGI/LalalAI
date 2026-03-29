#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Cancel all user tasks in progress state
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.CancelResponse> CancelCancelAllAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}