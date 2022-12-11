
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.WriteLine("Ведите размер массива");
int[] array = InitArray(int.Parse(Console.ReadLine()));
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
PrintArray(array);

int GetMaxAndMinDiff(int[] array)
{
    int diff = 0;
    int min =0;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i>max)
            i=max;
        else
        {
            i=min;
        }
        if(max>min)
        {
         diff = max-min;
        }
        else
        {
        diff = min - max;
        }
    }
    return diff;    
}
int diff = GetMaxAndMinDiff (array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");
Console.WriteLine();