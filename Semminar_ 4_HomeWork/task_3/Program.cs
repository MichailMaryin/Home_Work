
void FillArrayRandomNumbers(int[] array)

{
    
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray( int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 
Console.Clear();

int[] a =new int[7];

FillArrayRandomNumbers(a);

PrintArray(a);
