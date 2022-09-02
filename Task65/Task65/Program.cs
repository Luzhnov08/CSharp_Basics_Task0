/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5-> "1, 2, 3, 4, 5"
M = 4; N = 8-> "4, 6, 7, 8" */

Console.WriteLine("Введите первое число:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNum = Convert.ToInt32(Console.ReadLine());

NaturalNumberBetween(firstNum, secondNum);

void NaturalNumberBetween(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write($"{num1} ");
        return;
    }
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumberBetween(num1 - 1, num2);
    }
    else
    {
        NaturalNumberBetween(num1, num2 - 1);
        Console.Write($"{num2} ");
    }    
}



