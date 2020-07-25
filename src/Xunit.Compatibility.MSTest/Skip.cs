namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Skip
    {
        public static void If(bool condition, string message = null)
        {
            Xunit.Skip.If(condition, message);
        }
        public static void IfNot(bool condition, string message = null)
        {
            Xunit.Skip.IfNot(condition, message);
        }
    }

}
