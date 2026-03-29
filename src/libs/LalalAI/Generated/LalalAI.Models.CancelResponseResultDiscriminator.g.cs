
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelResponseResultDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.CancelResponseResultDiscriminatorStatusJsonConverter))]
        public global::LalalAI.CancelResponseResultDiscriminatorStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelResponseResultDiscriminator" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelResponseResultDiscriminator(
            global::LalalAI.CancelResponseResultDiscriminatorStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelResponseResultDiscriminator" /> class.
        /// </summary>
        public CancelResponseResultDiscriminator()
        {
        }
    }
}