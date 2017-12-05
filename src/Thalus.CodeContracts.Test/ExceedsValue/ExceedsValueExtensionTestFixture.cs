using System;
using Thalus.CodeContracts.Contracts;

namespace Thalus.CodeContracts.Test.ExceedsValue
{
    [ExceedsValueExtensionTestFixture]
    [ExceedsValueExtensionCategory]
    public class ExceedsValueExtensionTestFixture<TType,TTypeB>
    {
        private TType _aValue;
        private TTypeB _limitValue;
        private ICodeContract _contract;

        public ExceedsValueExtensionTestFixture(TType aValue, TTypeB limitValue)
        {
            _aValue = aValue;
            _limitValue = limitValue;
        }

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
        

        [ExceedsValueExtensionTest(nameof(CheckExceedsFail_Test))]
        [ExceedsValueExtensionCategory]
        public void CheckExceedsOk_Test()
        {
            _contract.ExceedsMax(_aValue, _limitValue);
        }

        [ExceedsValueExtensionTest(nameof(CheckExceedsOkWithExceptionType_Test))]
        [ExceedsValueExtensionCategory]
        public void CheckExceedsOkWithExceptionType_Test()
        {
            try
            {
                _contract.ExceedsMax(_aValue,_limitValue, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [ExceedsValueExtensionTest(nameof(CheckExceedsOkWithBoth_Test))]
        [ExceedsValueExtensionCategory]

        public void CheckExceedsOkWithBoth_Test()
        {
            try
            {
                _contract.ExceedsMax(_aValue,_limitValue, "Test Message", typeof(ArgumentNullException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

        [ExceedsValueExtensionTest(nameof(CheckExceedsFail_Test))]
        [ExceedsValueExtensionCategory]

        public void CheckExceedsFail_Test()
        {
            try
            {
                _contract.ExceedsMax(_limitValue, _aValue);

            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        [ExceedsValueExtensionTest(nameof(CheckExceedsFailWithExceptionType_Test))]
        [ExceedsValueExtensionCategory]

        public void CheckExceedsFailWithExceptionType_Test()
        {
            try
            {
                _contract.ExceedsMax(_limitValue,_aValue, "Test Message", typeof(ArgumentException));
            }
            catch (ArgumentException e)
            {
                if (!e.Message.Contains("Test Message"))
                {
                    throw;
                }
            }
        }

       
        [ExceedsValueExtensionTest(nameof(CheckExceedsFailWithBoth_Test))]
        [ExceedsValueExtensionCategory]

        public void CheckExceedsFailWithBoth_Test()
        {
            try
            {
                _contract.ExceedsMax(_limitValue, _aValue, "Test Message", typeof(ArgumentException));
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
