using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class Assert
    {
        [Obsolete("Use Null instead.")]
        public static void IsNull(object value, string message = null)
        {
            Xunit.Assert.Null(value);
        }
        public static void Null(object @object)
        {
            Xunit.Assert.Null(@object);
        }
        [Obsolete("Use NotNull instead.")]
        public static void IsNotNull(object value, string message = null)
        {
            Xunit.Assert.NotNull(value);
        }
        public static void NotNull(object @object)
        {
            Xunit.Assert.NotNull(@object);
        }
    }
}
