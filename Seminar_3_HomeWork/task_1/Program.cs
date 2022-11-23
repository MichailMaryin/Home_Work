Console.WriteLine("на вход пятизначное число = ");
string num = Console.ReadLine();

if (num[0].ToString() == num[4].ToString())
{
    if (num[1].ToString() == num[3].ToString())
    {
         Console.WriteLine("является палиндромом");
    } 
    else
    {
        {
            Console.WriteLine("не является палиндромом");
        }
    }    
}
else
{
    {
        Console.WriteLine("не является палиндромом");
    }
}