/*
 * Developed by Faridun Berdiev
 * Date: 29.03.2020
 * Second Task
*/
using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3...");
            float P = float.Parse(Console.ReadLine().ToString().Replace(".", ","));
            float m = 1000;
            float mP = ((m * P) / 100);
            int counter = 0;
            float i = 0;
            if(P > 0 && P < 25)
            {
                for(i = m; i <= 1100; i+=mP)
                {
                    counter++;
                }
                
                Console.WriteLine($"Кол-во месяцев: {counter}, итоговый размер вклада {i}");
            }
        }
    }
}
