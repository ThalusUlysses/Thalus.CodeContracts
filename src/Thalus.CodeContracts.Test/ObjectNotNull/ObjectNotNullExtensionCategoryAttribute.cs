namespace Thalus.CodeContracts.Test.ObjectNotNull
{
    public class ObjectNotNullExtensionCategoryAttribute : TestCategoryProxyAttribute
    {
        public ObjectNotNullExtensionCategoryAttribute() : base($"{nameof(ObjectNotNullExtension)}_Category",
            $"{nameof(ObjectNotNullExtension)}_Category")

        {
        }
    }
}