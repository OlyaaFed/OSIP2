
﻿Console.WriteLine("Ввести m :");
double m = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввести n :");
double n = Convert.ToDouble(Console.ReadLine());


if (m != n)

{
    if (m > n)
    
    {

        Console.WriteLine("m Больше");
        n = m;
    }
    
    else
    
    {
        Console.WriteLine("n Больше");
        m = n;
    }
}

else
{

    Console.WriteLine("m И n равны");
    m = n = 0;
}
Console.WriteLine($"m = {m}");
Console.WriteLine($"n = {n}");

