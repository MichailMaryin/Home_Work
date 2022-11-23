
Console.WriteLine("enter x1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter z1 : ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter x2 : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter y2 : ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter z2 : ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist =Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine(dist);