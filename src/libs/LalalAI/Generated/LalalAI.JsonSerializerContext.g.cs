
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LalalAI.JsonConverters.CheckV1CancelledResultPresetsDiscriminatorLabelJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1CancelledResultPresetsDiscriminatorLabelNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1ErrorResultPresetsDiscriminatorLabelJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1ErrorResultPresetsDiscriminatorLabelNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1ProgressResultPresetsDiscriminatorLabelJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1ProgressResultPresetsDiscriminatorLabelNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1ResponseResultDiscriminatorStatusJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1ResponseResultDiscriminatorStatusNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1SuccessResultPresetsDiscriminatorLabelJsonConverter),

            typeof(global::LalalAI.JsonConverters.CheckV1SuccessResultPresetsDiscriminatorLabelNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.EncoderFormatJsonConverter),

            typeof(global::LalalAI.JsonConverters.EncoderFormatNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.ExtractionLevelJsonConverter),

            typeof(global::LalalAI.JsonConverters.ExtractionLevelNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.MultistemSplitterPresetsV1StemListItemJsonConverter),

            typeof(global::LalalAI.JsonConverters.MultistemSplitterPresetsV1StemListItemNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.SplitTrackTypeJsonConverter),

            typeof(global::LalalAI.JsonConverters.SplitTrackTypeNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.SplitterTypeJsonConverter),

            typeof(global::LalalAI.JsonConverters.SplitterTypeNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.StemSeparatorSplitterPresetsV1StemJsonConverter),

            typeof(global::LalalAI.JsonConverters.StemSeparatorSplitterPresetsV1StemNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.TonalityReferenceJsonConverter),

            typeof(global::LalalAI.JsonConverters.TonalityReferenceNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.CancelResponseResultDiscriminatorStatusJsonConverter),

            typeof(global::LalalAI.JsonConverters.CancelResponseResultDiscriminatorStatusNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.BatchTasksResponseResultDiscriminatorStatusJsonConverter),

            typeof(global::LalalAI.JsonConverters.BatchTasksResponseResultDiscriminatorStatusNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.LicenseErrorCodesJsonConverter),

            typeof(global::LalalAI.JsonConverters.LicenseErrorCodesNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.TaskStartErrorCodesJsonConverter),

            typeof(global::LalalAI.JsonConverters.TaskStartErrorCodesNullableJsonConverter),

            typeof(global::LalalAI.JsonConverters.PresetsJsonConverter),

            typeof(global::LalalAI.JsonConverters.PresetsVariant2JsonConverter),

            typeof(global::LalalAI.JsonConverters.Presets2JsonConverter),

            typeof(global::LalalAI.JsonConverters.PresetsVariant22JsonConverter),

            typeof(global::LalalAI.JsonConverters.Presets3JsonConverter),

            typeof(global::LalalAI.JsonConverters.PresetsVariant23JsonConverter),

            typeof(global::LalalAI.JsonConverters.ResultJsonConverter),

            typeof(global::LalalAI.JsonConverters.Presets4JsonConverter),

            typeof(global::LalalAI.JsonConverters.PresetsVariant24JsonConverter),

            typeof(global::LalalAI.JsonConverters.Result2JsonConverter),

            typeof(global::LalalAI.JsonConverters.ResultsItemJsonConverter),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.TaskStartErrorCodes?, global::LalalAI.LicenseErrorCodes?>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>),

            typeof(global::LalalAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.UploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ApiV1ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CommonErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfStringObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1CancelledResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Presets), TypeInfoPropertyName = "Presets5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoiceChangePresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant2), TypeInfoPropertyName = "PresetsVariant25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.DemuserSplitterPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoiceCleanPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitterPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1CancelledResultPresetsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1CancelledResultPresetsDiscriminatorLabel), TypeInfoPropertyName = "CheckV1CancelledResultPresetsDiscriminatorLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1CancelledResultPresetsDiscriminator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Presets2), TypeInfoPropertyName = "Presets22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant22), TypeInfoPropertyName = "PresetsVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ErrorResultPresetsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ErrorResultPresetsDiscriminatorLabel), TypeInfoPropertyName = "CheckV1ErrorResultPresetsDiscriminatorLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ErrorResultPresetsDiscriminator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.TaskMetaError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ProgressResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Presets3), TypeInfoPropertyName = "Presets32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant23), TypeInfoPropertyName = "PresetsVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ProgressResultPresetsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ProgressResultPresetsDiscriminatorLabel), TypeInfoPropertyName = "CheckV1ProgressResultPresetsDiscriminatorLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ProgressResultPresetsDiscriminator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Result), TypeInfoPropertyName = "Result3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1SuccessResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1ResponseResultDiscriminatorStatus), TypeInfoPropertyName = "CheckV1ResponseResultDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Presets4), TypeInfoPropertyName = "Presets42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant24), TypeInfoPropertyName = "PresetsVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1SuccessResultPresetsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1SuccessResultPresetsDiscriminatorLabel), TypeInfoPropertyName = "CheckV1SuccessResultPresetsDiscriminatorLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1SuccessResultPresetsDiscriminator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SplitTracksResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SplitterType), TypeInfoPropertyName = "SplitterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.EncoderFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ExtractionLevel), TypeInfoPropertyName = "ExtractionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.MultistemSplitterPresetsV1StemListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem), TypeInfoPropertyName = "MultistemSplitterPresetsV1StemListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SplitTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SplitTrackType), TypeInfoPropertyName = "SplitTrackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.SplitTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem), TypeInfoPropertyName = "StemSeparatorSplitterPresetsV1Stem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.TonalityReference), TypeInfoPropertyName = "TonalityReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CheckV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Result2), TypeInfoPropertyName = "Result22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CancelSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CancelResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CancelResponseResultDiscriminatorStatus), TypeInfoPropertyName = "CancelResponseResultDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.DeleteParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.LimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.DemuserSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoiceCleanSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.BatchTasksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.ResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ResultsItem), TypeInfoPropertyName = "ResultsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SuccessfulTaskStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.FailedTaskStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.BatchTasksResponseResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.BatchTasksResponseResultDiscriminatorStatus), TypeInfoPropertyName = "BatchTasksResponseResultDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<global::LalalAI.TaskStartErrorCodes?, global::LalalAI.LicenseErrorCodes?>), TypeInfoPropertyName = "AnyOfTaskStartErrorCodesLicenseErrorCodes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.TaskStartErrorCodes), TypeInfoPropertyName = "TaskStartErrorCodes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.LicenseErrorCodes), TypeInfoPropertyName = "LicenseErrorCodes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.BatchStemSeparatorSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.StemSeparatorSplitParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.BatchDemuserSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.DemuserSplitParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.BatchVoiceCleanSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.VoiceCleanSplitParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoiceChangeParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoicePackInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoicePackListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.VoicePackInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>), TypeInfoPropertyName = "AnyOfApiV1ErrorResponseCommonErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.MultistemSplitterPresetsV1StemListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.SplitTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.ResultsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.StemSeparatorSplitParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.DemuserSplitParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.VoiceCleanSplitParameters>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.VoicePackInfo>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}