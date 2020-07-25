using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Use Assert.Throws instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ExpectedExceptionAttribute : Attribute
    {
        public ExpectedExceptionAttribute(Type exceptionType, string message = null)
        {
        }

        public bool AllowDerivedTypes { get; set; }
    }
}
 