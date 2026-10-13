
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// Replaces the voice in a recording with another voice from a voice pack.<br/>
    /// 1. Upload the file with `/upload/`.<br/>
    /// 2. Pick a voice pack: one of the ready-made packs listed in `/change_voice/`, or your own pack from `/voice_packs/list/`.<br/>
    /// 3. Start `/change_voice/` and poll `/check/` for the result.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IVoiceChangeClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::LalalAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::LalalAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}