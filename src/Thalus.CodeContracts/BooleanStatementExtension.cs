using System;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts
{
    public static class BooleanStatementExtension
    {
        public static void IsTrue(this ICodeContract c, bool o, string message = null, Type exceptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            if (!o)
            {
                throw c.Encapsulate(new ArgumentException($"Code Contract harmed, false is not allowed. {message}"),
                    exceptionType);
            }
        }

        public static void IsFalse(this ICodeContract c, bool o, string message = null, Type exceptionType = null
            )
        {
            CodeContract.EnsureCodeContract(c);

            if (o)
            {
                throw c.Encapsulate(new ArgumentException($"Code Contract harmed, true is not allowed. {message}"),
                    exceptionType);
            }
        }
    }
}