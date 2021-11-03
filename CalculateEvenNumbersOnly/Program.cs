using System;

namespace CalculateEvenNumbersOnly
{
    //create method to grab inputs

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This program will ask you for numbers and then only add the even numbers");
            //getNumbers will prompt and store numbers
            getNumbers();
        }

        public static void getNumbers()
        {
            double evenCheck = 0.0;
            char state = 'Y';
            double evenTotal = 0.0;

            do
            {
                Console.WriteLine("Enter number to be added, only even numbers will be added.");
                evenCheck = Convert.ToDouble(Console.ReadLine());
                double modCheck = 2.0;
                double remain = 0.0;
                double result = evenCheck % modCheck;

                if (result == remain)
                {                    
                    evenTotal += evenCheck;
                    state = continueMessage();
                }
                else
                {
                    Console.WriteLine("Thats an odd number so we are not going to add them to our list.");
                    state = continueMessage();
                }
               
            }
            while (state == 'Y');
            Console.WriteLine($"Our current sum is {evenTotal}");

            //Console.WriteLine($"You've reached the end, your total sum is {numbers}");
        }

        public static char continueMessage()
        {
            char state;
            Console.WriteLine("Continue adding numbers? Y/N");
            state = Char.ToUpper(Convert.ToChar((Console.ReadLine())));
            return state;
        }
    }
}
