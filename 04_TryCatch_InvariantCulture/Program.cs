using _04_TryCatch_InvariantCulture;
using System.Globalization;

Customer myCustomer = new Customer();

Console.Write("Enter the customer name: ");
myCustomer.Name = (Console.ReadLine());

bool validAnswer1 = false;
while (!validAnswer1)
{
    try
    {
        Console.Write("Enter the customer age: ");
        myCustomer.Age = int.Parse(Console.ReadLine());
        validAnswer1 = true;
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"invalid input. {ex.Message}");
        Console.WriteLine("Please, Try again.");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error. You must enter only numbers");
        Console.WriteLine("Please, Try again.");
    }
}

bool validAnswer2 = false;
while (!validAnswer2)
{
    try
    {
        Console.Write("Enter the customer account balance: ");
        myCustomer.AccountBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        validAnswer2 = true;
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"invalid input. {ex.Message}");
        Console.WriteLine("Please, Try again.");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Error. You must enter only numbers");
        Console.WriteLine("Please, Try again.");
    }
}

Console.WriteLine($@"
----------------CUSTOMER DATA----------------
{myCustomer}"
);