namespace Thalus.CodeContracts.Test.ObjectNotNull
{
    public class ObjectNotNullExtensionTestAttribute : TestProxyAttribute
    {
        public ObjectNotNullExtensionTestAttribute(string id, string name = null, string description = null) : base(id,
            name ?? id, $"{nameof(ObjectNotNullExtension)}_Test", description)
        {
        }
    }
}