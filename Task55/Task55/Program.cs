/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

int[,] array = CreateMatrixRndInt(3, 3, 10, 99);
PrintMatrix(array, "Заданный массив:");
if (SqrMatrix(array))
{
    int[,] resArr = SwapRowToCol(array);
    PrintMatrix(resArr, "Преобразованный массив:");
}
else Console.WriteLine("Невозможно транспонировать массив");

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

int[,] SwapRowToCol(int[,] matrix) 
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] revArr = new int[row, col];

    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < col; j++)
        {
            revArr[i, j] = matrix[j, i];
        }
    }
    return revArr;
}

bool SqrMatrix(int[,] matrix) 
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}