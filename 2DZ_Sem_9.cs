using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReadKey
{
    public class Program
    {
        public static void Main(string[] args)
/// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine ("Задача 64:");

            Console.WriteLine ("Input positive N for print all numbers from 'N' to 1:");
            int num = Convert.ToInt32(Console.ReadLine());
            PrintString(args);

            string FormAnswerString(int num)
            {
            if (num == 0)
            {
            return "0";   
            }
            else if (num == 1)
            {
            return "1";
            }
            else
            {   
            return ($"{num}, {FormAnswerString(num - 1)}");
            }
            }

            void PrintString(string[] args)
            {
            Console.WriteLine($"N = {num} -> '{FormAnswerString(num)}'");
            }
        
            Console.WriteLine ();
        }
    }
}

///Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
        {
                Console.WriteLine ("Задача 66:");

            Console.WriteLine("Input the RANGE start number M:");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the RANGE end number N:");
            int N = int.Parse(Console.ReadLine());
            int firstM = M;
            RangeSum(M, N, 0);

            void RangeSum (int M, int N, int result)
            {
                if (M > N) 
                {
                    Console.WriteLine($"RANGE elements SUM from {firstM} to {N} is: {result}"); 
                    return;
                }
                
                result = result + (M++);
                RangeSum (M, N, result);
            }

            Console.WriteLine ();
        }

        {    
            Console.WriteLine ("Задача 66:");

            Console.WriteLine("Input the RANGE start number M:");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the RANGE end number N:");
            int N = int.Parse(Console.ReadLine());
            int firstM = M;
            RangeSum(M, N, 0);

            void RangeSum (int M, int N, int result)
            {
                if (M > N) 
                {
                    Console.WriteLine($"RANGE elements SUM from {firstM} to {N} is: {result}"); 
                    return;
                }
                
                result = result + (M++);
                RangeSum (M, N, result);
            }

            Console.WriteLine ();
        }

///Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29 

///Метод вычисления функции Аккермана:
// A(m,n) = n + 1 (if m = 0)
// A(m,n) = A(m - 1,1) (if m > 0 and n = 0)
// A(m,n) = A(m - 1,A(m,n - 1)) (if m > 0 and n > 0)
        {
            Console.WriteLine ("Задача 68:");

            int m = Input("Input first positive number m: "); 
            int n = Input("Input second positive number n: "); 
            Console.WriteLine($"if m = {m}, n = {n} -> Akkerman (m,n) = {Akkerman(m, n)}");

            int Input(string ForPrint)
            {
                Console.Write(ForPrint);
                return Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }


            int Akkerman (int m, int n)
            {
                if (m == 0) 
                {
                    return n + 1;
                }
                if (m > 0 && n == 0) 
                {
                    return Akkerman(m - 1, 1);
                }
                if (m > 0 && n > 0) 
                {
                    return Akkerman(m - 1, Akkerman(m, n - 1));
                }
                return Akkerman(m, n);
            }
        }
