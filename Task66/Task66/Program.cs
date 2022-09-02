/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите целое положительное число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число M: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {number1}; N = {number2} -> ");
int res = SumRangeNumbers(number1, number2);
Console.Write(res);

int SumRangeNumbers(int firstNum, int endNum)
{
    int sum = firstNum;
    if (firstNum < endNum ) sum += SumRangeNumbers(firstNum + 1, endNum);
    else if (firstNum > endNum)  sum += SumRangeNumbers(firstNum - 1, endNum);
    return sum;
}