using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Inject IClassFixture<T> instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ClassCleanupAttribute : Attribute
    {
    }

}
