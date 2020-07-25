using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        [Obsolete("Use True instead.")]
        public static void IsTrue(bool condition, string message = null)
        {
            Xunit.Assert.True(condition, message);
        }
        public static void True(bool condition, string message = null)
        {
            Xunit.Assert.True(condition, message);
        }

        [Obsolete("Use False instead.")]
        public static void IsFalse(bool condition, string message = null)
        {
            Xunit.Assert.False(condition, message);
        }
        public static void False(bool condition, string message = null)
        {
            Xunit.Assert.False(condition, message);
        }
    }
}
