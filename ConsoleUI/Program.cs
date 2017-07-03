using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SortLogic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2 = -15;
            string n1 = Convert.ToString(num2, 2);
            Console.WriteLine(n1);
            Stopwatch stopWatch = new Stopwatch();
            int[] mas = new int[10000];
            int[] mas2 = new int[10000];
            Random rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                mas[i] = rand.Next(1000);
                mas2[i] = rand.Next(1000);
            }
            stopWatch.Start();
            ArrayOperations.Quicksort(mas);
            stopWatch.Stop();
            TimeSpan quickSortTime = stopWatch.Elapsed;
            stopWatch.Restart();
            stopWatch.Start();
            ArrayOperations.MergeSort(mas2);
            stopWatch.Stop();
            TimeSpan mergeSortTime = stopWatch.Elapsed;
            Console.WriteLine("Quick sort time " + quickSortTime.TotalMilliseconds +" milliseconds");
            Console.WriteLine("Merge sort time " + mergeSortTime.TotalMilliseconds +" milliseconds");
            Console.ReadKey();
        }
    }
}
