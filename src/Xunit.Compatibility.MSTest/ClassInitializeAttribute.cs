using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Inject IClassFixture<T> instead.")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ClassInitializeAttribute : Attribute
    {
    }

}
