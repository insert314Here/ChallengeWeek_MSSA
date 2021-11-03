using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 4, 2, 3, 5 };
            Console.WriteLine("---Default Array Elements---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            //sort items in numerical order
            Array.Sort(array);
            Console.WriteLine("---Elements After Sort by Numerical Order---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            //reverse method
            Array.Reverse(array);
            Console.WriteLine("---Elements After Sort by Reverse---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
