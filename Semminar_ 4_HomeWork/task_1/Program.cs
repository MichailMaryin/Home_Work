Console.Clear();
Console.Write("Enter A = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter B = ");
int b = int.Parse(Console.ReadLine());

double c =Convert.ToInt64(Math.Pow(a, b));
Console.Write("Итог = ");
Console.WriteLine(c);