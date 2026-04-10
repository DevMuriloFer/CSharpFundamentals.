// this is a learning process about methods

//data input
Console.Write("enter first number: ");
double x = double.Parse(Console.ReadLine());

Console.Write("enter second number: ");
double y = double.Parse(Console.ReadLine());

Console.Write("enter third number: ");
double z = double.Parse(Console.ReadLine());

Console.Write("enter an integer number: ");
int j = int.Parse(Console.ReadLine());

Console.Write("enter the temperature in celsius: ");
double celsius = double.Parse(Console.ReadLine());

Console.Write("enter the password: ");
string passwordAttemp = (Console.ReadLine());

//data output
Console.WriteLine("---------------------------------------");
Console.WriteLine($"The biggest number of the first three entered is: {BiggestOf3(x, y, z)}");
Console.WriteLine($"{j} is even = {IsEven(j)}");
Console.WriteLine($"the temperature in Fahrenheit is: {CelsiusToFahrenheit(celsius):F2}");

if ((PasswordValidation(passwordAttemp)) == true)
{
    Console.WriteLine("The password is correct");
}
else
{
    Console.WriteLine("The password is wrong");
}


//method that returns which number is the biggest of 3
double BiggestOf3(double a, double b, double c)
{
    if (a > b && a > c)
    {
        return a;
    }
    else if (b > c)
    {
        return b;
    }
    else
    {
        return c;
    }
}

//method that checks if a integer number is even or not (True or False)
bool IsEven( int a)
{
    if (a % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//method that converts Celsius to Fahrenheit
double CelsiusToFahrenheit(double c)
{
    return c * 9 / 5 + 32;
}

// method that checks the password
bool PasswordValidation(string passwordTry)
{
    string password = "password123";

    if  (passwordTry == password)
    {
        return true;
    }
    else
    {
        return false;
    }
}
