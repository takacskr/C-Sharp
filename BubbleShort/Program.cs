﻿using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 44, 69, 11, 9, 73, 84 };

            BubbleSort(numbers);

            Console.WriteLine("Sorted numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j+1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
