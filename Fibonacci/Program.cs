using System;
using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{//WORK IN PROGRESS
    public class Program
    {
        static void Main(string[] args)
        {
            int nthTerm;

            Console.WriteLine("Hello World! This application will write out the numbers in the fibonacci sequence and sum there values");
            Console.WriteLine("How many numbers would you like to be displayed, or the nth term for you maths folk");
            //have user select the length of the sequence; nTH term
            nthTerm = Convert.ToInt32(Console.ReadLine());
            CountFib(nthTerm);
        }

        //                      I, N, P+N-->P , 
        //start with the number 0, 1,  1      ,  2
        //                         P,  N      , P+N
        //index 4 uses sum property

        static void CountFib(int fibLength)
        {
            int next = 0;
            int prev = 0;
            List<int> fibList = new List<int>();
            fibList.Add(next); //0 is first added to the list

            for (int i = 0; i < fibLength; i++)
            {
                if (next == 0)
                {
                    next = 1;
                    fibList.Add(next);//1 is add to the list
                }
                else
                {
                    //   1   =   1  +   0   --> results after 1st iteration of loop
                    //           =  1
                    int tempNext = next;
                    // 1 =  1   +  0
                    next = next + prev;
                    fibList.Add(next); //1 is added to the list afain after 1st iteration
                    prev = tempNext;
                }
            }


            foreach (int item in fibList)
            {
                Console.Write($"{item}, ");
            }
        }




        //display the selected sequence

        //sum the values of the given sequence length
    }

}
