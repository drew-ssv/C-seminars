// проверка возведения числа в квадрат
Console.Write("Введите число №1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 * Number1 == Number2)
{
  Console.WriteLine(" правильно, квадрат числа " + Number1 + " = " + Number2);   
}
else
{
    Console.WriteLine(" число " + Number2 + " не является квадратом числа " +  Number1);   
}
   
   