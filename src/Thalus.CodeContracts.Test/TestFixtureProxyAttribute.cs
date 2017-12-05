using System;

namespace Thalus.CodeContracts.Test
{


#if MSTEST

    //ToDo implement MS-Test attributes
#elif NUNIT
    public class TestFixtureProxyAttribute : TestAtrribute
    {
        public TestFixtureProxyAttribute(string id, string name, string description) :base(id,description)
        {

        }
    }
#else
    public class TestFixtureProxyAttribute : Attribute
    {
        public TestFixtureProxyAttribute(string id, string name, string description)
        {

        }
    }

#endif
}