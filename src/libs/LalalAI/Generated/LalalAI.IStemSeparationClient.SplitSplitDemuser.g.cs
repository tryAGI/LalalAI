#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Clean voice from background music<br/>
        /// Separates a voice from background music, for example in a video or a podcast.<br/>
        /// You get two files: the music, and the rest of the recording without it, usually the voice.<br/>
        /// For speech with non-musical noise use `/split/voice_clean/`. For vocals in a song use `/split/stem_separator/`.<br/>
        /// The only stem is `music`. With `splitter: auto` the request currently uses lyra, the model made for this stem.<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "music", "url": "..."}<br/>
        /// {"type": "back", "label": "no_music", "url": "..."}    the voice<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitDemuserAsync(

            global::LalalAI.DemuserSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background music<br/>
        /// Separates a voice from background music, for example in a video or a podcast.<br/>
        /// You get two files: the music, and the rest of the recording without it, usually the voice.<br/>
        /// For speech with non-musical noise use `/split/voice_clean/`. For vocals in a song use `/split/stem_separator/`.<br/>
        /// The only stem is `music`. With `splitter: auto` the request currently uses lyra, the model made for this stem.<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "music", "url": "..."}<br/>
        /// {"type": "back", "label": "no_music", "url": "..."}    the voice<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.Task>> SplitSplitDemuserAsResponseAsync(

            global::LalalAI.DemuserSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clean voice from background music<br/>
        /// Separates a voice from background music, for example in a video or a podcast.<br/>
        /// You get two files: the music, and the rest of the recording without it, usually the voice.<br/>
        /// For speech with non-musical noise use `/split/voice_clean/`. For vocals in a song use `/split/stem_separator/`.<br/>
        /// The only stem is `music`. With `splitter: auto` the request currently uses lyra, the model made for this stem.<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "music", "url": "..."}<br/>
        /// {"type": "back", "label": "no_music", "url": "..."}    the voice<br/>
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
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitDemuserAsync(
            string sourceId,
            global::LalalAI.DemuserSplitterPresetsV1 presets,
            string? idempotencyKey = default,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}