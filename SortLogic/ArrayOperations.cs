using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    /// <summary>
    /// implements merge and quick sort algorithms for 1 dimensional array of integers
    /// </summary>
    public static class SortOperations
    {
        #region public methods
        /// <summary>
        /// Implements the merge sort algorithm for integers array
        /// </summary>
        /// <param name="array">array</param>
        public static void MergeSort(int[] array)
        {
            ValidateArray(array);
            MergeSort(array, 0, array.Length - 1);
        }
        /// <summary>
        /// Implements the quick sort algorithm for integers array
        /// </summary>
        /// <param name="ar">array</param>
        public static void Quicksort(int[] array)
        {
            ValidateArray(array);
            Quicksort(array, 0, array.Length - 1);
        }
        #endregion
        #region private methods
        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Slip(array, left, right, middle);
            }
        }
        static void Slip(int[] array, int left, int right, int middle)
        {
            int i = left, j = middle + 1, k = 0;
            int[] tmp = new int[right - left + 1];
            while (i <= middle && j <= right)
            {
                if (array[i] < array[j]) tmp[k++] = array[i++];
                else tmp[k++] = array[j++];
            }
            while (i <= middle) { tmp[k++] = array[i]; i++; };
            while (j <= right) { tmp[k++] = array[j]; j++; };
            for (int c = left; c <= right; c++)
            {
                array[c] = tmp[c - left];
            }
        }
        static void Quicksort(int[] a, int left, int right)
        {
            int x = a[(left + right) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    Swap(ref a[i], ref a[j]);
                    i++;
                    j--;
                }
            }
            if (i < right) Quicksort(a, i, right);
            if (left < j) Quicksort(a, left, j);
        }
        static void ValidateArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException("Empty array");
        }
        static void Swap(ref int a,ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        #endregion
    }
}


 
