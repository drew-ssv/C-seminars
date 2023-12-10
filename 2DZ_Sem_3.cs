///Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет и 23432 -> да и 12821 -> да
Console.WriteLine("Задача 19:");

while (true)
{
Console.Write("Input 5-digit palindrom: ");
string strN = Convert.ToString(Console.ReadLine());
if (strN.Length == 5)
{
Palindrom(strN);
}
else
{
    Console.Write("Not 5-digit! in input!");
}
Console.WriteLine("Let's restart? (y/n)");
char restart = Convert.ToChar(Console.ReadLine());
if (restart =='n') break;
}

void Palindrom(string strN)
{
    if(strN[0] == strN[4] && strN[1] == strN[3])
    {
        Console.WriteLine($"{strN} -> Yes, it's a palindrom");
    }
    else
    {
        Console.WriteLine($"{strN} -> Not a palindrom");
    }
}


/// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 и A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine();
Console.WriteLine("Задача 21:");

int FirstDotCoordinate = Input("Input coordinate of the DOT A (xyz): numbers together "); 
int SecondDotCoordinate = Input("Input coordinate of the DOT B (xyz): numbers together "); 
int A = FirstDotCoordinate;
int B = SecondDotCoordinate;
//Console.WriteLine($"}
int x = FirstDotCoordinate/10/10;
int y = FirstDotCoordinate/10%10;
int z = FirstDotCoordinate%10;
int x2 = SecondDotCoordinate/10/10;
int y2 = SecondDotCoordinate/10%10;
int z2 = SecondDotCoordinate%10;
double Dist =  Math.Round (Distance(x, x2, y, y2, z, z2), 2 );

Console.WriteLine($"Distance between A({x},{y},{z}) & В({x2},{y2},{z2}) = {Dist}");

int Input(string ForPrint)
{
    Console.Write(ForPrint);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(double x, double x2, 
                double y, double y2, 
                double z, double z2)
{
  return Math.Sqrt((x2-x)*(x2-x) + 
                   (y2-y)*(y2-y) + 
                   (z2-z)*(z2-z));
}



/// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.  и  5 -> 1, 8, 27, 64, 125
Console.WriteLine();
Console.WriteLine("Задача 23:");

Console.Write("Input number =  Length of CUBES line: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] ArrayALLCubs(int N)
{
    int i = 0;
    int[] EvenCubs = new int[N];
    for (int num = 1; num <= N; num++)
    {
        EvenCubs[i] = (num* num * num);
        i ++;
    }
    return EvenCubs;
}
PrintArray(ArrayALLCubs(N));


void PrintArray(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " "); // печать всех System.Console.Write($"{array[i]} ") //печать четных if (array[i] % 2 == 0) System.Console.Write(array[i] + " ");
        number++;
    }
    System.Console.WriteLine();
}


