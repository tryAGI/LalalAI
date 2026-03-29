
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SplitTrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.SplitTrackTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LalalAI.SplitTrackType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_file")]
        public string? PlaylistFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waveform")]
        public string? Waveform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTrack" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="url"></param>
        /// <param name="playlistFile"></param>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="waveform"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitTrack(
            global::LalalAI.SplitTrackType type,
            string label,
            string url,
            string? playlistFile,
            string? name,
            int? size,
            string? waveform)
        {
            this.Type = type;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PlaylistFile = playlistFile;
            this.Name = name;
            this.Size = size;
            this.Waveform = waveform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTrack" /> class.
        /// </summary>
        public SplitTrack()
        {
        }
    }
}