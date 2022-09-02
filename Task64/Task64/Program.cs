/* Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите целое положительное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} -> \"");
int res = PrintRangeNumbers(number);

int PrintRangeNumbers(int num)
{
    if (num == 1)
    {      
      Console.Write(1 + "\"");
      return 1;
    }
    Console.Write(num + ", ");
    return PrintRangeNumbers(num - 1);
}