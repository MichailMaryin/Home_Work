Console.Clear();
Console.Write("Inter Number A = ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Inter Number B = ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Inter Number C = ");
int numC = int.Parse(Console.ReadLine());
int max = numA;

 if (max < numB)
    {
        if (numB > numC)
        {
        Console.Write("Number B Больше = ");
        Console.WriteLine(numB);
        }
        else
        {
            Console.Write("Number C Больше = ");
            Console.WriteLine(numC);
        }
    }
    else
    {
        if (max < numC)
        {
            Console.Write("Number C Больше = ");
            Console.WriteLine(numC);  
        }
        else
        {
            Console.Write("Number A Больше = ");
            Console.WriteLine(numA);  
        }
    }

