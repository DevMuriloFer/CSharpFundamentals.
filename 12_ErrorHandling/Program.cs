using _12_ErrorHandling.Entities;
using _12_ErrorHandling.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
var number = int.Parse(Console.ReadLine());

Console.Write("Holder: ");
var holder = Console.ReadLine();

Console.Write("Initial balance: ");
var balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Withdraw limit: ");
var limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var acc = new Account(number, holder, balance, limit);

Console.Write("\nEnter amount for withdraw: ");
var withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    acc.Withdraw(withdrawAmount);
    Console.WriteLine(FormattableString.Invariant($"New Balance: {acc.Balance:F2}"));
}
catch (DomainException e)
{
    Console.WriteLine($"Withdraw error: {e.Message}");
}