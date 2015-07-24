namespace CSharpPowerTools.Extensions.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    internal class GenericExtensionsTests
    {
        [TestMethod]
        public void SafeCountCollectionNullTest()
        {
            ICollection<int> collection = null;
            Assert.AreEqual(0, collection.SafeCount());
        }

        [TestMethod]
        public void ArrayNullTest()
        {
            int[] array = null;
            Assert.AreEqual(0, array.SafeCount());
        }

        [TestMethod]
        public void ArrayZeroTest()
        {
            int[] array = new int[0];
            Assert.AreEqual(0, array.SafeCount());
        }
    }
}