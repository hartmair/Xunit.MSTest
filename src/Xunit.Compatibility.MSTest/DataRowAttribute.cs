using System;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    // https://github.com/xunit/xunit/blob/main/src/xunit.v3.core/InlineDataAttribute.cs is sealed
    [Obsolete("Use InlineData instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class DataRowAttribute : Xunit.Sdk.DataAttribute
    {
        readonly object[] data;
        public DataRowAttribute(params object[] data)
        {
            this.data = data;
        }
        /// <inheritdoc/>
        public override IEnumerable<object[]> GetData(MethodInfo testMethod) => new[] { data };
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InlineDataAttribute : DataRowAttribute
    {
        public InlineDataAttribute(params object[] data) : base(data)
        {
        }
    }
}
