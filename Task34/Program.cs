/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите
 количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] GetArray(int length)
{
    Random rnd = new Random();
    int [] array = new int [123];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(length);
    }
    return array;
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < 123; i++)
    {
        if (array[i] >=10 && array[i]<= 99) count++;
    }
    return count;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < 123; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


Console.WriteLine("Ведите размер массива");
int[] array = GetArray(int.Parse(Console.ReadLine()));

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество элементов массива, лежащие на отрезке [10,99] = {Count(array)}");
