#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultsItem : global::System.IEquatable<ResultsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LalalAI.BatchTasksResponseResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.SuccessfulTaskStart? Success { get; init; }
#else
        public global::LalalAI.SuccessfulTaskStart? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.FailedTaskStart? Error { get; init; }
#else
        public global::LalalAI.FailedTaskStart? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::LalalAI.SuccessfulTaskStart value) => new ResultsItem((global::LalalAI.SuccessfulTaskStart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.SuccessfulTaskStart?(ResultsItem @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::LalalAI.SuccessfulTaskStart? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::LalalAI.FailedTaskStart value) => new ResultsItem((global::LalalAI.FailedTaskStart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.FailedTaskStart?(ResultsItem @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::LalalAI.FailedTaskStart? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(
            global::LalalAI.BatchTasksResponseResultDiscriminatorStatus? status,
            global::LalalAI.SuccessfulTaskStart? success,
            global::LalalAI.FailedTaskStart? error
            )
        {
            Status = status;

            Success = success;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsError || !IsSuccess && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.SuccessfulTaskStart?, TResult>? success = null,
            global::System.Func<global::LalalAI.FailedTaskStart?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.SuccessfulTaskStart?>? success = null,
            global::System.Action<global::LalalAI.FailedTaskStart?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::LalalAI.SuccessfulTaskStart),
                Error,
                typeof(global::LalalAI.FailedTaskStart),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResultsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.SuccessfulTaskStart?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.FailedTaskStart?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultsItem obj1, ResultsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultsItem obj1, ResultsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultsItem o && Equals(o);
        }
    }
}
