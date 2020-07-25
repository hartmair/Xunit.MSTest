namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        public static void IsType<T>(object @object)
        {
            Xunit.Assert.IsType<T>(@object);
        }
        public static void IsNotType<T>(object @object)
        {
            Xunit.Assert.IsNotType<T>(@object);
        }
    }
}
