// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] SizeMatrix()
{
    Console.WriteLine("Введите размер массива - ");
    int rows = int.Parse(Console.ReadLine()!);
    int colons = int.Parse(Console.ReadLine()!);
    return FillArray(new int[rows,colons]);
}

int[,] FillArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10);
        }
    }
    return matrix;
}
int[,] ProducrMatrix(int[,] matrix1, int[,] matrix2)
{
    
    if(matrix1.GetLength(1) != matrix2.GetLength(0)){
        System.Console.WriteLine("Матрицы невозможно перемножить в таком порядке");
        return matrix1;
    }
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i,j]+= matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix3;
}


int[,] MatrixArray1 = SizeMatrix();
int[,] MatrixArray2 = SizeMatrix();
int[,] Matrix = ProducrMatrix(MatrixArray1,MatrixArray2);
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        System.Console.Write($"{Matrix[i,j]}\t");
    }
    System.Console.WriteLine();
}