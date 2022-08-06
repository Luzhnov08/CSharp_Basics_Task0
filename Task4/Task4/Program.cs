/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск наибольшего среди трёх чисел. Введите целое число 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число 3:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;

            if (num2 > num1)
            {
                max = num2;
            }
            if (num3 > num2)
            {
                max = num3;
            }

            Console.WriteLine($"Среди чисел {num1}, {num2}, {num3} максимальное число: {max}");
            Console.ReadKey();
        }
    }
}