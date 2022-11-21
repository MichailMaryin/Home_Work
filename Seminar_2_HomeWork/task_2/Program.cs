int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("неправильный ввод");
    return 0;
}

int num = number;

for (int i = 10; num > 999;)
{
    num /= i;
}

System.Console.WriteLine(num%10);

return 0;


