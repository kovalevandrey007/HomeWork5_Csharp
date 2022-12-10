/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10,10);
    }
    return array;
}
//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetOddSumm(int[] arr)
{
    int OddSumm = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2 == 1)
        OddSumm += arr[i];
    }
    return OddSumm;
}
Console.WriteLine("Ведите размер массива");
int[] array = InitArray(int.Parse(Console.ReadLine()));
PrintArray(array);
int OddSumm = GetOddSumm(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {OddSumm}");

