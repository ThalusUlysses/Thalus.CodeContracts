namespace Thalus.CodeContracts.Test.BooleanStatement
{
    public class BooleanStatementExtensionTestFixtureAttribute : TestFixtureProxyAttribute
    {
        public BooleanStatementExtensionTestFixtureAttribute() : base(
            $"{nameof(BooleanStatementExtension)}_TestFixture", $"{nameof(BooleanStatementExtension)}_TestFixture", null)
        {
        }
    }
}