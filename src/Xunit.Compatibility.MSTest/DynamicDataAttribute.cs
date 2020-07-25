using System;
using System.Reflection;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
	// https://github.com/xunit/xunit/blob/main/src/xunit.v3.core/MemberDataAttribute.cs is sealed

	[Obsolete("Use MemberData instead.")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class DynamicDataAttribute : Xunit.MemberDataAttributeBase
    {
		public DynamicDataAttribute(string memberName, params object[] parameters)
			: base(memberName, parameters)
		{ }

		/// <inheritdoc/>
		protected override object[] ConvertDataItem(MethodInfo testMethod, object item)
		{
			if (item == null) return new object[0];
			if (!(item is object[] array)) throw new ArgumentException($"Property {MemberName} on {MemberType ?? testMethod.DeclaringType} yielded an item that is not an object?[]");
			return array;
		}
	}
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class MemberDataAttribute : DynamicDataAttribute
	{
		public MemberDataAttribute(string memberName, params object[] parameters)
			: base(memberName, parameters)
		{ }
	}
}
