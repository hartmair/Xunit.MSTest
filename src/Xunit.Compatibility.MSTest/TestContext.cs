using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Inject ITestOutputHelper instead.")]
    public class TestContext
    {
        public static void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }

}
