/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отображение чётных чисел. Введите целое натуральное число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Четные числа для числа {num}:");

            for (int i = 0; i < num; i+=2) 
            {
                if (i != 0) 
                {
                    Console.Write(i + " ");
                }                
            }

             Console.ReadKey();
        }
    }
}