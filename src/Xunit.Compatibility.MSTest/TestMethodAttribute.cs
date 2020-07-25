using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Use Fact instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodAttribute : Xunit.SkippableFactAttribute
    {
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class FactAttribute : Xunit.FactAttribute
    {
    }
}
