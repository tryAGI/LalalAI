
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelResponseResultDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelResponseResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelResponseResultDiscriminatorStatus value)
        {
            return value switch
            {
                CancelResponseResultDiscriminatorStatus.ServerError => "server_error",
                CancelResponseResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelResponseResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "server_error" => CancelResponseResultDiscriminatorStatus.ServerError,
                "success" => CancelResponseResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}