using System;

namespace Thalus.CodeContracts.Test
{
#if MSTEST
    //ToDo implement MS-Test
#elif NUNIT
    public class TestTeardownProxyAttribue : TestTEardownAttribute
    {
    }
#else
    public class TestTeardownProxyAttribue : Attribute
    {
    }
#endif

}