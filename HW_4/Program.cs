
Console.Clear();
Console.Write("Введите Число N = ");
int num = int.Parse(Console.ReadLine());
//int start = 1;
int i = 1; // 1 - не четные числа ; 0 - Четные

for (int start = 1;start <= num ;start++)
{
    if (start % 2 == i)
    {
        Console.WriteLine(start);
    }
}

//while (start < num + 1)
//{
//    if (start % 2 == 1)
//    {
//        start++;
//    }
//    else
//    {
//        Console.WriteLine(start);
//        start++;
//    }   
//}
