﻿namespace Algorithm.Sort.Library.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void InsertionSortByAscendingTest()
        {
            InsertionSort.Sort(Common.Array, SortType.Ascending);
            Assert.IsTrue(Common.IsSame(Common.Array, Common.SortedByAscendingArray));
        }

        [TestMethod]
        public void InsertionSortByDescendingTest()
        {
            InsertionSort.Sort(Common.Array, SortType.Descending);
            Assert.IsTrue(Common.IsSame(Common.Array, Common.SortedByDescendingArray));
        }
    }
}
