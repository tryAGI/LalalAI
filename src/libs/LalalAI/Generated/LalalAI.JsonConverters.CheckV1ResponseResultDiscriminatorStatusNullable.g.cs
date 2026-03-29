#nullable enable

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CheckV1ResponseResultDiscriminatorStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.CheckV1ResponseResultDiscriminatorStatus?>
    {
        /// <inheritdoc />
        public override global::LalalAI.CheckV1ResponseResultDiscriminatorStatus? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LalalAI.CheckV1ResponseResultDiscriminatorStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LalalAI.CheckV1ResponseResultDiscriminatorStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LalalAI.CheckV1ResponseResultDiscriminatorStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.CheckV1ResponseResultDiscriminatorStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LalalAI.CheckV1ResponseResultDiscriminatorStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
