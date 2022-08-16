/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999) 
{
    Console.WriteLine("Введено некорректное число");
    return; 
}
string result = Polyndrome(number);
Console.WriteLine(result);

string Polyndrome(int num) 
{
    if (num % 10 == num / 10000 && (num % 100) / 10 == (num / 1000) % 10) 
    {
        return $"{number} -> Да";
    }
    return $"{number} -> Нет";
}