namespace Thalus.CodeContracts.Test.BooleanStatement
{
    public class BooleanStatementExtensionCategoryAttribute : TestCategoryProxyAttribute
    {
        public BooleanStatementExtensionCategoryAttribute() : base($"{nameof(BooleanStatementExtension)}_Category",
            $"{nameof(BooleanStatementExtension)}_Category")

        {
        }
    }
}