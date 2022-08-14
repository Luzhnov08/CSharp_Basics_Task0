/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

Console.WriteLine("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

if (Divide(number1))
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

bool Divide(int num) 
{
    bool result = (num % 7 == 0) && (num % 23 == 0);
    return result;
}