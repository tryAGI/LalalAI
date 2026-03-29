
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LimitsResponse
    {
        /// <summary>
        /// Number of processing minutes available to consume.<br/>
        /// Example: 1234.5F
        /// </summary>
        /// <example>1234.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes_left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinutesLeft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsResponse" /> class.
        /// </summary>
        /// <param name="minutesLeft">
        /// Number of processing minutes available to consume.<br/>
        /// Example: 1234.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LimitsResponse(
            double minutesLeft)
        {
            this.MinutesLeft = minutesLeft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsResponse" /> class.
        /// </summary>
        public LimitsResponse()
        {
        }
    }
}