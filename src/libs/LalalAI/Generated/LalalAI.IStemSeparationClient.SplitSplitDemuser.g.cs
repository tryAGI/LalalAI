#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Clean voice from background music<br/>
        ///     Typical usage case - is voice with background music.<br/>
        ///     Demuser will separate voice (stem) and music (back).<br/>
        ///     Result of /check/ includes 2 tracks:<br/>
        ///     - stem:{"type":"stem", "label":"music", "url":"..."}<br/>
        ///     - back:{"type":"back", "label":"no_music", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitDemuserAsync(

            global::LalalAI.DemuserSplitParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background music<br/>
        ///     Typical usage case - is voice with background music.<br/>
        ///     Demuser will separate voice (stem) and music (back).<br/>
        ///     Result of /check/ includes 2 tracks:<br/>
        ///     - stem:{"type":"stem", "label":"music", "url":"..."}<br/>
        ///     - back:{"type":"back", "label":"no_music", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file to be processed.<br/>
        /// Example: 2fe8f214-1771-4900-9e7e-570f823bd359
        /// </param>
        /// <param name="presets"></param>
        /// <param name="idempotencyKey">
        /// Unique uuid4 key to ensure idempotent requests.<br/>
        /// Prevents duplicate task execution with the same parameters.<br/>
        /// Can be reused until the task starts. Once processing begins, reusing this key will return an error.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitDemuserAsync(
            string sourceId,
            global::LalalAI.DemuserSplitterPresetsV1 presets,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}