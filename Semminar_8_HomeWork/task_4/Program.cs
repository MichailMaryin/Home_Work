// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


bool FindElement(int element, int[,,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k]== element) return true;
            
            }
        }
    }
    return false;
}

void FillArray(int[,,] baseArray)
{
    
    for (int i = 0; i <baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            int k = 0;
            while(k<baseArray.GetLength(2))
            {
                var rnd = new Random().Next(10,100);
                if(!FindElement(rnd,baseArray))
                {
                    baseArray[i,j,k] = rnd;
                    k++;    
                }
            }
        }
    }   
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})\t");
            
            }
        }
        Console.WriteLine();
    } 
    
}
Console.Write("Введите X - ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y - ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z - ");
int z = int.Parse(Console.ReadLine()!);

int[,,] baseArray =new int[x,y,z];

FillArray(baseArray);
PrintArray(baseArray);