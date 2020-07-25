using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        // see https://github.com/xunit/xunit/issues/2027
        [Obsolete("Throw an XunitException instead.")]
        public static void Fail(string message = null)
        {
            throw new Xunit.Sdk.XunitException(message);
        }

        // see https://stackoverflow.com/questions/34610133/xunit-equivelant-of-mstests-assert-inconclusive
        [Obsolete("Use [Fact(Skip)] or [SkippableFact] with Skip.If")]
        public static void Inconclusive(string message)
        {
            throw new Xunit.SkipException(message);
        }
    }
}
