using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        [Obsolete("Use Same instead.")]
        public static void AreSame(object expected, object actual, string message = null)
        {
            Xunit.Assert.Same(expected, actual);
        }
        public static void Same(object expected, object actual)
        {
            Xunit.Assert.Same(expected, actual);
        }
        [Obsolete("Use NotSame instead.")]
        public static void AreNotSame(object expected, object actual, string message = null)
        {
            Xunit.Assert.NotSame(expected, actual);
        }
        public static void NotSame(object expected, object actual)
        {
            Xunit.Assert.NotSame(expected, actual);
        }
    }
}
