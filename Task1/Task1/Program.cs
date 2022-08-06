/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
 * a = 25, b = 5 -> да
 * a = 2, b = 10 -> нет
 * a = 9, b = -3 -> да
 * a = -3, b = 9 - > нет
 */

Console.WriteLine("Введите целое число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int sqrt = num2 * num2;
if (num1 == sqrt)
{
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
}
else
{
    Console.WriteLine($"Число {num2} НЕ является квадратом числа {num1}");
}