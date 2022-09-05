/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. 
Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

int[,] matr = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(matr, "Исходный массив:");
Console.WriteLine("Преобразованный и отсортированный массив:");
int[] arr = ConvertMatrix2ArrayAndSort(matr);
PrintArray(arr);
Console.WriteLine();
CountSimularElems(arr);

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{ matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] ConvertMatrix2ArrayAndSort(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = matrix[i, j];
            count++;
        }
    }
    Array.Sort(result);
    return result;
}

void CountSimularElems(int[] array)
{
    int count = 1;
    int number = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} встречается {count} раз");
            number = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{number} встречается {count} раз");
        }
    }
}