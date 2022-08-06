/* Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8 */

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отображение последней цифры трёхзначного числа. Введите целое трёхзначное число:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            result = num % 10;

            Console.WriteLine($"Последняя цифра для числа {num}: {result}");
            Console.ReadKey();
        }
    }
}