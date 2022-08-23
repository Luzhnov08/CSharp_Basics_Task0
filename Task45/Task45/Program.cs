/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int[] CopyArray(int[] array) 
{
    int[] copyArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++) 
    {
        copyArr[i] = array[i];
    }
    copyArr[0] = 13;
    return copyArr;
}

int[] arr = CreateArrayRndInt(4, 0, 10);
PrintArray(arr);
int[] copied = CopyArray(arr);
PrintArray(copied);



