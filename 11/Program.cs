Console.WriteLine("Ввести минуты");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввести a");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввести b :");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввести c :");
double c = Convert.ToDouble(Console.ReadLine());

double z;

if (x <= a)
{
    z = b;

}
else
{

    z = x*b/a*b+(x-a)*c;
}
Console.WriteLine($"Оплата в этом месяце составит: {z}");