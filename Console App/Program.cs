using System;
using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using QuickSort;

namespace Console_App
{
    class Program
    {
        static void PrintEnumerable<T>(IEnumerable<T> list)
        {
            foreach (T element in list)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var original = new List<int>();
            var random = new Random();

            for (int i = 0; i < 20; i++)
            {
                original.Add(random.Next() % 25);
            }
            PrintEnumerable<int>(original);

            var toSort = ListModule.OfSeq(original);
            var sorted = QSort.sort<int>(toSort);

            PrintEnumerable<int>(sorted);
        }
    }
}
