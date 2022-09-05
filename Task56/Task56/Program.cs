/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

int[,] array = CreateMatrixRndInt(3, 5, 10, 99);
PrintMatrix(array, "Заданный массив:");
Console.WriteLine();
FindMinSumInRow(array);

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

void FindMinSumInRow(int[,] matr)
{
    int maxRow = matr.GetLength(0);
    int maxCol = matr.GetLength(1);
    int[] sumArr = new int[maxRow];

    for (int i = 0; i < maxRow; i++)
    {
        int sum = 0;
        for (int j = 0; j < maxCol; j++)
        {
            sum += matr[i, j];
        }
        sumArr[i] = sum;
        Console.WriteLine($"Сумма строки {i} равна: {sum}");
    }

    int minSum = sumArr[0];
    int minRow = 0;
    for (int i = 0; i < maxRow; i++)
    {
        if (sumArr[i] < minSum) 
        {
            minSum = sumArr[i];
            minRow = i;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {minRow}");
}