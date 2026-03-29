#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Split a file into multiple stems in one request (multistem feature)<br/>
        ///     WARNING: The stems are internally extracted one by one, so the processing time is proportional to the number of stems selected.<br/>
        ///     You will be charged an equal amount of minutes for each stem.<br/>
        ///     For example, if you have an audio file with a duration of 1 minute,<br/>
        ///     with stem_list=["vocals", "drum"], you will be charged 2 minutes (1 minute for "vocals", 1 minute for "drum").<br/>
        ///     At the /check/ endpoint you will receive &lt;number_of_stems&gt; tracks with 1 additional track which is the source without all selected stems.<br/>
        ///     Example response tracks for stem_list=["vocals", "drum"]:<br/>
        ///     - stem:{"type":"stem", "label":"vocals", "url":"..."}<br/>
        ///     - stem:{"type":"stem", "label":"drum", "url":"..."}<br/>
        ///     - rest of source:{"type":"back", "label":"no_multistem", "url":"..."}<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitMultistemAsync(

            global::LalalAI.MultistemSplitParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split a file into multiple stems in one request (multistem feature)<br/>
        ///     WARNING: The stems are internally extracted one by one, so the processing time is proportional to the number of stems selected.<br/>
        ///     You will be charged an equal amount of minutes for each stem.<br/>
        ///     For example, if you have an audio file with a duration of 1 minute,<br/>
        ///     with stem_list=["vocals", "drum"], you will be charged 2 minutes (1 minute for "vocals", 1 minute for "drum").<br/>
        ///     At the /check/ endpoint you will receive &lt;number_of_stems&gt; tracks with 1 additional track which is the source without all selected stems.<br/>
        ///     Example response tracks for stem_list=["vocals", "drum"]:<br/>
        ///     - stem:{"type":"stem", "label":"vocals", "url":"..."}<br/>
        ///     - stem:{"type":"stem", "label":"drum", "url":"..."}<br/>
        ///     - rest of source:{"type":"back", "label":"no_multistem", "url":"..."}<br/>
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
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitMultistemAsync(
            string sourceId,
            global::LalalAI.MultistemSplitterPresetsV1 presets,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}