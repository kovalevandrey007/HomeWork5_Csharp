
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

/*int[] InitArray(int length)
{
    int[] array = new int[i];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 10);
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

//получает сумму положительных элементов в массиве
*/

double[] arr = new double [7];
Random rnd = new Random();
        arr[i] = -5.0+ rnd.NextDouble()*(-5.0 + 10.5);

(double, double) GetMaxAndMinDiff (double[] arr);
{
    double max =0;
    double min = 0;
    for (int i = 0; i < arr.Length; i++)

    if(min>i)
    {
     min = i;
     }
    else
    {
    max = i;
    }
double result = 0;
    {
    if(max>min)
    result = max-min;
    else
    result  = min-max;
    }
    return result;
}
void PrintArray(double[] arr, double min, double max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
Console.WriteLine();
}
//(double min double max) = GetMaxMinDiff(arr);

/*






int GetMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(max>i)
        {
            max = arr[i];
        }
    }
    return max;
}

int GetMin (int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (i < min) 
        {
            min = arr[i];
        }
       return min;
    }
}

(int, int) GetDiff (int[] arr);
int max = GetMax(arr[i]);
int min = GetMin(arr[i]);
int diff = GetDiff(max, min);
    {
     diff = max - min;
     }
      return diff;



/*
int, int) GetPositiveAndNegativeSumm(int[] array)
{
    int positive = 0;
    int negative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            positive += array[i];
        else
            negative += array[i];
    }

    return (positive, negative);
}

int[] arr = InitArray(12);
PrintArray(arr);
int positiveSumm = GetPositiveSumm(arr);
int negativeSumm = GetNegativeSumm(arr);

(int pos, int neg) = GetPositiveAndNegativeSumm(arr);




//кортедж
//получает сумму отрицательных элементов в массиве

/*int GetDiff(int[] arr)
{
    int diff= 0;
    for (int i = 1; i < arr.Length; i++)
    {
       if(arr[i] > 0)
        {
           diff = max - min;
        }
    }
    return diff;
}
*//*
(int max, int min) GetMaxMinDiff(int[] array)
{
 int diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            diff = max - min;
        }
       
    return diff;
}
}
   */

//Console.WriteLine($"Сумма положительных: {pos}. Сумма отрицательных: {neg}");

/*class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] d = new int[30];
            int max=0, min=100;
            for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }
           
               for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
               Console.WriteLine();
                 Console.WriteLine("max:  " + max);
                 Console.WriteLine("min  " + min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                Console.ReadKey();
        }
    }
*/