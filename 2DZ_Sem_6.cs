/// ДЗ Семинар 6
/// Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2  и -1, -7, 567, 89, 223-> 3

Console.WriteLine("Задача 41:");

Console.Write("Input how much numbers You need to check_ ");
int massiveLength = Convert.ToInt32(Console.ReadLine());
int[] checkingMassive = new int[massiveLength];
InputToMassive(massiveLength);
int count = 0;
    for (int i = 0; i < checkingMassive.Length; i++)
    {
      if(checkingMassive[i] > 0 ) count += 1; 
    }

Console.WriteLine($"{count} -> numbers more than 0");
Console.WriteLine();

//методы к задаче 41:
void InputToMassive(int massiveLength)
      {
        for (int k = 0; k < massiveLength; k++)
        {
          Console.Write($"Print {k+1} integer number_ ");
          checkingMassive[k] = Convert.ToInt32(Console.ReadLine());
        }
      }


///Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.WriteLine("Задача 43:");

double[,] points = new double[2,2];
double[] crossing = new double[2];
EnterPointsMultiplier();
CrossingCheck(points);
ShowPoint(points);
Console.WriteLine();

//методы к задаче 43:
void EnterPointsMultiplier()
    {
      for (int i = 0; i < points.GetLength(0); i++)
      {
        Console.WriteLine($"Enter Your points Multiplier {i+1} for math equation (y = k * x + b)");
        for (int k = 0; k < points.GetLength(1); k++)
        {       
          if(k==0) 
          {    
            Console.Write($"Enter Multiplier k: "); 
          }
          else
          {      
            Console.Write($"Enter Multiplier b: "); 
          }
          points[i,k] = Convert.ToInt16(Console.ReadLine());  
        } 
      }
      Console.WriteLine();
    }

double[] CrossingCheck(double[,] points)
    {
      crossing[0] = (points[1,1] - points[0,1]) / (points[0,0] - points[1,0]); //(b2 - b1)/(k1 - k2) = x
      crossing[1] = crossing[0] * points[0,0] + points[0,1]; //k1(b2-b1)/(k1-k2)+b1 = y
      return crossing;
    }

void ShowPoint(double[,] points) //CrossingCheck выводит одно значение
    {
      CrossingCheck(points);
      Console.Write($"Point of the 2 lines crossing is ->  ({crossing[0]}, {crossing[1]})"); // o = x , 1 = y
    }
