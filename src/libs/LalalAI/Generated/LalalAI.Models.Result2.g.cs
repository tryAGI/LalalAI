#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Result2 : global::System.IEquatable<Result2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LalalAI.CancelResponseResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.CancelSuccess? Success { get; init; }
#else
        public global::LalalAI.CancelSuccess? Success { get; }
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
        public global::LalalAI.ErrorResult? ServerError { get; init; }
#else
        public global::LalalAI.ErrorResult? ServerError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerError))]
#endif
        public bool IsServerError => ServerError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::LalalAI.CancelSuccess value) => new Result2((global::LalalAI.CancelSuccess?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.CancelSuccess?(Result2 @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::LalalAI.CancelSuccess? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::LalalAI.ErrorResult value) => new Result2((global::LalalAI.ErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.ErrorResult?(Result2 @this) => @this.ServerError;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::LalalAI.ErrorResult? value)
        {
            ServerError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result2(
            global::LalalAI.CancelResponseResultDiscriminatorStatus? status,
            global::LalalAI.CancelSuccess? success,
            global::LalalAI.ErrorResult? serverError
            )
        {
            Status = status;

            Success = success;
            ServerError = serverError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ServerError as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            ServerError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsServerError || !IsSuccess && IsServerError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.CancelSuccess?, TResult>? success = null,
            global::System.Func<global::LalalAI.ErrorResult?, TResult>? serverError = null,
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
            else if (IsServerError && serverError != null)
            {
                return serverError(ServerError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.CancelSuccess?>? success = null,
            global::System.Action<global::LalalAI.ErrorResult?>? serverError = null,
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
            else if (IsServerError)
            {
                serverError?.Invoke(ServerError!);
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
                typeof(global::LalalAI.CancelSuccess),
                ServerError,
                typeof(global::LalalAI.ErrorResult),
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
        public bool Equals(Result2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CancelSuccess?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.ErrorResult?>.Default.Equals(ServerError, other.ServerError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Result2 obj1, Result2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Result2 obj1, Result2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result2 o && Equals(o);
        }
    }
}
