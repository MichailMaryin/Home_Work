// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int FindNumber(int[,] array, int number)
{
    
    if (number>array.GetLength(0))
    {   
        Console.WriteLine("Такого числа нет !!");
    }
    else
    {
        for (int i = 0; i <array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if ( number == array[i,j])
                {
                    Console.WriteLine($"Нужное Число находится в ячейке  [{i},{j}] ");
                    break;
                }
                
                
            }
        }
        
    }
    
    return 0;   
}




Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 10);
Console.Write("Введите  нужное число - ");
int number = int.Parse(Console.ReadLine()!);
FindNumber(array,number);

PrintArray(array);