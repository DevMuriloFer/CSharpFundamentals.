using System.Globalization;
namespace _15_Sets.Utils
{
    internal static class ConsoleInputHelper
    {
        public static decimal ReadDecimal( string inputName = "input", decimal min = decimal.MinValue)
        {
            decimal result = 0;
            bool invalidRange = true;
            while (invalidRange)
            {
                while (!decimal.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out result))
                {
                    Console.WriteLine($"ERROR: the {inputName} must be numeric.");
                    Console.Write("Please try again: ");
                }
                if (result >= min)
                {
                    invalidRange = false;
                }
                else
                {
                    Console.WriteLine($"ERROR: input out of range");
                    Console.WriteLine($"The {inputName} must be at least{min}");
                    Console.Write("Please try again: ");
                }
            }
            return result;
        }
        public static int ReadInt(string inputName = "input", int min = int.MinValue, int max = int.MaxValue)
        {
            int result = 0;
            bool invalidRange = true;
            while (invalidRange)
            {
                while (!int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out result))
                {
                    Console.WriteLine($"ERROR: the {inputName} must be numeric.");
                    Console.Write("Please try again: ");
                }
                if (result >= min && result <= max)
                {
                    invalidRange = false;
                }
                else
                {
                    Console.WriteLine($"ERROR: input out of range");
                    Console.WriteLine($"The {inputName} must be between {min} and {max}");
                    Console.Write("Please try again: ");
                }
            }
            return result;
        }
        public static DateTime ReadDateTime()
        {
            DateTime result;
            while (!DateTime.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"ERROR: the date must be in a valid format.");
                Console.Write("Please try again: ");
            }
            return result;
        }
    }
}
