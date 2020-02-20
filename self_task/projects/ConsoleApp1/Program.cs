using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 9, 2, 6, 3, 0, 1 };

            ArraySort.BubbleSortByDescending(array);

            foreach(int item in array)
                Console.WriteLine(item);

            Console.WriteLine();

            ArraySort.SelectionSortByDescending(array);

            foreach (int item in array)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
