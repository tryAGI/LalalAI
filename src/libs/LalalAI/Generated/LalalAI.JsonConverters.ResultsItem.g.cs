#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public class ResultsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.ResultsItem>
    {
        /// <inheritdoc />
        public override global::LalalAI.ResultsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.BatchTasksResponseResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.BatchTasksResponseResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.BatchTasksResponseResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LalalAI.SuccessfulTaskStart? success = default;
            if (discriminator?.Status == global::LalalAI.BatchTasksResponseResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.SuccessfulTaskStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.SuccessfulTaskStart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.SuccessfulTaskStart)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.FailedTaskStart? error = default;
            if (discriminator?.Status == global::LalalAI.BatchTasksResponseResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.FailedTaskStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.FailedTaskStart> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.FailedTaskStart)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LalalAI.ResultsItem(
                discriminator?.Status,
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.ResultsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.SuccessfulTaskStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.SuccessfulTaskStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.SuccessfulTaskStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.FailedTaskStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.FailedTaskStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.FailedTaskStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}