#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Split a file into multiple stems in one request (multistem feature)<br/>
        /// Extracts several stems from a song in one request, for example vocals, drums and bass.<br/>
        /// Stems: `vocals`, `drum`, `bass`, `piano`, `electric_guitar`, `acoustic_guitar`.<br/>
        /// With `splitter: auto` and two or more stems the request currently uses perseus. With one stem it uses the same model as `/split/stem_separator/`.<br/>
        /// `/split/stem_separator/` currently runs `vocals`, `drum`, `bass` and `piano` on the newer andromeda:<br/>
        /// if quality matters more than the number of requests, start it once per stem.<br/>
        /// **Time and price**<br/>
        /// Stems are extracted one by one, so processing time grows with the number of stems.<br/>
        /// Each stem is charged separately: a 1-minute file with `stem_list: ["vocals", "drum"]` costs 2 minutes.<br/>
        /// **Result**<br/>
        /// `/check/` returns one track per stem and one track with the rest of the song. For `stem_list: ["vocals", "drum"]`:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "vocals", "url": "..."}<br/>
        /// {"type": "stem", "label": "drum", "url": "..."}<br/>
        /// {"type": "back", "label": "no_multistem", "url": "..."}<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitMultistemAsync(

            global::LalalAI.MultistemSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split a file into multiple stems in one request (multistem feature)<br/>
        /// Extracts several stems from a song in one request, for example vocals, drums and bass.<br/>
        /// Stems: `vocals`, `drum`, `bass`, `piano`, `electric_guitar`, `acoustic_guitar`.<br/>
        /// With `splitter: auto` and two or more stems the request currently uses perseus. With one stem it uses the same model as `/split/stem_separator/`.<br/>
        /// `/split/stem_separator/` currently runs `vocals`, `drum`, `bass` and `piano` on the newer andromeda:<br/>
        /// if quality matters more than the number of requests, start it once per stem.<br/>
        /// **Time and price**<br/>
        /// Stems are extracted one by one, so processing time grows with the number of stems.<br/>
        /// Each stem is charged separately: a 1-minute file with `stem_list: ["vocals", "drum"]` costs 2 minutes.<br/>
        /// **Result**<br/>
        /// `/check/` returns one track per stem and one track with the rest of the song. For `stem_list: ["vocals", "drum"]`:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "vocals", "url": "..."}<br/>
        /// {"type": "stem", "label": "drum", "url": "..."}<br/>
        /// {"type": "back", "label": "no_multistem", "url": "..."}<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.Task>> SplitSplitMultistemAsResponseAsync(

            global::LalalAI.MultistemSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split a file into multiple stems in one request (multistem feature)<br/>
        /// Extracts several stems from a song in one request, for example vocals, drums and bass.<br/>
        /// Stems: `vocals`, `drum`, `bass`, `piano`, `electric_guitar`, `acoustic_guitar`.<br/>
        /// With `splitter: auto` and two or more stems the request currently uses perseus. With one stem it uses the same model as `/split/stem_separator/`.<br/>
        /// `/split/stem_separator/` currently runs `vocals`, `drum`, `bass` and `piano` on the newer andromeda:<br/>
        /// if quality matters more than the number of requests, start it once per stem.<br/>
        /// **Time and price**<br/>
        /// Stems are extracted one by one, so processing time grows with the number of stems.<br/>
        /// Each stem is charged separately: a 1-minute file with `stem_list: ["vocals", "drum"]` costs 2 minutes.<br/>
        /// **Result**<br/>
        /// `/check/` returns one track per stem and one track with the rest of the song. For `stem_list: ["vocals", "drum"]`:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "vocals", "url": "..."}<br/>
        /// {"type": "stem", "label": "drum", "url": "..."}<br/>
        /// {"type": "back", "label": "no_multistem", "url": "..."}<br/>
        /// ```
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitMultistemAsync(
            string sourceId,
            global::LalalAI.MultistemSplitterPresetsV1 presets,
            string? idempotencyKey = default,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}