/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


void FillArrayRandomNumbers(int[] array)

{
    for (int i = 0; i < array.Length; i++)
     {
        array[i] = new Random().Next(1, 10);
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

void FindSumEvenNumber(int[] array)
{
    int sum = 0;
    for(int i= 0;i<array.Length;i++)
    {
        if (array[i]%2== 1)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);
}


int[] array =new int[4];

FillArrayRandomNumbers(array);

PrintArray(array);

FindSumEvenNumber(array);