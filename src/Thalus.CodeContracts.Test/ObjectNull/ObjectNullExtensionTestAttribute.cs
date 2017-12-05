namespace Thalus.CodeContracts.Test.ObjectNull
{
    public class ObjectNullExtensionTestAttribute : TestProxyAttribute
    {
        public ObjectNullExtensionTestAttribute(string id, string name = null, string description = null) : base(id,
            name ?? id, $"{nameof(ObjectNullExtension)}_Test", description)
        {
        }
    }
}