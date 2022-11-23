Console.Clear();
Console.Write("Введите N = ");
int num = int.Parse(Console.ReadLine());

for(int ind = 1;ind < num + 1; ind++)
    {
        double number = Math.Pow(ind, 3); //ind * ind * ind;
        Console.WriteLine(number);
    }