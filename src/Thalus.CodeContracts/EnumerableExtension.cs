using System;
using System.Collections;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts
{
    public static class EnumerableExtension
    {
        public static void HasItems(this ICodeContract c, IEnumerable o, string message = null,
            Type exceptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            c.IsNotNull(o, message, exceptionType);
            IEnumerator e = o.GetEnumerator();

            c.IsNotNull(e, message, exceptionType);

            if (e.Current == null)
            {
                e.Reset();
                throw c.Encapsulate(new ArgumentOutOfRangeException($"Code Contract harmed, {nameof(o)} has no items. {message}"),
                    exceptionType);
            }

            e.Reset();
        }

        public static void HasAtLeast(this ICodeContract c, IEnumerable o, int items, string message = null,
            Type exceptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            c.IsNotNull(o, message, exceptionType);
            var e = o.GetEnumerator();

            int idx = 0;
            while (e.Current != null && e.MoveNext())
            {
                if (idx >= items)
                {
                    return;
                }
                idx++;
            }

            throw c.Encapsulate(
                new ArgumentOutOfRangeException(
                    $"Code Contract harmed, has less items than {idx} < {items}. {message}"), exceptionType
                );
        }

        public static void HasNoItems(this ICodeContract c, IEnumerable o, string message = null,
            Type exceptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            c.IsNotNull(o, message, exceptionType);
            IEnumerator e = o.GetEnumerator();

            c.IsNotNull(e, message, exceptionType);

            if (e.Current == null)
            {
                e.Reset();
                throw c.Encapsulate(new ArgumentOutOfRangeException($"Code Contract harmed, {nameof(o)} has items. {message}"),
                    exceptionType);
            }

            e.Reset();
        }
    }
}