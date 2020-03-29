/*
 * Developed by Faridun Berdiev
 * Date: 29.03.2020
 * Second Task
*/
using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2\n");
            Console.WriteLine("Прямоугольник");
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 40; i++)
                {
                    if (j == 0 || j == 7 - 1) 
                        Console.Write("*");
                    else if (i == 0 || i == 40 - 1) 
                        Console.Write("*");
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Прямоугольный треугольник");
            for (int i1 = 1; i1 <= 10; i1++)  
            {  
                for (int j1 = 1; j1 <= i1; j1++)  
                {  
                    Console.Write("");  
                }  
                
                for (int k = 1; k <= i1; k++)  
                {     
                    Console.Write("*");  
                } 
                Console.WriteLine("");
            } 

            Console.WriteLine("Равносторонний треугольник");
            for(int i2=1; i2<=7; i2++)      
            {          
                for(int j2=1; j2<=7-i2; j2++)      
                {      
                    Console.Write(" ");      
                }      
                for(int k1=1;k1<=i2;k1++)      
                {      
                    Console.Write("*");      
                }      
                for(int l=i2-1;l>=1;l--)      
                {      
                    Console.Write("*");      
                }      
                Console.Write("\n");      
            }   

            Console.WriteLine("Ромб");
            for(int a = 1; a <= 5; a++) 
            { 
                for (int b = a; b <= 5; b++) 
                { 
                    Console.Write("  "); 
                } 
                for(int c = 1; c <= 2 * a - 1; c++) 
                { 
                    Console.Write("* "); 
                } 
                Console.WriteLine(); 
            } 

            for (int d = 5; d >= 1; d--) 
            { 
                for (int e = d; e <= 5; e++) 
                { 
                    Console.Write("  "); 
                } 
                for (int f = 1; f <= 2 * d - 1; f++) 
                { 
                    Console.Write("* "); 
                } 
                Console.WriteLine(); 
            }     
        }
    }
}
/*
    *БЫЛО ТРУДНО РИСОВАТЬ ЭТИ ФИГУРЫ, ЛЕГЧЕ ВСЕГО БЫЛО ИХ НАРИСОВАТЬ ИСПОЛЬЗУЯ БИБЛИОТЕКУ OPENGL :-)
    *СПАСИБО ЗА ТАКИЕ ТРУДНОСТИ!
*/