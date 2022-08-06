/* Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" */

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отображение целых чисел в промежутке -N до N. Введите целое число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Для числа {num}:");

            for (int i = -num; i <= num; i++)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}