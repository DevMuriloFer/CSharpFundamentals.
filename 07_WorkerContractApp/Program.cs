using WorkerContractApp.Entities.Enums;
using WorkerContractApp.Entities;
using System.Globalization;

Worker worker;
Department department;
string departmentName, name;
WorkerLevel level;
double baseSalary;
int contractsCount;
int monthCalculated, yearCalculated;
string monthAndYear;

Console.Write("Enter departments'name: ");
departmentName = Console.ReadLine();
Console.WriteLine("\nEnter Worker's data: ");
Console.Write("Name: ");
name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
baseSalary = double.Parse(Console.ReadLine());
Console.Write("Contracts amount: ");
contractsCount = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

department = new Department { Name = departmentName };
worker = new Worker { Name = name, BaseSalary = baseSalary, Level = level, Department = department };

for (int i = 0; i < contractsCount; i++)
{
    Console.WriteLine($"\nENTER THE #{i + 1} CONTRACT'S DATA:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value Per Hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int duration = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, duration);
    worker.AddContract(contract);
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
monthAndYear = Console.ReadLine();
monthCalculated = int.Parse(monthAndYear.Substring(0,2));
yearCalculated = int.Parse(monthAndYear.Substring(3, 4));
Console.Write($"Name: {worker.Name}");
Console.Write($"\nDepartment: {worker.Department.Name}");
Console.Write($"\nIncome for {monthAndYear}: {worker.Income(yearCalculated, monthCalculated).ToString("F2", CultureInfo.InvariantCulture)}");
Console.ReadKey(true);

