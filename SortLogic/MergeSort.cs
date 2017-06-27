using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLogic
{
    /// <summary>
    /// implements merge sort algorithm for integers
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        /// Implements the merge sort algorithm for integers array
        /// </summary>
        /// <param name="array">array</param>
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(array, left, middle);
                Sort(array, middle + 1, right);
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
    }
}

 
