/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Calc(number);

Console.WriteLine($"Вторая цифра числа {number} равна {result} ");

int Calc(int num)
{
    int res = (number % 100) / 10;
    return res;
}