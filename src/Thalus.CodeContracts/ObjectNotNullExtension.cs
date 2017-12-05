using System;
using System.Data;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts
{
    public static class ObjectNotNullExtension
    {
        /// <summary>
        /// Extends <see cref="ICodeContract"/> with null check capability.
        /// </summary>
        /// <param name="c">Extends <see cref="ICodeContract"/></param>
        /// <param name="a">Pass the to be checked <see cref="object"/></param>
        /// <param name="message">Pass an additional message to be add to exception in case of harming the contract</param>
        /// <param name="exeptionType">Pass an additional exception type the thrown exception should be wrapped into in case of harming the contract</param>
        /// <param name="exeptionName">Pass an additional exception type name the thrown exception should be wrapped into in case of harming the contract</param>
        public static void IsNotNull(this ICodeContract c, object a, string message = null, Type exeptionType = null)
        {
            CodeContract.EnsureCodeContract(c);

            if (a == null)
            {
                throw c.Encapsulate(new NoNullAllowedException($"Code Contract harmed, null is not allowed. {message}"),
                    exeptionType);
            }
        }
    }
}