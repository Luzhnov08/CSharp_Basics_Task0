/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum(number);
Console.WriteLine($"{number} -> {result}");

int Sum(int num) 
{
    int sum = num % 10;
    while (num >= 10) 
    {
        num = num / 10;
        sum = sum + (num % 10);
    }
    return sum;
}