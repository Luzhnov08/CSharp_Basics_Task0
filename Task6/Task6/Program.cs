/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка чётного числа. Введите целое число:");
            int num = Convert.ToInt32(Console.ReadLine());

            string Text = "";

            if (num%2 == 0)
            {
                Text = $"Число {num} чётное, да";
            }
            else
            {
                Text = $"Число {num} нечётное, нет";
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