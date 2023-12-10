/// ДЗ Семинар 7

///Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.WriteLine("Задача 47:");

Console.WriteLine("Input the number of array rows");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input the number of columns");
int n = Convert.ToInt32(Console.ReadLine()); 

double [,] massiveRealNumbers = new double [m , n];
Random(massiveRealNumbers);
PrintMassive(massiveRealNumbers); 


void Random(double[,] massiveRandom)
            {
                for (int i = 0; i < massiveRandom.GetLength(0); i++)
                {
                    for (int j = 0; j < massiveRandom.GetLength(1); j++)
                    {
                       massiveRealNumbers[i, j] = Convert.ToDouble(new Random().Next(-10, 10))*0.61;  // NextDouble() - не подходит дает случайное вещ число в диап от 0 до 1
        
                    }
                Console.WriteLine();
                }
            }

void PrintMassive(double [,] perfectMassive)
            {
                for (int i = 0; i < m; i++) 
                {
                    for (int k = 0; k < n; k++) 
                    {
                        Console.Write(String.Format("{0:0.00}", perfectMassive[i, k]) + "  "); 
                    }
                    Console.WriteLine();
                }
            }

Console.WriteLine();      

///Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Ответ: 17 -> такого числа в массиве нет

Console.WriteLine("Задача 50:");

Console.WriteLine("Input the number of array rows");
int row = Convert.ToInt32(Console.ReadLine()); //int n
Console.WriteLine("Input the number of columns");
int column = Convert.ToInt32(Console.ReadLine()); //int m

int findRow = Input("Let's find and see some array's element - print N of row_ "); 
int findColumn = Input("Ok, - print N of column_ "); 
int [,] massiveNumbers = new int [row , column]; //int [,] numbers = new int [10,10];
RandomMassiveCheckIt(massiveNumbers);
PrintArray(massiveNumbers);


int Input(string ForPrint)
           {
               Console.Write(ForPrint);
               return Math.Abs(Convert.ToInt32(Console.ReadLine()));
           }


void PrintArray(int [,] perfectMassive)
           {
               Console.WriteLine();
               Console.WriteLine("Your random array was:");
               for (int i = 0; i < perfectMassive.GetLength(0) ; i++) 
               {
                   for (int k = 0; k < perfectMassive.GetLength(1); k++) 
                   {
                       Console.Write(perfectMassive[i, k] + "  "); 
                   }  
                   Console.WriteLine();                 
               }
               Console.WriteLine();
           }


void RandomMassiveCheckIt(int[,] RandomMassiveCheckIt)
           {
               for (int i = 0; i < RandomMassiveCheckIt.GetLength(0); i++)
               {
                   for (int j = 0; j < RandomMassiveCheckIt.GetLength(1); j++)
                   {
                       RandomMassiveCheckIt[i, j] = Convert.ToInt32(new Random().Next(1,100));  
                   }
                   Console.WriteLine();
               }
               if (findRow > massiveNumbers.GetLength(0) || findColumn > massiveNumbers.GetLength(1))
               {
                   Console.WriteLine("There isn't element on this positions!");
               }
               else
               {
                   Console.WriteLine($"Element value of {findRow} row and {findColumn} column is: {massiveNumbers[findRow-1,findColumn-1]}");
               }
           }



//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2  и  5 9 2 3  и  8 4 2 4  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задача 52:");

Console.WriteLine("Input the number of array rows");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input the number of columns");
int columns = Convert.ToInt32(Console.ReadLine()); 

int [,] massiveIntegerNumbers = new int [rows , columns];
RandomInteger(massiveIntegerNumbers);
PrintIntegerMassive(massiveIntegerNumbers);
ArifmeticalMassive (massiveIntegerNumbers); 

   void RandomInteger(int[,] massiveIntegerRandom)
           {
               for (int i = 0; i < massiveIntegerRandom.GetLength(0); i++)
               {
                   for (int j = 0; j < massiveIntegerRandom.GetLength(1); j++)
                   {
                       massiveIntegerNumbers[i, j] = Convert.ToInt32(new Random().Next(1,100));  
                   }
                   Console.WriteLine();
               }
}

   void PrintIntegerMassive(int [,] perfectMassive)
           {
              Console.WriteLine("Your random array is:");
              Console.WriteLine();
               for (int i = 0; i < rows; i++) //perfectMassive.GetLength(0)
               {
                   for (int k = 0; k < columns; k++) //perfectMassive.GetLength(1)
                   {
                       Console.Write(perfectMassive[i, k] + "  "); 
                   }  
                   Console.WriteLine();                 
               }
               Console.WriteLine();
               Console.WriteLine("Arifmetical SUMM of each column is:");
           }

   void ArifmeticalMassive(int[,] massiveIntegerNumbers1)
           {
               for (int j = 0; j < massiveIntegerNumbers1.GetLength(1); j++)
               {
                   double result = 0;
                   for (int i = 0; i < massiveIntegerNumbers1.GetLength(0); i++)
                   {
                       result = Convert.ToInt32((result + massiveIntegerNumbers1[i, j]));
                   }
                   result = result / columns;
                   Console.WriteLine("Average per column " + j + " -> " + Math.Round(result,2));
               }
           }

Console.WriteLine();   
