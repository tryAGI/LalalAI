#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public class Result2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.Result2>
    {
        /// <inheritdoc />
        public override global::LalalAI.Result2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CancelResponseResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CancelResponseResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CancelResponseResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LalalAI.CancelSuccess? success = default;
            if (discriminator?.Status == global::LalalAI.CancelResponseResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CancelSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CancelSuccess> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CancelSuccess)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.ErrorResult? serverError = default;
            if (discriminator?.Status == global::LalalAI.CancelResponseResultDiscriminatorStatus.ServerError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.ErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.ErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.ErrorResult)}");
                serverError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LalalAI.Result2(
                discriminator?.Status,
                success,

                serverError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CancelSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CancelSuccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.CancelSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsServerError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.ErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.ErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.ErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerError!, typeInfo);
            }
        }
    }
}