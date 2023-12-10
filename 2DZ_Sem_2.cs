static void Main(string[] args);

/// ДЗ к Семинару 2
/// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 и 782 -> 8 и 918 -> 1
{Console.Write("Input three-digit number (from 100 to 999): ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 99 && Number < 1000)
{
   int digitNumber = Number/10%10;
   Console.WriteLine("The second digit of Your number is -> " + digitNumber); 
}
else
{
    Console.WriteLine(Number + ": This number isn't three digit!");
}

// второе решение задания 1
Console.Write("Input three-digit number next time: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 > 99 && Number2 < 1000)
{
   string digitNumber2 = Convert.ToString (Number2);
   Console.WriteLine("The second digit of Your number is -> " + digitNumber2 [1]);
}
else
{
    Console.WriteLine(Number2 + ": This number isn't three digit!");
}
}

/// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 и 78 -> третьей цифры нет и 32679 -> 6

{Console.Write("Input Your number: ");
int Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string digitNumber = Convert.ToString (Number);
if (digitNumber.Length < 3)
{
   Console.WriteLine(Number + ": There is NONE third digit!");
}
else
{
   Console.WriteLine("3-d digit is: " + digitNumber [2]);
}

/// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да и 7 -> да и 1 -> нет
Console.Write("Input day number for show, it's weekend or not: ");
int DayN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string [] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
if (DayN > 0 && DayN < 8) 
{
    if(DayN == 6 || DayN == 7)
    {
      Console.WriteLine("-> YES! " + days[DayN-1] + " - It's a WEEKEND" ); 
    }
    else
    {
      Console.WriteLine("-> NO - " + days[DayN-1] + " - It's a WORK day" );
    }
}
else
    {
      Console.WriteLine("This is NOT day number of a week");
    }
}
/// 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да и -4, 16 -> да и 25, 5 -> да и 8,9 -> нет
{Console.Write("Input integer number or SQUARE:  ");
int Number1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Input result SQUARE or base number:  ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 > Number1)
{
  int result = (Number1 * Number1);
  if (result == Number2)
  {
    Console.WriteLine("Yes");
  }
  else
  {  
    Console.WriteLine("No");
  }
}
else if (Number1 == Number2)
{
  Console.WriteLine("No");  
}
else
{
  int result = (Number2 * Number2);
  if (result == Number1)
  {
    Console.WriteLine("Yes");
  }
  else
  {  
    Console.WriteLine("No");
  }
}
}