using System;
using System.Threading.Tasks.Sources;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = new string[10] { "Sophia", "Emilly", "Emma", "Grace", "Hanna", "John", "Steve", "William", "Jacob", "Robert" };
            int i;
            Console.WriteLine(name.Length);
            for (i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Enter with the name  " + (i));
                Console.WriteLine(name[i]);
            }

            double[] score = new double[10]; //{ "8.5", "6.2", "7.0", "9.1", "5.7", "7.3", "7.5", "5.5", "6.8", "8.2" };
            int index;
            Console.WriteLine(score.Length);
            for (index = 0; index < score.Length; index++)
            {
                Console.WriteLine("Enter with score  " + (index));
                score[index] = double.Parse(Console.ReadLine()); 
            }



        }
    }
}
