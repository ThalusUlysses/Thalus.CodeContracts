using System;
using System.Data;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts.Test.ObjectNotNull
{
    [ObjectNotNullExtensionTestFixture]
    [ObjectNotNullExtensionCategory]
    public class ObjectNotNullExtensionTestFixture
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
        

        [ObjectNotNullExtensionTest(nameof(UseNotNull_Test))]
        [ObjectNotNullExtensionCategory]
        public void UseNull_Test()
        {
            try
            {
                _contract.IsNotNull(null);

            }
            catch (NoNullAllowedException)
            {
            }
        }

        [ObjectNotNullExtensionTest(nameof(UseNullWithExceptionType_Test))]
        [ObjectNotNullExtensionCategory]
        public void UseNullWithExceptionType_Test()
        {
            try
            {
                _contract.IsNotNull(null, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentNullException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [ObjectNotNullExtensionTest(nameof(UseNullWithBoth_Test))]
        [ObjectNotNullExtensionCategory]

        public void UseNullWithBoth_Test()
        {
            try
            {
                _contract.IsNotNull(null, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [ObjectNotNullExtensionTest(nameof(UseNotNull_Test))]
        [ObjectNotNullExtensionCategory]

        public void UseNotNull_Test()
        {
            _contract.IsNotNull(new object());
        }

        [ObjectNotNullExtensionTest(nameof(UseNotNullWithExceptionType_Test))]
        [ObjectNotNullExtensionCategory]

        public void UseNotNullWithExceptionType_Test()
        {
            try
            {
                _contract.IsNotNull(new object(), "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
    }

        [ObjectNotNullExtensionTest(nameof(UseNotNullWithBoth_Test))]
        [ObjectNotNullExtensionCategory]

        public void UseNotNullWithBoth_Test()
        {
            try
            {
                _contract.IsNotNull(new object(), "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }
    }
}
