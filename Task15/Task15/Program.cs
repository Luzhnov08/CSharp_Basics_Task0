/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
string text = holiday(day);
Console.WriteLine(text);

string holiday(int day)
{
    {
        switch (day)
        {
            case >= 1 and <= 5:
                return "нет";
            case 6 or 7:
                return "да";
            default:
                return "введено число вне интервала от 1 до 7";
        }
    }
}
