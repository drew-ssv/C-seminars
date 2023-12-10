/// ДЗ Семинар 5
/// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine();
Console.WriteLine("ДЗ Семинар 5");
Console.WriteLine();
Console.WriteLine("Задача 34:");

int [] positiveArray = new int [100];
FillArrayPositiveRandom(positiveArray);

PrintEvenNumbersArray (positiveArray); 

int countEvenNumbers = EvenNumbers(positiveArray);
Console.WriteLine($" There is -> {countEvenNumbers} EVEN numbers");


///Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19   и  [-4, -6, 89, 6] -> 0
Console.WriteLine();
Console.WriteLine("Задача 36:");

int [] integerArray = new int [10];
FillArrayIntegerRandom(integerArray);

PrintAllIntegerArray(integerArray);

int countOddIndexNumbers = PrintOddIndexArray(integerArray);
Console.WriteLine($" It's SUM -> {countOddIndexNumbers}"); 


///Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine();
Console.WriteLine("Задача 38:");

double [] realArray = new double [10];
FillArrayRealRandom(realArray);

PrintAllRealArray(realArray);

MaxMinusMinNumber(realArray);

Console.WriteLine();



// методы из задачи 34
void FillArrayPositiveRandom(int[] positiveArray)
{
    for(int i = 0; i < positiveArray.Length; i++)
    {
        positiveArray[i] = new Random().Next(100, 1000); // massive filling with POSITIVE INTEGER numbers (till - for-1 this interval)
    }
}

void PrintEvenNumbersArray(int[] positiveArray)
{
    int number = 0;
    Console.Write("Your EVEN numbers in random positive Array is ->  ");
    for (int i = 0; i < positiveArray.Length; i++)
    {
       if (positiveArray[i] % 2 == 0) //printing only even numbers
       {
        Console.Write($"{positiveArray[i]} ");
        number++;
       }      
    }
}

int EvenNumbers(int[] positiveArray)
{
  int numberOfEven = 0;
  for (int i = 0; i < positiveArray.Length; i++)
  {
  if (positiveArray[i] % 2 == 0)             //count only even numbers
       {
        numberOfEven ++;          
       }
  }
    Console.WriteLine();
    return numberOfEven; 
}

// методы из задачи 36
void FillArrayIntegerRandom(int[] integerArray)
{
    for(int i = 0; i < integerArray.Length; i++)
    {
        integerArray[i] = new Random().Next(-10, 10);  // massive filling with INTEGER numbers (till - for-1 this interval)
    }
}

void PrintAllIntegerArray(int[] integerArray)
{
    int number = 0;
    Console.Write("ALL integer numbers of random Array is ->  ");
    for (int i = 0; i < integerArray.Length; i++)
       {
           Console.Write($"{integerArray[i]} "); //for check: printing all array numbers      
           number++;    
       }    
Console.WriteLine();  
}

int PrintOddIndexArray(int[] integerArray)
{
    int number = 0;
    int sumOddIndexNumbers = 0;
    Console.Write("Your numbers with ODD index in integer random Array is ->  ");
    for (int i = 0; i < integerArray.Length; i++)
    {
       if (i % 2 != 0) //printing only odd index numbers
       {
        Console.Write($"{integerArray[i]} ");
        number++;
       }
       if (i % 2 != 0)             //sum only odd index numbers
       {
        sumOddIndexNumbers = sumOddIndexNumbers + integerArray[i];  
       }    
    }
    Console.WriteLine();
    return sumOddIndexNumbers;
}

// методы из задачи 38
void FillArrayRealRandom(double[] realArray)
{
    for(int i = 0; i < realArray.Length; i++)
    {
        realArray[i] = new Random().Next(-10, 10); // massive filling with REAL numbers (till - for-1 this interval)
    }
}


void PrintAllRealArray(double[] realArray)
{
    int number = 0;
    Console.Write("ALL real numbers of random Array is ->  ");
    for (int i = 0; i < realArray.Length; i++)
       {
           Console.Write($"{realArray[i]} "); //for check: printing all array numbers       
           number++;     
       }    
Console.WriteLine();  
}

void MaxMinusMinNumber(double [] realArray)
{    
double max = realArray[0];
double min = realArray[0];
  for (int i = 1; i < realArray.Length; i++)
  {
    if (max < realArray[i])
    {
      max = realArray[i];
    }
        if (min > realArray[i])
    {
      min = realArray[i];
    }
  }
double result = max - min;
Console.WriteLine($"Max ({max}) min ({min}) variance is -> {result}");
}

