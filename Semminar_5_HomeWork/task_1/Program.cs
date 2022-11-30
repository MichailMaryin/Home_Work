//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void FillArrayRandomNumbers(int[] array)

{
    for (int i = 0; i < array.Length; i++)
     {
        array[i] = new Random().Next(100, 999);
     }   
}

void FindEvenNumber(int[] array)
{
    int count = 0;
    for(int i= 0;i<array.Length;i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array =new int[4];

FillArrayRandomNumbers(array);

PrintArray(array);

FindEvenNumber(array);



