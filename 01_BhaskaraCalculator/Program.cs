// coeficients
Double a, b, c;
Double delta;
Double root1, root2;

Console.WriteLine("BHASKARA CALCULATOR \n");
Console.Write("type coeficient a:");
a = Double.Parse(Console.ReadLine());

Console.WriteLine("BHASKARA CALCULATOR \n");
Console.Write("type coeficient b:");
b = Double.Parse(Console.ReadLine());

Console.WriteLine("BHASKARA CALCULATOR \n");
Console.Write("type coeficient c:");
c = Double.Parse(Console.ReadLine());

delta = Math.Pow(b, 2) - (4 * a * c);

if (delta < 0)
{
    Console.WriteLine("delta is lower than 0. There are no roots");
}
else
{
    root1 = (-b + Math.Sqrt(delta)) / (2 * a);
    root2 = (-b - Math.Sqrt(delta)) / (2 * a);

    if (root1 == root2)
    {
        Console.WriteLine($"this function only have one root equal to {root1}");
    }
    else
    {
        Console.WriteLine($"root 1 equal to: {root1}");
        Console.WriteLine($"root 2 equal to: {root2}");
    }
}