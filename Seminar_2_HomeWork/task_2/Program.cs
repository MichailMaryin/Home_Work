int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
    return 0;
}

for (int i = 10; num > 999;)
{
   num /= i;
}

System.Console.WriteLine(num%10);

return 0;


