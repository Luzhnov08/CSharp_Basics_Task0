/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Сколько чисел вы хотите ввести? Напишите целое число элементов:");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] arrNums = CreateFillArray(arrLen);
PrintCount(arrNums);

int[] CreateFillArray(int size) 
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число {i+1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintCount(int[] array) 
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0) counter++;
    }
    Console.WriteLine($"Элементов больше нуля: {counter}");
}