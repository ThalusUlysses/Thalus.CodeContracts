using System;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts.Test.ObjectNull
{
    [ObjectNullExtensionTestFixture]
    [ObjectNullExtensionCategory]
    public class ObjectNullExtensionTestFixture
    {
        private ICodeContract _contract;

        [TestSetupProxyAtttribue]
        public void Setup()
        {
            _contract = new CodeContract();

        }

        [TestTeardownProxyAttribue]
        public void Teardown()
        {
            _contract = null;
        }
        

        [ObjectNullExtensionTest(nameof(UseNotNull_Test))]
        [ObjectNullExtensionCategory]
        public void UseNull_Test()
        {
            _contract.IsNull(null);
        }

        [ObjectNullExtensionTest(nameof(UseNullWithExceptionType_Test))]
        [ObjectNullExtensionCategory]
        public void UseNullWithExceptionType_Test()
        {
            try
            {
                _contract.IsNull(null, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [ObjectNullExtensionTest(nameof(UseNullWithBoth_Test))]
        [ObjectNullExtensionCategory]

        public void UseNullWithBoth_Test()
        {
            try
            {
                _contract.IsNull(null, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

  
        [ObjectNullExtensionTest(nameof(UseNotNull_Test))]
        [ObjectNullExtensionCategory]

        public void UseNotNull_Test()
        {
            try
            {


                _contract.IsNull(new object());
            }
            catch (ArgumentException)
            {
               
            }
        }

        [ObjectNullExtensionTest(nameof(UseNotNullWithExceptionType_Test))]
        [ObjectNullExtensionCategory]

        public void UseNotNullWithExceptionType_Test()
        {
            try
            {
                _contract.IsNull(new object(), "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentNullException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [ObjectNullExtensionTest(nameof(UseNotNullWithBoth_Test))]
        [ObjectNullExtensionCategory]

        public void UseNotNullWithBoth_Test()
        {
            try
            {
                _contract.IsNull(new object(), "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentNullException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }
    }
}
