namespace Thalus.CodeContracts.Test.ObjectNull
{
    public class ObjectNullExtensionTestFixtureAttribute : TestFixtureProxyAttribute
    {
        public ObjectNullExtensionTestFixtureAttribute() : base(
            $"{nameof(ObjectNullExtension)}_TestFixture", $"{nameof(ObjectNullExtension)}_TestFixture", null)
        {
        }
    }
}