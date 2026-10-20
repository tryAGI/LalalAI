
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// The LALAL.AI API splits audio into stems, such as vocals, instruments, or a voice and its background noise, and changes voices.<br/>
    /// **Authentication**: send your license key in the `X-License-Key` header of every request.<br/>
    /// **Quick start**<br/>
    /// 1. Upload a file with `/upload/`. The `id` from the response is your `source_id`.<br/>
    /// 2. Start a task with this `source_id` and get a `task_id`.<br/>
    ///    Which endpoint fits your audio is explained in [Stem Separation](#tag/stem-separation): for a song it is `/split/stem_separator/`, for speech with noise `/split/voice_clean/`.<br/>
    /// 3. Poll `/check/` with the `task_id` until the task is done.<br/>
    /// 4. Download the result files from the URLs in the `/check/` response.<br/>
    /// 5. Optionally, delete the file and its results from our servers with `/delete/`.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LalalAIClient : global::LalalAI.ILalalAIClient, global::System.IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        public const string DefaultBaseUrl = "https://www.lalal.ai/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::LalalAI.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::LalalAI.AutoSDKClientOptions Options { get; }

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext>? JsonSerializerContextProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider?.Value ?? global::LalalAI.SourceGenerationContext.Default;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Starts up to 100 tasks in one request, for example the same stem from 100 songs.<br/>
        /// - Choose the endpoint, stem and splitter as for a single file: see [Stem Separation](#tag/stem-separation).<br/>
        /// - Each started item becomes an ordinary task with its own `task_id` and is charged like a single start. There is no batch ID and no archive.<br/>
        /// - Poll the returned `task_id` values with `/check/`.<br/>
        /// - There is no batch version of `/split/multistem/`.
        /// </summary>
        public BatchStemSeparationClient BatchStemSeparation => new BatchStemSeparationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Endpoints every task uses: upload a file, follow its tasks, get the results, clean up.<br/>
        /// - One `source_id` from `/upload/` can start several tasks, for example vocals and drums from the same song.<br/>
        /// - Poll all your tasks with one `/check/` request: it takes up to 200 `task_ids` and allows 30 requests per minute.<br/>
        /// - A task stays in `/check/` for 24 hours after it finishes.<br/>
        /// - `/cancel/all/` and `/delete/` cancel only the tasks started with the same license key as the request.
        /// </summary>
        public CommonClient Common => new CommonClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Splits audio into parts, called stems: vocals, drums, bass, a voice and its background noise, and so on.<br/>
        /// Every request sets two things: what to extract — `stem`, or `stem_list` in `/split/multistem/` — and `splitter`, which model extracts it.<br/>
        /// **1. Pick the endpoint by what is in your audio**<br/>
        /// | Your audio | Endpoint |<br/>
        /// |---|---|<br/>
        /// | A song: extract the vocals or one instrument | `/split/stem_separator/` |<br/>
        /// | A song: extract several instruments in one request | `/split/multistem/` |<br/>
        /// | Speech with background noise: crowd, traffic, office | `/split/voice_clean/` |<br/>
        /// | Speech with background music | `/split/demuser/` |<br/>
        /// The `vocals` stem of `/split/stem_separator/` and `/split/voice_clean/` both extract a human voice, but from different audio.<br/>
        /// `vocals` is made for singing in music, usually songs. `/split/voice_clean/` is made for speech among non-musical noise.<br/>
        /// Do not send speech recordings to `vocals`.<br/>
        /// **2. Pick the stem that matches your task most precisely**<br/>
        /// To extract a guitar of any kind, use `guitar`, not `electric_guitar`, even if you expect only an electric guitar.<br/>
        /// The stems of each endpoint are listed in its description.<br/>
        /// **3. Leave `splitter` as `auto`**<br/>
        /// `auto` picks the newest model available for the stem, and newer models separate better: for vocals, andromeda is better than perseus.<br/>
        /// We release new models regularly. With `auto` your integration gets each new model the day it is released, with no change on your side.<br/>
        /// A splitter set by name stays on that model until you update your code, and your results fall behind.<br/>
        /// Send `"splitter": "auto"` explicitly or omit the field: the API accepts `auto`, though the `SplitterType` enum in the OpenAPI schema does not list it.<br/>
        /// Models from oldest to newest: phoenix (2022) → orion (2023) → perseus (2024) → andromeda (2025).<br/>
        /// lynx and lyra are not in this series: they are separate models for the `voice` and `music` stems.<br/>
        /// New models do not come out for every stem at once.<br/>
        /// So a broader stem on a newer model can beat a narrower stem on an older one:<br/>
        /// `guitar` on andromeda works better than `electric_guitar` on perseus, unless the song also has an acoustic guitar you want to keep apart.<br/>
        /// **4. Test on your own audio**<br/>
        /// On some material an older model works better, for example on noisy vintage recordings. It is rare, but it happens.<br/>
        /// If the result is not good enough, try another `splitter` on a few of your files.
        /// </summary>
        public StemSeparationClient StemSeparation => new StemSeparationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Replaces the voice in a recording with another voice from a voice pack.<br/>
        /// 1. Upload the file with `/upload/`.<br/>
        /// 2. Pick a voice pack: one of the ready-made packs listed in `/change_voice/`, or your own pack from `/voice_packs/list/`.<br/>
        /// 3. Start `/change_voice/` and poll `/check/` for the result.
        /// </summary>
        public VoiceChangeClient VoiceChange => new VoiceChangeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Creates a new instance of the LalalAIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LalalAIClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LalalAI.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the LalalAIClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LalalAIClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::LalalAI.EndPointAuthorization>? authorizations,
            global::LalalAI.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the LalalAIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LalalAIClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::LalalAI.EndPointAuthorization>? authorizations,
            global::LalalAI.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::LalalAI.EndPointAuthorization>();
            Options = options ?? new global::LalalAI.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}