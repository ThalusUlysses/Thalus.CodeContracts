using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts
{
    public class CodeContract : ICodeContract
    {
        private static object _syncStaticElements = new object();
        private static Lazy<CodeContract> _staticLazyContract;

        public static void CreationMethod(Func<CodeContract> c)
        {
            lock (_syncStaticElements)
            {
                _staticLazyContract = new Lazy<CodeContract>(c);

            }
        }

        public static CodeContract Contract()
        {
            lock (_syncStaticElements)
            {
                return _staticLazyContract.Value;
            }
        }

        public  Exception Encapsulate(Exception inner,Type exception = null)
        {
            try
            {
                if (exception != null)
                {
                    inner = (Exception) Activator.CreateInstance(exception, inner.Message, inner);
                }

                return inner;

            }
            catch (Exception e)
            {
                return e;
            }
        }

        internal static void EnsureCodeContract(ICodeContract c)
        {
            if (c == null)
            {
                throw new NullReferenceException($"{nameof(c)} is null");
            }
        }

    }
}
