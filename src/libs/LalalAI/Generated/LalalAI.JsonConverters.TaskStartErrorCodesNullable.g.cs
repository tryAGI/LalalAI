#nullable enable

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TaskStartErrorCodesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.TaskStartErrorCodes?>
    {
        /// <inheritdoc />
        public override global::LalalAI.TaskStartErrorCodes? Read(
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
                        return global::LalalAI.TaskStartErrorCodesExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LalalAI.TaskStartErrorCodes)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LalalAI.TaskStartErrorCodes?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.TaskStartErrorCodes? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LalalAI.TaskStartErrorCodesExtensions.ToValueString(value.Value));
            }
        }
    }
}
