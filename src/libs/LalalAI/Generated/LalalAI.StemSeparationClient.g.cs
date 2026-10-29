
#nullable enable

namespace LalalAI
{
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
    /// To extract all guitars into one track, use `guitar`. To get only one kind of guitar, use `electric_guitar` or `acoustic_guitar`.<br/>
    /// The stems of each endpoint are listed in its description.<br/>
    /// **3. Leave `splitter` as `auto`**<br/>
    /// `auto` picks the newest model available for the stem, and newer models separate better: for vocals, andromeda is better than perseus.<br/>
    /// We release new models regularly. With `auto` your integration gets each new model the day it is released, with no change on your side.<br/>
    /// A splitter set by name stays on that model until you update your code, and your results fall behind.<br/>
    /// Send `"splitter": "auto"` explicitly or omit the field: the API accepts `auto`, though the `SplitterType` enum in the OpenAPI schema does not list it.<br/>
    /// Models from oldest to newest: phoenix (2022) → orion (2023) → perseus (2024) → andromeda (2025).<br/>
    /// lynx and lyra are not in this series: they are separate models for the `voice` and `music` stems.<br/>
    /// **4. Test on your own audio**<br/>
    /// On some material an older model works better, for example on noisy vintage recordings. It is rare, but it happens.<br/>
    /// If the result is not good enough, try another `splitter` on a few of your files.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class StemSeparationClient : global::LalalAI.IStemSeparationClient, global::System.IDisposable
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
            get => JsonSerializerContextProvider?.Value ?? global::LalalAI.StemSeparationSourceGenerationContext.Default;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Creates a new instance of the StemSeparationClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public StemSeparationClient(
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
        /// Creates a new instance of the StemSeparationClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public StemSeparationClient(
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
        /// Creates a new instance of the StemSeparationClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public StemSeparationClient(
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