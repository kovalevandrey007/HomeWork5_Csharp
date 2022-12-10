/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет 
количество чётных чисел в массиве.*/

int[] GetArray(int length)
{
    Random rnd = new Random();
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100,999);
    }
    return array;
}

int PositiveNum(int[] array)
{
    int PositiveNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >=100 && array[i]<= 999 && array[i]%2 == 0) PositiveNum++;
    }
    return PositiveNum;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write($"{array[i]}, ");
    }
}

Console.WriteLine("Ведите размер массива");
int[] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {PositiveNum(array)}");
