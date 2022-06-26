//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) и 2, 4 -> 16
Console.WriteLine("Задача 25:");

int Base = Input("Input first number: base_"); 
int Degree = Input("Input second number: degree_"); 

int Result = 1;
for (int i = 0; i < Degree; i++)
{
    Result *=  Base;
}

Console.WriteLine($"{Base} in {Degree} degree -> {Result}");


int Input(string ForPrint)
{
    Console.Write(ForPrint);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11 и 82 -> 10 и 9012 -> 12
Console.WriteLine();
Console.WriteLine("Задача 27:");

Console.Write("Input number for show the SUMM of it's digits: ");
string? numb = Console.ReadLine();
int N =  Math.Abs(Convert.ToInt32(numb));
int sum = 0;
    while (N > 0)
    {
        sum = sum + N%10;
        N = (N-N%10)/10;   
    }
 
Console.WriteLine($"SUM of digits of {numb} is -> {sum}");
Console.WriteLine();


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] Array = new int[8];
Console.WriteLine("Input 8 integer NUMBERS: ");

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"New input a[{i}]: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

Print_a(Array);  //$"Your array is -> {}")

void Print_a(int[] Array)
{
    Console.Write("Your array is -> ");
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine();
