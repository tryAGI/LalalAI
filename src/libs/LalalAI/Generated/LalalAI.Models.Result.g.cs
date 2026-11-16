#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Result : global::System.IEquatable<Result>
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
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.CancelSuccess? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.CancelSuccess PickSuccess() => Success is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

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
        public bool TryPickServerError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.ErrorResult? value)
        {
            value = ServerError;
            return IsServerError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.ErrorResult PickServerError() => ServerError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result(global::LalalAI.CancelSuccess value) => new Result((global::LalalAI.CancelSuccess?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.CancelSuccess?(Result @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public Result(global::LalalAI.CancelSuccess? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result FromSuccess(global::LalalAI.CancelSuccess? value) => new Result(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result(global::LalalAI.ErrorResult value) => new Result((global::LalalAI.ErrorResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.ErrorResult?(Result @this) => @this.ServerError;

        /// <summary>
        ///
        /// </summary>
        public Result(global::LalalAI.ErrorResult? value)
        {
            ServerError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result FromServerError(global::LalalAI.ErrorResult? value) => new Result(value);

        /// <summary>
        ///
        /// </summary>
        public Result(
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
            global::System.Func<global::LalalAI.CancelSuccess, TResult>? success = null,
            global::System.Func<global::LalalAI.ErrorResult, TResult>? serverError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0 && success != null)
            {
                return success(__value0);
            }
            else if (ServerError is { } __value1 && serverError != null)
            {
                return serverError(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.CancelSuccess>? success = null,

            global::System.Action<global::LalalAI.ErrorResult>? serverError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (ServerError is { } __value1)
            {
                serverError?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LalalAI.CancelSuccess>? success = null,
            global::System.Action<global::LalalAI.ErrorResult>? serverError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (ServerError is { } __value1)
            {
                serverError?.Invoke(__value1);
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
        public bool Equals(Result other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CancelSuccess?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.ErrorResult?>.Default.Equals(ServerError, other.ServerError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Result obj1, Result obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Result obj1, Result obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result o && Equals(o);
        }
    }
}
