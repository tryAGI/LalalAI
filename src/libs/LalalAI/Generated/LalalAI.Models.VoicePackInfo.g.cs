
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePackInfo
    {
        /// <summary>
        /// Name of the voice pack.<br/>
        /// Example: Professional Narrator Voice Pack
        /// </summary>
        /// <example>Professional Narrator Voice Pack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of the voice pack.<br/>
        /// Example: f5dc9452-9374-4418-9288-02825bbd0016
        /// </summary>
        /// <example>f5dc9452-9374-4418-9288-02825bbd0016</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pack_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackId { get; set; }

        /// <summary>
        /// Creation timestamp of the voice pack.<br/>
        /// Example: 1672531199
        /// </summary>
        /// <example>1672531199</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePackInfo" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the voice pack.<br/>
        /// Example: Professional Narrator Voice Pack
        /// </param>
        /// <param name="packId">
        /// ID of the voice pack.<br/>
        /// Example: f5dc9452-9374-4418-9288-02825bbd0016
        /// </param>
        /// <param name="created">
        /// Creation timestamp of the voice pack.<br/>
        /// Example: 1672531199
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicePackInfo(
            string name,
            string packId,
            int created)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PackId = packId ?? throw new global::System.ArgumentNullException(nameof(packId));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePackInfo" /> class.
        /// </summary>
        public VoicePackInfo()
        {
        }
    }
}