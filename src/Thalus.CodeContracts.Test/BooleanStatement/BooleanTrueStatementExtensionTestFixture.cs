using System;
using Thalus.CodeContracts.Contracts;
using Thalus.CodeContracts.Test.ObjectNull;

namespace Thalus.CodeContracts.Test.BooleanStatement
{
    [BooleanStatementExtensionTestFixture]
    [BooleanStatementExtensionCategory]
    public class BooleanTrueStatementExtensionTestFixture
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
        

        [BooleanStatementExtensionTest(nameof(CheckTrueOk_Test))]
        [BooleanStatementExtensionCategory]
        public void CheckTrueOk_Test()
        {
            _contract.IsTrue(true);
        }

        [BooleanStatementExtensionTest(nameof(CheckTrueOkWithExceptionType_Test))]
        [ObjectNullExtensionCategory]
        public void CheckTrueOkWithExceptionType_Test()
        {
            try
            {
                _contract.IsTrue(true, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [BooleanStatementExtensionTest(nameof(CheckTrueOkWithBoth_Test))]
        [ObjectNullExtensionCategory]

        public void CheckTrueOkWithBoth_Test()
        {
            try
            {
                _contract.IsTrue(true, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

      
        [BooleanStatementExtensionTest(nameof(ChckTrueFail_Test))]
        [ObjectNullExtensionCategory]

        public void ChckTrueFail_Test()
        {
            try
            {
                _contract.IsTrue(false);
            }
            catch (ArgumentException e)
            {

            }
        }

        [BooleanStatementExtensionTest(nameof(CheckTrueFailWithExceptionType_Test))]
        [ObjectNullExtensionCategory]

        public void CheckTrueFailWithExceptionType_Test()
        {
            try
            {
                _contract.IsTrue(false, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

     

        [BooleanStatementExtensionTest(nameof(CheckTrueFailWithBoth_Test))]
        [ObjectNullExtensionCategory]

        public void CheckTrueFailWithBoth_Test()
        {
            try
            {
                _contract.IsTrue(false, "Test Message", typeof(ArgumentNullException));
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
