#if NETSTANDARD2_0
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NHibernate;

namespace CSharpFunctionalExtensions
{
    public static class ResultExtensions
    {
        // Non-async extensions
        [DebuggerStepThrough]
        public static Result<K> OnSuccessWithNHibernateTransaction<T, K>(this Result<T> self, ISession session, Func<T, K> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Result<T> OnSuccessWithNHibernateTransaction<T>(this Result self, ISession session, Func<T> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Result<K> OnSuccessWithNHibernateTransaction<T, K>(this Result<T> self, ISession session, Func<T, Result<K>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Result<T> OnSuccessWithNHibernateTransaction<T>(this Result self, ISession session, Func<Result<T>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Result<K> OnSuccessWithNHibernateTransaction<T, K>(this Result<T> self, ISession session, Func<Result<K>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Result OnSuccessWithNHibernateTransaction<T>(this Result<T> self, ISession session, Func<T, Result> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Result OnSuccessWithNHibernateTransaction(this Result self, ISession session, Func<Result> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        // Async - Both Operands
        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<T, Task<K>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> OnSuccessWithNHibernateTransaction<T>(this Task<Result> self, ISession session, Func<Task<T>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<T, Task<Result<K>>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> OnSuccessWithNHibernateTransaction<T>(this Task<Result> self, ISession session, Func<Task<Result<T>>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<Task<Result<K>>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result> OnSuccessWithNHibernateTransaction<T>(this Task<Result<T>> self, ISession session, Func<T, Task<Result>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result> OnSuccessWithNHibernateTransaction(this Task<Result> self, ISession session, Func<Task<Result>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        // Async - Left Operands
        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<T, K> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> OnSuccessWithNHibernateTransaction<T>(this Task<Result> self, ISession session, Func<T> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<T, Result<K>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> OnSuccessWithNHibernateTransaction<T>(this Task<Result> self, ISession session, Func<Result<T>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<Result<K>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result> OnSuccessWithNHibernateTransaction<T>(this Task<Result<T>> self, ISession session, Func<T, Result> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result> OnSuccessWithNHibernateTransaction(this Task<Result> self, ISession session, Func<Result> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> MapWithNHibernateTransaction<T, K>(this Task<Result<T>> self, ISession session, Func<T, K> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> MapWithNHibernateTransaction<T>(this Task<Result> self, ISession session, Func<T> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        // Async - Right Operands
        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Result<T> self, ISession session, Func<T, Task<K>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> OnSuccessWithNHibernateTransaction<T>(this Result self, ISession session, Func<Task<T>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Result<T> self, ISession session, Func<T, Task<Result<K>>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<T>> OnSuccessWithNHibernateTransaction<T>(this Result self, ISession session, Func<Task<Result<T>>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result<K>> OnSuccessWithNHibernateTransaction<T, K>(this Result<T> self, ISession session, Func<Task<Result<K>>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result> OnSuccessWithNHibernateTransaction<T>(this Result<T> self, ISession session, Func<T, Task<Result>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        [DebuggerStepThrough]
        public static Task<Result> OnSuccessWithNHibernateTransaction(this Result self, ISession session, Func<Task<Result>> f) =>
            WithNHibernateTransaction(session, () => self.OnSuccess(f));

        private static T WithNHibernateTransaction<T>(ISession session, Func<T> f)
            where T : IResult
        {
            using (var tx = session.BeginTransaction())
            {
                var result = f();
                if (result.IsSuccess)
                {
                    tx.Commit();
                }
                return result;
            }
        }

        private async static Task<T> WithNHibernateTransactionAsync<T>(ISession session, Func<Task<T>> f)
            where T : IResult
        {
            using (var tx = session.BeginTransaction())
            {
                var result = await f().ConfigureAwait(Result.DefaultConfigureAwait);
                if (result.IsSuccess)
                {
                    await tx.CommitAsync();
                }
                return result;
            }
        }
    }
}
#endif
