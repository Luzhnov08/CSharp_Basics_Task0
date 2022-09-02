/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = SumNumberDigitals(number);
Console.WriteLine("Сумма цифр числа = " + res);

int SumNumberDigitals(int num) 
{
    int sum = num % 10;
    if (num > 0) sum += SumNumberDigitals(num / 10);
    return sum;
}
