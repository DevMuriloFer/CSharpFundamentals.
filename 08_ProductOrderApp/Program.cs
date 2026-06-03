using _08_ProductOrderApp.Entities;
using _08_ProductOrderApp.Entities.Enums;

Console.WriteLine("ENTER CUSTOMER DATA: ");
Console.Write("Name: ");
var name = Console.ReadLine();
Console.Write("Email: ");
var email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
var birthDate = DateTime.Parse(Console.ReadLine());
var client = new Client(name, email, birthDate);

Console.WriteLine("\nENTER THE ORDER DATA:");
Console.Write("Status (Pending_Payment / Processing / Shipped / Delivered): ");

var status = Enum.Parse<OrderStatus>(Console.ReadLine());
var order = new Order(DateTime.Now, status);

Console.Write("How many items to this order? ");
var itemsCount = int.Parse(Console.ReadLine());
for (int i = 1; i <= itemsCount; i++)
{
    Console.WriteLine($"\nEnter #{i} item data: ");
    Console.Write("Product name: ");
    var productName = Console.ReadLine();
    Console.Write("Product price: ");
    var productPrice = double.Parse(Console.ReadLine());
    var product = new Product(productName, productPrice);

    Console.Write("Quantity: ");
    var quantity = int.Parse(Console.ReadLine());
    var orderItem = new OrderItem(quantity, productPrice, product);
    order.AddItem(orderItem);
}

Console.WriteLine("\nORDER SUMMARY: ");
Console.WriteLine($"Order moment: {order.Date}");
Console.WriteLine($"Order status: {order.Status}");
Console.WriteLine($"Client: {client.Name} ({client.BirthDate.ToString("dd/MM/yyyy")}) - {client.Email}");
Console.WriteLine("Order items: ");
foreach (OrderItem orderItem in order.OrderItems) 
{
    Console.WriteLine($"{orderItem.Product.Name}, Quantity: {orderItem.Quantity}, Subtotal: ${orderItem.subTotal():F2}");
    
}
Console.WriteLine($"Total Price: {order.Total():F2}");