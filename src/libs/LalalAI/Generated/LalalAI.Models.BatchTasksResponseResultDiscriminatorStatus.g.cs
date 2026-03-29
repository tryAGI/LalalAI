
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchTasksResponseResultDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchTasksResponseResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchTasksResponseResultDiscriminatorStatus value)
        {
            return value switch
            {
                BatchTasksResponseResultDiscriminatorStatus.Error => "error",
                BatchTasksResponseResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchTasksResponseResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => BatchTasksResponseResultDiscriminatorStatus.Error,
                "success" => BatchTasksResponseResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}