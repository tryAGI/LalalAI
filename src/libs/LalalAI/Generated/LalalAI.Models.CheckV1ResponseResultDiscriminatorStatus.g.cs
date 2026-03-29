
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CheckV1ResponseResultDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Progress,
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
    public static class CheckV1ResponseResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckV1ResponseResultDiscriminatorStatus value)
        {
            return value switch
            {
                CheckV1ResponseResultDiscriminatorStatus.Cancelled => "cancelled",
                CheckV1ResponseResultDiscriminatorStatus.Error => "error",
                CheckV1ResponseResultDiscriminatorStatus.Progress => "progress",
                CheckV1ResponseResultDiscriminatorStatus.ServerError => "server_error",
                CheckV1ResponseResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckV1ResponseResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => CheckV1ResponseResultDiscriminatorStatus.Cancelled,
                "error" => CheckV1ResponseResultDiscriminatorStatus.Error,
                "progress" => CheckV1ResponseResultDiscriminatorStatus.Progress,
                "server_error" => CheckV1ResponseResultDiscriminatorStatus.ServerError,
                "success" => CheckV1ResponseResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}