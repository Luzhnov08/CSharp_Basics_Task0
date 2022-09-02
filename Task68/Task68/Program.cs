/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите целое положительное число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {firstNumber}; N = {secondNumber} -> A(m,n) = ");
int res = AkkermanFunc(firstNumber, secondNumber);
Console.Write(res);

int AkkermanFunc(int m, int n)
{
    int sum = m;
    if (m == 0) sum = n + 1;
    else if (m > 0 && n == 0) sum = AkkermanFunc(m - 1, 1);
    else if (m > 0 && n > 0) sum = AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    return sum;
}