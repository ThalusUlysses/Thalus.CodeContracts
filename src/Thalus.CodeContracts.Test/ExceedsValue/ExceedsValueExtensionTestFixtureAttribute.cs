namespace Thalus.CodeContracts.Test.ExceedsValue
{
    public class ExceedsValueExtensionTestFixtureAttribute : TestFixtureProxyAttribute
    {
        public ExceedsValueExtensionTestFixtureAttribute() : base(
            $"{nameof(ExceedsValueExtension)}_TestFixture", $"{nameof(ExceedsValueExtension)}_TestFixture", null)
        {
        }
    }
}