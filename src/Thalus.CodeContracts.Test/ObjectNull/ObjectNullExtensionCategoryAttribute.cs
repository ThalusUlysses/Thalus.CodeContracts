namespace Thalus.CodeContracts.Test.ObjectNull
{
    public class ObjectNullExtensionCategoryAttribute : TestCategoryProxyAttribute
    {
        public ObjectNullExtensionCategoryAttribute() : base($"{nameof(ObjectNotNullExtension)}_Category",
            $"{nameof(ObjectNotNullExtension)}_Category")

        {
        }
    }
}