/* Задача 62: Заполните спирально массив 4 на 4
 1  2  3 4 
12 13 14 5
11 16 15 6
10  9  8 7
*/

int[,] array = new int[4, 4];
//FillArray(0, 0, 1);
FillSpiralIntMatrix(array);
PrintMatrix(array, "Спирально заполненный массив:");

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

void FillSpiralIntMatrix(int[,] matrix) 
{
    int valueInt = 1;
    int currIndex = 1;
    int row = 0;
    int col = 0;

    matrix[row, col] = valueInt++; //старт

    while (currIndex < matrix.Length) 
    {
        while (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == 0)  //вправо
        { 
            col++;
            matrix[row, col] = valueInt++;
            currIndex++;
        } 
        while (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == 0) //вниз
        { 
            row++;
            matrix[row, col] = valueInt++;
            currIndex++;
        } 
        while (col - 1 >= 0 && matrix[row, col - 1] == 0) //влево
        { 
            col--;
            matrix[row, col] = valueInt++;
            currIndex++;
        } 
        while (row - 1 >= 0 && matrix[row - 1, col] == 0) //вверх
        { 
            row--;
            matrix[row, col] = valueInt++;
            currIndex++;
        } 
    }
}

/*void FillArray(int posX, int posY, int num) 
{
    if (array[posX, posY] == 0) 
    {
        array[posX, posY] = num++;
        if (posY + 1 < array.GetLength(1)) FillArray(posX, posY + 1, num);
        if (posX + 1 < array.GetLength(0)) FillArray(posX + 1, posY, num);
        if (posY - 1 >= 0) FillArray(posX, posY - 1, num);
        if (posX - 1 >= 0) FillArray(posX - 1, posY, num);
    }
}*/

