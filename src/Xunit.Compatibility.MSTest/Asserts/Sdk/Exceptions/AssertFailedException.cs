using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public class AssertFailedException : Exception
    {
        public AssertFailedException(string message) : base(message)
        {
        }

        // see https://github.com/xunit/assert.xunit/blob/main/Sdk/Exceptions/XunitException.cs
        /// <inheritdoc/>
        public override string ToString()
        {
            var result = GetType().ToString();
            if (!string.IsNullOrEmpty(Message))
            {
                result += $": {Message}";
            }
            if (StackTrace != null)
            {
                result += Environment.NewLine + StackTrace;
            }
            return result;

        }
    }
}
