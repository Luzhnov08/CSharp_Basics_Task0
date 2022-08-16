/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

Console.WriteLine("Введите целое число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = PowNumber(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {result}");

int PowNumber(int num1, int num2) 
{
    int res = 1;
    for (int i = 1; i <= num2; i++) 
    {
        res = res * num1;
    }
    return res;
}