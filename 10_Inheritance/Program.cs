using _10_Inheritance.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
var ProductsCount = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();
for (int i = 0; i < ProductsCount; i++)
{
    Console.WriteLine($"\x1b[1mProduct #{i+1} data\x1b[0m");
    Console.Write("Common, Used or Imported? (c / u / i): ");
    var type = char.ToLower(Console.ReadLine()[0]);
    Console.Write("Name: ");
    var name = Console.ReadLine();
    Console.Write("Price: ");
    var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    if (type == 'i')
    {
        Console.Write("Custom fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var imported = new ImportedProduct(name, price, fee);
        products.Add(imported);
    }
    else if (type == 'u')
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        var used = new UsedProduct(name, price, date);
        products.Add(used);
    }
    else
    {
        var common = new Product(name, price);
        products.Add(common);
    }
}
Console.WriteLine("\n\x1b[1mPrice Tags:\x1b[0m");
foreach (Product p in products)
{
    Console.WriteLine(p.PriceTag());
}
