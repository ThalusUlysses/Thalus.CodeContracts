namespace Thalus.CodeContracts.Test.ObjectNotNull
{
    public class ObjectNotNullExtensionTestFixtureAttribute : TestFixtureProxyAttribute
    {
        public ObjectNotNullExtensionTestFixtureAttribute() : base(
            $"{nameof(ObjectNotNullExtension)}_TestFixture", $"{nameof(ObjectNotNullExtension)}_TestFixture", null)
        {
        }
    }
}