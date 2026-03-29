
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskStartErrorCodes
    {
        /// <summary>
        /// 
        /// </summary>
        IdempotencyKeyUsed,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStartErrorCodesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStartErrorCodes value)
        {
            return value switch
            {
                TaskStartErrorCodes.IdempotencyKeyUsed => "idempotency_key_used",
                TaskStartErrorCodes.InternalError => "internal_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStartErrorCodes? ToEnum(string value)
        {
            return value switch
            {
                "idempotency_key_used" => TaskStartErrorCodes.IdempotencyKeyUsed,
                "internal_error" => TaskStartErrorCodes.InternalError,
                _ => null,
            };
        }
    }
}