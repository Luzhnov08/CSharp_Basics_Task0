/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = SliceTo3(number);
Calc(number);

void Calc(int num) 
{
    if (num >= 100 && num < 1000)
    {
        num = num % 10;
        Console.WriteLine(num);            
    }
    else 
    {
        Console.WriteLine("третьей цифры нет");
    }
}

int SliceTo3(int num) 
{
    if (num >= 1000) 
    {  
        num = num / 10;
        return SliceTo3(num);
    }
    return num;
}
