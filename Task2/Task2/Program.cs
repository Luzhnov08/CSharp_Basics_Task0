/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3 */

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск наименьшего и наибольшего двух чисел. Введите целое число 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string Text = "";

            if (num1 > num2)
            {
                Text = $"Число {num1} больше числа {num2}";
            }
            else if (num1 < num2)
            {
                Text = $"Число {num1} меньше числа {num2}";
            }

            else 
            {
                Text = $"Числа {num1} и {num2} равны";
            }

            WriteText(Text);
            Console.ReadKey();
        }

        public static void WriteText(string Text) 
        {
            Console.WriteLine(Text);
        }
    }
}