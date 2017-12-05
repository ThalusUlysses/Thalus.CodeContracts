using System;

namespace Thalus.CodeContracts.Test
{
#if MSTEST // Todo implement MS-Test here
#elif NUNIT

    public class TestSetupProxyAtttribue : TestSetupAttribute
    {
    }
#else
    public class TestSetupProxyAtttribue : Attribute
    {
    }
#endif
}
