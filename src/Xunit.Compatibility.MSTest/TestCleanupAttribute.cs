using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Implement IDisposable instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestCleanupAttribute : Attribute
    {
    }

}
