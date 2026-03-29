
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePackListResponse
    {
        /// <summary>
        /// List of voice packs available to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LalalAI.VoicePackInfo> Packs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePackListResponse" /> class.
        /// </summary>
        /// <param name="packs">
        /// List of voice packs available to the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicePackListResponse(
            global::System.Collections.Generic.IList<global::LalalAI.VoicePackInfo> packs)
        {
            this.Packs = packs ?? throw new global::System.ArgumentNullException(nameof(packs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePackListResponse" /> class.
        /// </summary>
        public VoicePackListResponse()
        {
        }
    }
}