using System;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts
{
    public static class ObjectNullExtension
    {
        public static void IsNull(this ICodeContract c, object o, string message = null, Type exceptionType = null
            )
        {
            CodeContract.EnsureCodeContract(c);

            if (o != null)
            {
                throw c.Encapsulate(new ArgumentException($"Code Contract harmed, not null is not allowed. {message}"),
                    exceptionType);
            }
        }
    }
}