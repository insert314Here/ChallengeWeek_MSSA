using System;
using System.Collections;

namespace AddToArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start typing in things to store into the list");
            addListItems();
        }

        public static void addListItems()
        {
            ArrayList myList = new ArrayList();
            char state = 'Y';
            do
            {
                Console.WriteLine("What is the item you wish to add?");
                var item = Console.ReadLine();
                myList.Add(item);
                state = continueMessage();

            } while (state == 'Y');
            Console.WriteLine("Here is what is in your list:\n");
            foreach (var piece in myList)
            {
                Console.WriteLine($"{piece}");
            }
        }

        public static char continueMessage()
        {
            char state;
            Console.WriteLine("Continue adding elements? Y/N");
            state = Char.ToUpper(Convert.ToChar((Console.ReadLine())));
            return state;
        }
    }
}
