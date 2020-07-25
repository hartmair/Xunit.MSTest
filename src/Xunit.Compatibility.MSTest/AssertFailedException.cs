namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public class AssertFailedException : Xunit.Sdk.XunitException
    {
        public AssertFailedException(string message) : base(message)
        {
        }
    }
}
