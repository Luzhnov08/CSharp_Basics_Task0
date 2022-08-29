/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] matrixArr = CreateMatrixRndInt(3, 4, 0, 10);
PrintArray printarr = new PrintArray();
printarr.PrintMatrix(matrixArr);
double[,] resultArr = CalcAverageInArr(matrixArr);
printarr.PrintMatrix(resultArr);

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

double[,] CalcAverageInArr(int[,] matrix)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    int maxRow = matrix.GetLength(0);
    int maxCol = matrix.GetLength(1);
    double[,] resArr = new double[1, maxCol];

    for (int col = 0; col < maxCol; col++)
    {
        double sum = 0;
        for (int row = 0; row < maxRow; row++)
        {
            sum += matrix[row, col];
        }
        sum = Math.Round(sum / maxRow, 1);
        resArr[0, col] = sum;
    }
    return resArr;
}

internal sealed class PrintArray
{
    internal void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}, ");
                else Console.Write($"{ matrix[i, j],1}");
            }
            Console.WriteLine("]");
        }
    }

    internal void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}, ");
                else Console.Write($"{ matrix[i, j],1}");
            }
            Console.WriteLine("]");
        }
    }
}