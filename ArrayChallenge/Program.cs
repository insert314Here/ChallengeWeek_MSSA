using System;
using System.Collections;

namespace ArrayListSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("Some korean phrase");
            myAL.Add("Numb3r5 and letters");

            Console.WriteLine("My ArrangeList");
            Console.WriteLine(" Count: {0}", myAL.Count);
            Console.WriteLine(" Capacity: {0}", myAL.Capacity);
            Console.Write(" Values:");
            PrintValues(myAL);
        }

        private static void PrintValues(ArrayList myAL)
        {
            foreach (Object obj in myAL)
            Console.Write($" {obj}");
            Console.WriteLine();

        }
    }
}
