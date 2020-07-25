using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Remove this attribute.")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TestClassAttribute : Attribute
    {

    }
}
