using System;

namespace Thalus.CodeContracts.Contracts
{
    public  interface ICodeContract
    {
        Exception Encapsulate(Exception inner, Type exception = null);
    }
}