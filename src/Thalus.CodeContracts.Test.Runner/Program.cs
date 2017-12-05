using System;
using Thalus.CodeContracts.Test.BooleanStatement;
using Thalus.CodeContracts.Test.ExceedsValue;
using Thalus.CodeContracts.Test.ObjectNotNull;
using Thalus.CodeContracts.Test.ObjectNull;

namespace Thalus.CodeContracts.Test.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ObjectNullExtensionTestFixture f = new ObjectNullExtensionTestFixture();

                f.Setup();
                f.UseNull_Test();
                f.UseNullWithExceptionType_Test();
                f.UseNotNull_Test();
                f.UseNotNullWithExceptionType_Test();
                
                f.Teardown();

                ObjectNotNullExtensionTestFixture oNotNull = new ObjectNotNullExtensionTestFixture();

                oNotNull.Setup();
                oNotNull.UseNull_Test();
                oNotNull.UseNullWithExceptionType_Test();
                oNotNull.UseNotNull_Test();
                oNotNull.UseNotNullWithExceptionType_Test();
                oNotNull.Teardown();

                BooleanFalseStatementExtensionTestFixture falseFixture = new BooleanFalseStatementExtensionTestFixture();

                falseFixture.Setup();
                falseFixture.CheckFalseOk_Test();
                falseFixture.CheckFalseOkWithExceptionType_Test();
                falseFixture.CheckFalseFail_Test();
                falseFixture.CheckFalseFailWithExceptionType_Test();
                falseFixture.Teardown();

                BooleanTrueStatementExtensionTestFixture trueFixture = new BooleanTrueStatementExtensionTestFixture();

                trueFixture.Setup();
                trueFixture.CheckTrueOk_Test();
                trueFixture.CheckTrueOkWithExceptionType_Test();
                trueFixture.ChckTrueFail_Test();
                trueFixture.CheckTrueFailWithExceptionType_Test();
                trueFixture.Teardown();

                ExceedsIntValueExtensionTestFixture intFixture = new ExceedsIntValueExtensionTestFixture();

                intFixture.Setup();
                intFixture.CheckExceedsOk_Test();
                intFixture.CheckExceedsOkWithExceptionType_Test();
                intFixture.CheckExceedsFail_Test();
                intFixture.CheckExceedsOkWithExceptionType_Test();
                intFixture.Teardown();

                ExceedsDoubleValueExtensionTestFixture doubleFixture = new ExceedsDoubleValueExtensionTestFixture();

                doubleFixture.Setup();
                doubleFixture.CheckExceedsOk_Test();
                doubleFixture.CheckExceedsOkWithExceptionType_Test();
                doubleFixture.CheckExceedsFail_Test();
                doubleFixture.CheckExceedsOkWithExceptionType_Test();
                doubleFixture.Teardown();

            }
            catch (Exception e)
            {
                Environment.Exit(1);
                Console.ReadKey();
            }
        }
    }
}
