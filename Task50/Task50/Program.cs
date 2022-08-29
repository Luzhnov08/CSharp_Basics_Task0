/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("Введите позиции элемента в двумерном массиве,");
Console.WriteLine("Строка (целое число): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столбец (целое число): ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrixArr = CreateMatrixRndDbl(3, 4, 0, 10);
PrintMatrix(matrixArr);
PrintFindIndexArr(matrixArr, row, col);

int[,] CreateMatrixRndDbl(int row, int col, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 1}, ");
            else Console.Write($"{ matrix[i, j], 1}");
        }
        Console.WriteLine("]");
    }
}

void PrintFindIndexArr(int[,] matrix , int uRow, int uCol) 
{
    if (uRow > matrix.GetLength(0) && uCol > matrix.GetLength(1))
        Console.WriteLine("Указанные позиции элемента находятся за пределами массива!");
    else 
        Console.WriteLine($"Значение элемента по указанным позициям: {matrix[uRow, uCol]}");
}