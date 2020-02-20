using System;

namespace ConsoleApp1
{
    static class ArraySort
    {
        public static void Swap(ref int value1, ref int value2)
        {
            int tmp = value1;
            value1 = value2;
            value2 = tmp;
        }

        public static int[] BubbleSortByDescending(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;

            bool swapDetected = false;
            while (true)
            {
                swapDetected = false;
                for (int index = array.Length - 1; index > 0; index--)
                {
                    if (array[index] > array[index - 1])
                    {
                        Swap(ref array[index], ref array[index - 1]);
                        swapDetected = true;
                    }
                }
                if (!swapDetected) 
                    break;
            }
            return array;
        }

        public static int[] SelectionSortByDescending(int[] array)
        {
            if (array == null || array.Length < 2)
                return array;

            for(int index = array.Length - 1; index >= 0; index--)
            {
                int minIndex = index;
                for (int next = index - 1; next >= 0; next--)
                    if (array[minIndex] > array[index])
                        minIndex = next;
                if(minIndex != index)
                {
                    Swap(ref array[index], ref array[minIndex]);
                }
            }
            return array;
        }
    }
}
