using System;
namespace SortArray
{
    public class Exercise1
    {
        public static void Main()
        {

            int i;
            Console.Write("\n\nModule02: Sort items into an array\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("How many elements do you want to put into the array?\n");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrayLength];

            for (i = 0; i < arrayLength; i++)
            {
                Console.Write($"element: {i + 1}\n");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nElements in array are: \n");
            for (i = 0; i < arrayLength; i++)
            {
                Console.Write($"{arr[i]} - ");
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("\n---Elements After Sort by Reverse---\n");
            for (i = 0; i < arrayLength; i++)
            {
                Console.Write($"{arr[i]} - ");
            }
            Console.ReadKey();
        }
    }
}