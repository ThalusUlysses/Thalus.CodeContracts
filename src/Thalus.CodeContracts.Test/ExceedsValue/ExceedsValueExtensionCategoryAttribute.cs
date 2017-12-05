namespace Thalus.CodeContracts.Test.ExceedsValue
{
    public class ExceedsValueExtensionCategoryAttribute : TestCategoryProxyAttribute
    {
        public ExceedsValueExtensionCategoryAttribute() : base($"{nameof(ExceedsValueExtension)}_Category",
            $"{nameof(ExceedsValueExtension)}_Category")

        {
        }
    }
}