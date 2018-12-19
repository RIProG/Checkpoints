using Microsoft.VisualStudio.TestTools.UnitTesting;
using Checkpoint03;
using System.Collections.Generic;

namespace ProgramTest
{
    [TestClass]
    public class UnitTest1
    {

        Program x = new Program();

        [TestMethod]
        public void ReorderListTest1()
        {
            var result = x.ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 1, 2, 3, 5, 4 });
            var expected = new List<string>() { "a", "b", "c", "e", "d" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReorderListTest2()
        {
            var result = x.ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });
            var expected = new List<string>() { "c", "a", "d", "b" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReorderListTest3()
        {
            var result = x.ReorderList(new List<string> { "a", "b" }, new List<int> { 2, 2 });
            var expected = new List<string>() { "b", "b" };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
