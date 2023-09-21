
Console.WriteLine("Ввести x :");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввести y :");
double y = Convert.ToDouble(Console.ReadLine());

if (x > y)
{
    Console.WriteLine(" Больше x");
    x = x * y * 2;
    y = (x + y) / 2;
}
else
{
    Console.WriteLine("Больше y");
    y = x + y;
    x = x * y / 2;
}

Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
