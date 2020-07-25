using System;
using System.Text.RegularExpressions;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Use Assert instead.")]
    public abstract class StringAssert
    {
        [Obsolete("Swap parameters.")]
        public static void Contains(string value, string substring, string message = null)
        {
            Xunit.Assert.Contains(substring, value);
        }
        [Obsolete("Swap parameters.")]
        public static void StartsWith(string value, string substring, string message = null)
        {
            Xunit.Assert.StartsWith(substring, value);
        }
        [Obsolete("Swap parameters.")]
        public static void EndsWith(string value, string substring, string message = null)
        {
            Xunit.Assert.EndsWith(substring, value);
        }


        [Obsolete("Swap parameters.")]
        public static void Matches(string value, Regex pattern, string message = null)
        {
            Xunit.Assert.Matches(pattern, value);
        }
        [Obsolete("Swap parameters.")]
        public static void DoesNotMatch(string value, Regex pattern, string message = null)
        {
            Xunit.Assert.DoesNotMatch(pattern, value);
        }
    }

    public partial class Assert
    {
        public static void Contains(string expectedSubstring, string value)
        {
            Xunit.Assert.Contains(expectedSubstring, value);
        }
        public static void StartsWith(string expectedSubstring, string value)
        {
            Xunit.Assert.StartsWith(expectedSubstring, value);
        }
        public static void EndsWith(string expectedSubstring, string value)
        {
            Xunit.Assert.EndsWith(expectedSubstring, value);
        }

        public static void Matches(Regex expectedRegex, string value)
        {
            Xunit.Assert.Matches(expectedRegex, value);
        }
        public static void DoesNotMatch(Regex expectedRegex, string value)
        {
            Xunit.Assert.DoesNotMatch(expectedRegex, value);
        }
    }
}
