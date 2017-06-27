using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortLogic;
using System.Diagnostics;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
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
            QuickSort.Sort(mas);
            stopWatch.Stop();
            TimeSpan quicksorttime = stopWatch.Elapsed;
            stopWatch.Restart();
            stopWatch.Start();
            MergeSort.Sort(mas2);
            stopWatch.Stop();
            TimeSpan mergesorttime = stopWatch.Elapsed;
            Console.WriteLine("Quick sort time " + quicksorttime.TotalMilliseconds +" milliseconds");
            Console.WriteLine("Merge sort time " + mergesorttime.TotalMilliseconds +" milliseconds");
            Console.ReadKey();
        }
    }
}
