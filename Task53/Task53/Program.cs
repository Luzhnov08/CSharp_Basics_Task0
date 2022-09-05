/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/

int[,] matrixArr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrixArr, "Заданный массив:");
SwapArray(matrixArr);
PrintMatrix(matrixArr, "Преобразованный массив:");

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

void SwapArray(int[,] matrix) 
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    int col = matrix.GetLength(1);
    for (int i = 0; i < col; i++) 
    {
        int elem = matrix[lastRow, i];
        matrix[lastRow, i] = matrix[firstRow, i];
        matrix[firstRow, i] = elem;
    }
}

