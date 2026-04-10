using _03_ClassesBasics;
using System.Globalization;

Triangle myTriangle = new Triangle();
double enterSide;
int isRunning = 1;

// menu loop (so the user can quit after any operation)
while (true)
{
    Console.Write($@"
Type 1 run the program
Type 0 to quit
Selected option: ");
    isRunning = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

// only break if the number is 0, so if the user enter the wrong number the program keep running
if (isRunning == 0)
    {
        break;
    }

    Console.Write("Enter de first side of the triangle: ");
    while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out enterSide) || enterSide <= 0)
    {
        Console.WriteLine("invalid input, enter only numbers (must be greater then 0)");
        Console.Write("Try again (first side): ");
    }
    myTriangle.SideA = enterSide;

    Console.Write("Enter de second side of the triangle: ");
    while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out enterSide) || enterSide <= 0)
    {
        Console.WriteLine("invalid input, enter only numbers (must be greater then 0)");
        Console.Write("Try again (second side): ");
    }
    myTriangle.SideB = enterSide;

    Console.Write("Enter de third side of the triangle: ");
    while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out enterSide) || enterSide <= 0)
    {
        Console.WriteLine("invalid input, enter only numbers (must be greater then 0)");
        Console.Write("Try again (third side): ");
    }
    myTriangle.SideC = enterSide;

    Console.WriteLine($@"
Perimeter:..........{myTriangle.Perimeter()}
Area:...............{myTriangle.Area()}", CultureInfo.InvariantCulture);

}
