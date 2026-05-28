using System.Globalization;
//matrix itself
int rows, columns;
int[,] matrix;

//input
string[] input;

//number researched and his index
int numberResearched;
List<int> rowFound = new List<int>();
List<int> columnFound = new List<int>();

//building the matrix
Console.WriteLine("Enter: *number of rows* space *number of columns*");
input = Console.ReadLine().Split(" ");
rows = int.Parse(input[0]);
columns = int.Parse(input[1]);
matrix = new int[rows, columns];

Console.WriteLine("\nWith the numbers separated by a space:\n");
for (int i = 0; i < rows; i++)
{
    Console.WriteLine($"Enter the {i + 1}° row:");
    input = Console.ReadLine().Split(" ");
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = int.Parse(input[j]);
    }
}

//searching the number
Console.WriteLine("\nEnter the number for search");
numberResearched = int.Parse(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (matrix[i, j] == numberResearched)
        {
            rowFound.Add(i);
            columnFound.Add(j);
        }
    }
}

//printing the result
if(rowFound.Count == 0)
{
    Console.WriteLine("\nThis number does not exist in this matrix.");
}
else
{
    for(int i = 0; i < rowFound.Count; i++)
    {
        Console.WriteLine($"\nPosition: {rowFound[i]}, {columnFound[i]}");
        if (rowFound[i] != 0) 
        { 
            Console.WriteLine($"Up: {matrix[rowFound[i] - 1, columnFound[i]]}"); 
        }
        if (columnFound[i] != 0) 
        { 
            Console.WriteLine($"Left: {matrix[rowFound[i], columnFound[i] - 1]}"); 
        }
        if (rowFound[i] != matrix.GetLength(0) -1) 
        { 
            Console.WriteLine($"Down: {matrix[rowFound[i] + 1, columnFound[i]]}"); 
        }
        if (columnFound[i] != matrix.GetLength(1) - 1) 
        { 
            Console.WriteLine($"Right: {matrix[rowFound[i], columnFound[i] + 1]}"); 
        }
    }
}
