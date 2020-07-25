using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        public static void Throws<T>(Action testCode)
            where T : Exception
        {
            Xunit.Assert.Throws<T>(testCode);
        }
    }
}
