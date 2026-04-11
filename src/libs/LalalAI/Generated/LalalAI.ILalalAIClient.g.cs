
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// This is the LALAL.AI API.<br/>
    /// To authenticate, provide your license key in the `X-License-Key` header of each request.<br/>
    /// Typical usage example:<br/>
    /// 1) Upload a file using the '/upload/' endpoint to get a 'source_id'.<br/>
    /// 2) Start a splitting task using the '/split/' endpoint with the obtained 'source_id' and desired presets.<br/>
    /// 3) Check the status of your task using the '/check/' endpoint with the returned 'task_id'.<br/>
    /// 4) Once the task is complete, download the processed files using urls from the '/check/' response.<br/>
    /// 5) (If needed), you can delete the source file and all its resulting tracks from our servers, using the '/delete/' endpoint with the 'source_id'.<br/>
    /// Notes:<br/>
    /// You can use the same source_id for concurrent splitting tasks.<br/>
    /// You can check multiple task IDs in a single '/check/' request by providing a list of 'task_ids'.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ILalalAIClient : global::System.IDisposable
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


        /// <summary>
        /// 
        /// </summary>
        public BatchStemSeparationClient BatchStemSeparation { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommonClient Common { get; }

        /// <summary>
        /// 
        /// </summary>
        public StemSeparationClient StemSeparation { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceChangeClient VoiceChange { get; }

    }
}