using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLogic
{
    /// <summary>
    ///  implements the quicksort algorithm for integers
    /// </summary>
    public static class QuickSort
    {
        /// <summary>
        /// Implements the quick sort algorithm for integers array
        /// </summary>
        /// <param name="ar">array</param>
        public static void Sort(int[] ar)
        {
            Sort(ar, 0, ar.Length - 1);
        }
        static void Sort(int[] a, int left, int right)
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
                    int tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (i < right) Sort(a, i, right);
            if (left < j) Sort(a, left, j);
        }
    }
}
