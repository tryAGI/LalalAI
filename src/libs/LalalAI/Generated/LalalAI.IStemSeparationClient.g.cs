
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
    /// If the result is not good enough, try another `splitter` on a few of your files.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStemSeparationClient : global::System.IDisposable
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