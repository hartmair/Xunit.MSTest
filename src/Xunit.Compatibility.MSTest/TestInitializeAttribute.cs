using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Use constructor instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestInitializeAttribute : Attribute
    {
    }

}
