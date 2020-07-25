using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        [Obsolete("Use Equal instead.")]
        public static void AreEqual<T>(T expected, T actual, string message = null)
        {
            Xunit.Assert.Equal(expected, actual);
        }
        public static void Equal<T>(T expected, T actual)
        {
            Xunit.Assert.Equal(expected, actual);
        }
        [Obsolete("Use Equal instead.")]
        public static void AreEqual(string expected, string actual, string message = null)
        {
            Xunit.Assert.Equal(expected, actual);
        }

        [Obsolete("Use NotEqual instead.")]
        public static void AreNotEqual<T>(T expected, T actual)
        {
            Xunit.Assert.NotEqual(expected, actual);
        }
        public static void NotEqual<T>(T expected, T actual)
        {
            Xunit.Assert.NotEqual(expected, actual);
        }
    }
}
