// coefficients
double a, b, c;
double delta;
double root1, root2;

Console.WriteLine("BHASKARA CALCULATOR \n");
Console.Write("Enter coefficient a:");
a = double.Parse(Console.ReadLine());

Console.Write("Enter coefficient b:");
b = double.Parse(Console.ReadLine());

Console.Write("Enter coefficient c:");
c = double.Parse(Console.ReadLine());

delta = Math.Pow(b, 2) - (4 * a * c);

// if delta < 0 there are no real roots
if (delta < 0)
{
    Console.WriteLine("delta is negative. There are no real roots");
}
else
{
// check to prevent division by zero
    if (a == 0)
    {
        Console.WriteLine("a is equal to 0, this is not a quadratic function");
    }
    else
    {
        root1 = (-b + Math.Sqrt(delta)) / (2 * a);
        root2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (root1 == root2)
        {
            Console.WriteLine($"X1 = X2 = {root1}");
        }
        else
        {
            Console.WriteLine($"X1 = {root1}");
            Console.WriteLine($"X2 = {root2}");
        }
    }
}