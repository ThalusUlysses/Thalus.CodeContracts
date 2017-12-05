using System;

namespace Thalus.CodeContracts.Test
{

#if MSTEST
    //Todo implement MS-Test here
#elif NUNIT
    public class TestProxyAttribute : TestAttribute
    {
        public TestProxyAttribute(string id,string name, string category, string description) : TestAttribute(id,name,category,description)
        {
            
        }
    }
#else
    public class TestProxyAttribute : Attribute
    {
        public TestProxyAttribute(string id,string name, string category, string description)
        {
            
        }
    }
#endif

#if MSTEST
//Todo implement MS-Test here
#elif NUNIT
    public class TestProxyAttribute : TestAttribute
    {
        public TestCategoryProxyAttribute(string id,string description) : CategoryAttribute(id, description)
        {
            
        }
    }
#else
    public class TestCategoryProxyAttribute : Attribute
    {
        public TestCategoryProxyAttribute(string id,string description)
        {

        }
    }
#endif

}