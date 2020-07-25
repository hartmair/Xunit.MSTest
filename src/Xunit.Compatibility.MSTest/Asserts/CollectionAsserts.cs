using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [Obsolete("Use Assert instead.")]
    public partial class CollectionAssert
    {
        [Obsolete("Swap parameters.")]
        public static void Contains<T>(IEnumerable<T> collection, T element, string message = null)
        {
            Xunit.Assert.Contains(element, collection);
        }
        [Obsolete("Swap parameters.")]
        public static void DoesNotContain<T>(IEnumerable<T> collection, T element, string message = null)
        {
            Xunit.Assert.DoesNotContain(element, collection);
        }

        public static void AreEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, string message = null)
        {
            Xunit.Assert.Equal(expected, actual);
        }
        public static void AreNotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, string message = null)
        {
            Xunit.Assert.NotEqual(expected, actual);
        }

        [Obsolete("Use All with NotNull instead.")]
        public static void AllItemsAreNotNull<T>(IEnumerable<T> collection, string message = null)
                where T : class
        {
            Xunit.Assert.All(collection, item => Xunit.Assert.NotNull(item));
        }
        [Obsolete("Use All with HashSet<T>.Add instead.")]
        public static void AllItemsAreUnique<T>(IEnumerable<T> collection, string message = null)
        {
            var distinct = new HashSet<T>();
            Xunit.Assert.All(collection, item => distinct.Add(item));
        }
        [Obsolete("Use All with IsType instead.")]
        public static void AllItemsAreInstancesOfType<T>(IEnumerable expected)
        {
            Xunit.Assert.All(expected.Cast<object>(), item => Xunit.Assert.IsType<T>(item));
        }

        [Obsolete("See https://github.com/xunit/xunit/issues/1604")]
        public static void AreEquivalent<T>(IEnumerable<T> expected, IEnumerable<T> actual, string message = null)
        {
            Xunit.Assert.Equal(ToDictionary(expected), ToDictionary(actual));
        }
        [Obsolete("See https://github.com/xunit/xunit/issues/1604")]
        public static void AreNotEquivalent<T>(IEnumerable<T> expected, IEnumerable<T> actual, string message = null)
        {
            Xunit.Assert.NotEqual(ToDictionary(expected), ToDictionary(actual));
        }
        private static Dictionary<T, int> ToDictionary<T>(IEnumerable<T> source)
        {
            return source.ToLookup(x => x).ToDictionary(xs => xs.Key, xs => xs.Count());
        }
    }

    public partial class Assert
    {
        public static void Contains<T>(T expected, IEnumerable<T> collection)
        {
            Xunit.Assert.Contains(expected, collection);
        }
        public static void DoesNotContain<T>(T expected, IEnumerable<T> collection)
        {
            Xunit.Assert.DoesNotContain(expected, collection);
        }

        [Obsolete("Use Equal instead.")]
        public static void AreEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, string message = null)
        {
            Xunit.Assert.Equal(expected, actual);
        }
        public static void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Xunit.Assert.Equal(expected, actual);
        }
        [Obsolete("Use NotEqual instead.")]
        public static void AreNotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Xunit.Assert.NotEqual(expected, actual);
        }
        public static void NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Xunit.Assert.NotEqual(expected, actual);
        }

        public static void All<T>(IEnumerable<T> collection, Action<T> action)
        {
            Xunit.Assert.All(collection, action);
        }
    }
}
