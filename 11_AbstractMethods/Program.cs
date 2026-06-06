using _11_AbstractMethods.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
var taxPayerCount = int.Parse(Console.ReadLine());
List<TaxPayer> taxPayers = new List<TaxPayer>(taxPayerCount);

for(int i = 0; i < taxPayerCount; i++)
{
    Console.WriteLine($"\e[1mTax Payer #{i + 1} data:\e[0m");
    Console.Write($"Individual or Company? (i / c): ");
    var type = char.ToLower(Console.ReadLine()[0]);
    Console.Write("Name: ");
    var name = Console.ReadLine();
    Console.Write("Anual Income: ");
    var income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(type == 'i')
    {
        Console.Write("Health Expanditure: ");
        var healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var taxPayer = new Individual(name, income, healthExp);
        taxPayers.Add(taxPayer);
    }
    else
    {
        Console.Write("Number of employees: ");
        var numberOfEmployees = int.Parse(Console.ReadLine());
        var taxPayer = new Company(name, income, numberOfEmployees);
        taxPayers.Add(taxPayer);
    }
}
Console.WriteLine("\n\e[1mTAXES PAID\e[0m");
foreach(TaxPayer acc in taxPayers)
{
    Console.WriteLine(acc.NameAndTax());
}
double totalTaxes = 0;
foreach(TaxPayer acc in taxPayers)
{
    totalTaxes += acc.TaxCalculator();
}
Console.WriteLine($"\nTotal Taxes: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
