using _05_Lists;

List<Employee> employees = new List<Employee>();
int newEmployeesCount;

int idToIncreaseSalary;
int indexToIncreaseSalary;

double percentage;

//employee registration
Console.Write("How many employees will be registered?: ");
newEmployeesCount = int.Parse(Console.ReadLine());

for (int i =0; i < newEmployeesCount; i++)
{
    Console.Write(
        $"""

        Employee #{i + 1}:
        ID: 
        """);
    int id = int.Parse(Console.ReadLine()); 
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary  = double.Parse(Console.ReadLine());

    employees.Add(new Employee { Id = id, Name = name, Salary = salary});
}

//Salary increase
Console.Write("\nEnter the employee id that will have salary increase: ");
idToIncreaseSalary = int.Parse(Console.ReadLine());

indexToIncreaseSalary = employees.FindIndex(X => X.Id == idToIncreaseSalary);
if (indexToIncreaseSalary == -1)
{
    Console.WriteLine("This id does not exist!");
}
else
{
    Console.Write("Enter the percentage: ");
    percentage = double.Parse(Console.ReadLine());

    employees[indexToIncreaseSalary].increaseSalary(percentage);
}

//Displaying the updated employee list
Console.WriteLine("\nUpdated list of employees: ");
for(int i = 0; i < newEmployeesCount; i++)
{
    Console.WriteLine(employees[i]);
}
