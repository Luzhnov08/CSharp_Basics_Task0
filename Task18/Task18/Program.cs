/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */

Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

string result = Quarter(number);
Console.WriteLine(result);

string Quarter(int num)
{
    if (num == 1) return "Значения переменных: x > 0 и y > 0";
    if (num == 2) return "Значения переменных: x < 0 и y > 0";
    if (num == 3) return "Значения переменных: x < 0 и y < 0";
    if (num == 4) return "Значения переменных: x > 0 и y < 0";
    return "Указана некорректная четверть";
}
