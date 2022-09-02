/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8 */

Console.WriteLine("Введите целое положительное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Multiply(numberA, numberB);
Console.WriteLine($"A = {numberA}; B = {numberB} -> { result}");

int Multiply(int num1, int num2) 
{
    if (num2 == 0) return 1;
    return num1 * Multiply(num1, num2 - 1);
}