// Подсчитать сумму цифр в числе
Console.Clear();

Console.WriteLine("Введите Число = ");
string num =Console.ReadLine();
int size =num.Length;
int index = 0;
int x = 0;

while (index < size)
{
    int a = int.Parse(num[index].ToString());
    x = x + a;
    index++;
}
Console.Write("итог = ");
Console.WriteLine(x);