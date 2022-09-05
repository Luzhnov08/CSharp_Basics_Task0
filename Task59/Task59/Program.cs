/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7*/

int[,] array = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array, "Заданный массив:");

int[,] minElemIds = FindMinElemInArray(array);
int[,] resArr = DeleteRowColumnFromArray(array, minElemIds);
PrintMatrix(resArr, "Преобразованный массив:");

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

int[,] DeleteRowColumnFromArray(int[,] matrix, int[,] minElemIndex)
{
    int arrRows = matrix.GetLength(0);
    int arrColumns = matrix.GetLength(1);
    int[,] resArr = new int[arrRows - 1, arrColumns - 1];

    int n = 0;
    for (int i = 0; i < arrRows; i++)
    {
        if (i != minElemIndex[0, 0])
        {
            int m = 0;
            for (int j = 0; j < arrColumns; j++)
            {
                if (j != minElemIndex[0, 1])
                {
                    resArr[n, m] = matrix[i, j];
                    m++;
                }
            }
            n++;
        }
    }
    return resArr;
}

int[,] FindMinElemInArray(int[,] matrix)
{
    int[,] minElemIndexes = new int[1, 2]; //координаты наименьшего элемента
    int minTempElemValue = matrix[0, 0];
    int arrRows = matrix.GetLength(0);
    int arrColums = matrix.GetLength(1);

    for (int i = 0; i < arrRows; i++)
    {
        for (int j = 0; j < arrColums; j++)
        {
            if (matrix[i, j] < minTempElemValue)
            {
                minTempElemValue = matrix[i, j];
                minElemIndexes[0, 0] = i;
                minElemIndexes[0, 1] = j;
            }
        }
    }
    Console.WriteLine($"Наименьший элемент - {minTempElemValue}");
    return minElemIndexes;
}