/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

void FillArrayRandomNumbers(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// double FindMin(double Max, double[] Array)
// {
//     double min = Max;
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] < min)
//             min = Array[i];
//     }
//     return min;
// }

// double FindMax(double Min, double[] Array)
// {
//     double max = Min;
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] > max)
//             max = Array[i];
//     }
//         return max;
// }

int FindMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }

    }
    return min;
}

int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }

    }
    return max;
}

int PrintMaxMinusMin(int max, int min)
{
    int minus = max - min;
    Console.Write(minus);
    return minus;
}



Console.Clear();
int[] array =new int[4];


FillArrayRandomNumbers(array);
PrintArray(array);

int min = FindMin(array);
int max = FindMax(array);
PrintMaxMinusMin(max,min);
