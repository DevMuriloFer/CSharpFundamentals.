using _14_Interfaces_IoC.Services;
using _14_Interfaces_IoC.Entities;
using _14_Interfaces_IoC.Utils;

try
{
    Console.WriteLine("Enter contract data: ");
    Console.Write("Number: ");
    var number = ConsoleInputHelper.ReadInt(1, 99999999, "number of contract");

    Console.Write("Date (DD/MM/YY): ");
    var date = ConsoleInputHelper.ReadDateTime();

    Console.Write("Contract value: ");
    var contractValue = ConsoleInputHelper.ReadDecimal(200.00M, "contract value");

    Console.Write("Enter the number of installments: ");
    var numberOfInstallments = ConsoleInputHelper.ReadInt(1, 24, "number of installments");

    Contract contract = new Contract(number, date, contractValue);
    PayPalPaymentServiceTax PayPalTax = new PayPalPaymentServiceTax();
    InstallmentCalculator installmentCalculator = new InstallmentCalculator(PayPalTax);

    installmentCalculator.Generate(contract, numberOfInstallments);
    Console.WriteLine("\nInstallments: ");
    Console.WriteLine(contract.InstallmentsNotePrinter());

    installmentCalculator.TotalValue(contract);
    Console.WriteLine(FormattableString.Invariant($"TOTAL: {contract.TotalValue:F2}"));
}
catch (Exception e)
{
    Console.WriteLine("Sorry an critical unexpected error occurred and the program was finished.");
    Console.WriteLine($"Technical details: {e.Message}");
}
