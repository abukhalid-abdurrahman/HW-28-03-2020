/*
 * Developed by Faridun Berdiev
 * Date: 29.03.2020
 * First Task
*/
using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            Console.WriteLine("Task 1.1");
            int A1 = int.Parse(Console.ReadLine());
            int B1 = int.Parse(Console.ReadLine());
            int Results1 = 0;
            for(int i = A1; i < B1; i++)
            {
                Results1 += i;
            }
            Console.WriteLine($"Results: {Results1}\n");
            //END

            //Task 1.2
            Console.WriteLine("Task 1.2");
            int A2 = int.Parse(Console.ReadLine());
            int B2 = int.Parse(Console.ReadLine());
            for(int i = A2 + 1; i < B2; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine($"\t-{i}");
                }
            }
            //END
        }
    }
}
