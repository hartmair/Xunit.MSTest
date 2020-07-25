using CollectionAssert = Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert;
using Xunit;

namespace Test
{
    public class EquivalentTest
    {
        [Fact]
        public void TestEquivalent_Same()
        {
            var collection = new[] { 1, 2, 3 };
            CollectionAssert.AreEquivalent(collection, collection);
        }

        [Fact]
        public void TestEquivalent_Equal()
        {
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, new[] { 1, 2, 3 });
        }

        [Fact]
        public void TestEquivalent_DifferentOrder()
        {
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, new[] { 2, 1, 3 });
        }

        [Fact]
        public void TestEquivalent_Different()
        {
            CollectionAssert.AreNotEquivalent(new[] { 1, 2, 3 }, new[] { 2, 1, 2, 3 });
        }

    }
}
