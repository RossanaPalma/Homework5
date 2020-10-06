using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] newNum = numbers;
            Console.WriteLine("The original array is : ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i + " ");
            }
            Array.Reverse(numbers);
            Console.WriteLine("The reverse array is : ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i + " ");
            }


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Array.Reverse(numbers);
            //Console.WriteLine("The reverse array is: " + Convert.ToInt32(numbers));








        }
    }
}
