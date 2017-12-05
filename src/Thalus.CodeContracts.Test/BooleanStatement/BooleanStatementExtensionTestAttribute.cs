namespace Thalus.CodeContracts.Test.BooleanStatement
{
    public class BooleanStatementExtensionTestAttribute : TestProxyAttribute
    {
        public BooleanStatementExtensionTestAttribute(string id, string name = null, string description = null) : base(id,
            name ?? id, $"{nameof(BooleanStatementExtension)}_Test", description)
        {
        }
    }
}