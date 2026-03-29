
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadResponse
    {
        /// <summary>
        /// ID of the uploaded file.<br/>
        /// Example: e1fc1d8f-502e-4de0-bf3b-b30543d11c77
        /// </summary>
        /// <example>e1fc1d8f-502e-4de0-bf3b-b30543d11c77</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the uploaded file.<br/>
        /// Example: my_audio.mp3
        /// </summary>
        /// <example>my_audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Size of the uploaded file in bytes.<br/>
        /// Example: 12345678
        /// </summary>
        /// <example>12345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// Duration of the uploaded media file in seconds.<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// File expiration time in Unix epoch format with UTC timezone.<br/>
        /// Example: 1761217415
        /// </summary>
        /// <example>1761217415</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Expires { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the uploaded file.<br/>
        /// Example: e1fc1d8f-502e-4de0-bf3b-b30543d11c77
        /// </param>
        /// <param name="name">
        /// Name of the uploaded file.<br/>
        /// Example: my_audio.mp3
        /// </param>
        /// <param name="size">
        /// Size of the uploaded file in bytes.<br/>
        /// Example: 12345678
        /// </param>
        /// <param name="duration">
        /// Duration of the uploaded media file in seconds.<br/>
        /// Example: 180
        /// </param>
        /// <param name="expires">
        /// File expiration time in Unix epoch format with UTC timezone.<br/>
        /// Example: 1761217415
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadResponse(
            string id,
            string name,
            long size,
            int duration,
            int expires)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
            this.Duration = duration;
            this.Expires = expires;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponse" /> class.
        /// </summary>
        public UploadResponse()
        {
        }
    }
}