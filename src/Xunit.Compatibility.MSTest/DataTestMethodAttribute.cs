using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Use Theory instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class DataTestMethodAttribute : Xunit.SkippableTheoryAttribute
    {
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TheoryAttribute : Xunit.TheoryAttribute
    {
    }
}
