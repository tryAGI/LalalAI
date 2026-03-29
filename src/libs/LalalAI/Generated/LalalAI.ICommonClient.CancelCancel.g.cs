#nullable enable

namespace LalalAI
{
    public partial interface ICommonClient
    {
        /// <summary>
        /// Cancel tasks by id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.CancelResponse> CancelCancelAsync(

            global::LalalAI.CancelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel tasks by id
        /// </summary>
        /// <param name="taskIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.CancelResponse> CancelCancelAsync(
            global::System.Collections.Generic.IList<string> taskIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}