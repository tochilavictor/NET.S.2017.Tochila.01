using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SortLogic;

namespace SortLogicTest
{
    [TestFixture]
    public class ArrayOperationsTest
    {
        #region QuickSortTest
        [TestCase(new int[] {8, 34, 32, 345, 343, 234, 23, 45})]
        [TestCase(new int[] {5, 4, 3, 2, 1})]
        [TestCase(new int[] { 1 })]
        public void QuickSort_NormalArray_PositiveTest(int[] a)
        {
            int[] tmparr = new int[a.Length];
            Array.Copy(a, tmparr,a.Length);
            Array.Sort(tmparr);
            ArrayOperations.Quicksort(a);
            Assert.AreEqual(tmparr,a);
        }
        [TestCase(null)]
        public void QuickSort_NullReference_ThrowsArgumentNullException(int[] a)
        {
            Assert.Throws<ArgumentNullException>(()=> ArrayOperations.Quicksort(a));   
        }
        [TestCase(new int [] {})]
        public void QuickSort_EmptyArray_ThrowsArgumentException(int[] a)
        {
            Assert.Throws<ArgumentException>(() => ArrayOperations.Quicksort(a));
        }
        #endregion
        #region MergeSortTest
        [TestCase(new int[] { 8, 34, 32, 345, 343, 234, 23, 45 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1 })]
        public void MergeSort_NormalArray_PositiveTest(int[] a)
        {
            int[] tmparr = new int[a.Length];
            Array.Copy(a, tmparr, a.Length);
            Array.Sort(tmparr);
            ArrayOperations.MergeSort(a);
            Assert.AreEqual(tmparr, a);
        }
        [TestCase(null)]
        public void MergeSort_NullReference_ThrowsArgumentNullException(int[] a)
        {
            Assert.Throws<ArgumentNullException>(() => ArrayOperations.MergeSort(a));
        }
        [TestCase(new int[] { })]
        public void MergeSort_EmptyArray_ThrowsArgumentException(int[] a)
        {
            Assert.Throws<ArgumentException>(() => ArrayOperations.MergeSort(a));
        }
        #endregion
    }
}
