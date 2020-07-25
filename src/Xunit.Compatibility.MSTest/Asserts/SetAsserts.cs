using System;
using System.Collections.Generic;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public partial class CollectionAssert
    {
        [Obsolete("Swap parameters.")]
        public static void IsSubsetOf<T>(IEnumerable<T> subset, IEnumerable<T> superset, string message = null)
        {
            Xunit.Assert.Subset(new HashSet<T>(superset), new HashSet<T>(subset));
        }
        [Obsolete("Use Superset instead.")]
        public static void IsNotSubsetOf<T>(IEnumerable<T> subset, IEnumerable<T> superset, string message = null)
        {
            Xunit.Assert.Superset(new HashSet<T>(subset), new HashSet<T>(superset));
        }
    }

    public partial class Assert
    {
        public static void Subset<T>(ISet<T> expectedSuperset, ISet<T> subset)
        {
            Xunit.Assert.Subset(expectedSuperset, subset);
        }
        public static void Superset<T>(ISet<T> expectedSubset, ISet<T> subset)
        {
            Xunit.Assert.Superset(expectedSubset, subset);
        }
    }
}
