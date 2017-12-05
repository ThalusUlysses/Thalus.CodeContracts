using System;
using Thalus.CodeContracts.Contracts;
using Thalus.CodeContracts.Test.ObjectNull;

namespace Thalus.CodeContracts.Test.BooleanStatement
{
    [BooleanStatementExtensionTestFixture]
    [BooleanStatementExtensionCategory]
    public class BooleanFalseStatementExtensionTestFixture
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
        

        [BooleanStatementExtensionTest(nameof(CheckFalseOk_Test))]
        [BooleanStatementExtensionCategory]
        public void CheckFalseOk_Test()
        {
            _contract.IsFalse(false);
        }

        [BooleanStatementExtensionTest(nameof(CheckFalseOkWithExceptionType_Test))]
        [ObjectNullExtensionCategory]
        public void CheckFalseOkWithExceptionType_Test()
        {
            try
            {
                _contract.IsFalse(false, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [BooleanStatementExtensionTest(nameof(CheckFalseOkWithBoth_Test))]
        [ObjectNullExtensionCategory]

        public void CheckFalseOkWithBoth_Test()
        {
            try
            {
                _contract.IsFalse(false, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

       
        [BooleanStatementExtensionTest(nameof(CheckFalseFail_Test))]
        [ObjectNullExtensionCategory]

        public void CheckFalseFail_Test()
        {
            try
            {
                _contract.IsFalse(true);
            }
            catch (ArgumentException)
            {

            }
        }

        [BooleanStatementExtensionTest(nameof(CheckFalseFailWithExceptionType_Test))]
        [ObjectNullExtensionCategory]

        public void CheckFalseFailWithExceptionType_Test()
        {
            try
            {
                _contract.IsFalse(true, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

    
        [BooleanStatementExtensionTest(nameof(CheckFalseFailWithBoth_Test))]
        [ObjectNullExtensionCategory]

        public void CheckFalseFailWithBoth_Test()
        {
            try
            {
                _contract.IsFalse(true, "Test Message", typeof(ArgumentNullException));
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
