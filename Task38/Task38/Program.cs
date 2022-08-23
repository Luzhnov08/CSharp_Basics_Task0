/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементами массива
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] basicArr = CreateArrayRndDouble(10);
PrintArray(basicArr);
double diff = DiffMinMax(basicArr);
Console.WriteLine($" Разница между максимальным и минимальным элементами массива равна: {diff}");

double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

double DiffMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    return max - min;
}