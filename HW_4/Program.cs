
Console.Clear();
Console.Write("Введите Число N = ");
int num = int.Parse(Console.ReadLine());
//int start = 1;


for (int start = 1;start <= num ;start++)
{
    if (start % 2 == 0)
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
