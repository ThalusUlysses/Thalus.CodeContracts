namespace Thalus.CodeContracts.Test.ExceedsValue
{
    public class ExceedsValueExtensionTestAttribute : TestProxyAttribute
    {
        public ExceedsValueExtensionTestAttribute(string id, string name = null, string description = null) : base(id,
            name ?? id, $"{nameof(ExceedsValueExtension)}_Test", description)
        {
        }
    }
}