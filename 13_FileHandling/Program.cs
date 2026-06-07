using System.Globalization;
using _13_FileHandling.Entities;
//project path
string exePath = AppDomain.CurrentDomain.BaseDirectory;

//folders path
string folderDataPath = Path.Combine(exePath, "Data");
string folderOutPath = Path.Combine(exePath, "Out");
Directory.CreateDirectory(folderOutPath);

//files path
string fileItemsSoldPath = Path.Combine(folderDataPath, "ItemsSold.csv");
string fileSummaryPath = Path.Combine(folderOutPath, "Summary.csv");

var orders = new List<Order>();
try
{
    using var reader = new StreamReader(fileItemsSoldPath);
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        string[] orderData = line.Split(",");
        var name = orderData[0];
        var price = double.Parse(orderData[1], CultureInfo.InvariantCulture);
        var quantity = int.Parse(orderData[2]);
        var product = new Product(name, price);
        var order = new Order(product, quantity);

        orders.Add(order);
    }
    using var writer = new StreamWriter(fileSummaryPath);
    foreach(Order o in orders)
    {
        writer.WriteLine(FormattableString.Invariant($"{o.Product.Name},{o.Total()}"));
    }

    Console.WriteLine("Program successfully completed!");
    Console.WriteLine($"The result was saved in: {fileSummaryPath}");
}
catch (IOException e)
{
    Console.WriteLine("Error: The file was not found");
    Console.WriteLine($"Thecnical details: {e.Message}");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Error: The file is corrupted");
    Console.WriteLine("Not all the lines have a sufficient amount of data");
    Console.WriteLine($"Technical details: {e.Message}");
}
catch(FormatException e)
{
    Console.WriteLine("Error: The file is corrupted");
    Console.WriteLine("Not all values are numerical");
    Console.WriteLine($"Thecnical details: {e.Message}");
}
catch(Exception e)
{
    Console.WriteLine("Error: An unexpected error occurred");
    Console.WriteLine($"Thecnical details: {e.Message}");
}