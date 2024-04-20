using System;

public static class SortHelper
{
    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 23, 44, 69, 11, 9, 73, 84 };

        SortHelper.BubbleSort(numbers);

        Console.WriteLine("Sorted Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
