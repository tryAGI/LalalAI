
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckV1ErrorResultPresetsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.CheckV1ErrorResultPresetsDiscriminatorLabelJsonConverter))]
        public global::LalalAI.CheckV1ErrorResultPresetsDiscriminatorLabel? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1ErrorResultPresetsDiscriminator" /> class.
        /// </summary>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckV1ErrorResultPresetsDiscriminator(
            global::LalalAI.CheckV1ErrorResultPresetsDiscriminatorLabel? label)
        {
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1ErrorResultPresetsDiscriminator" /> class.
        /// </summary>
        public CheckV1ErrorResultPresetsDiscriminator()
        {
        }
    }
}