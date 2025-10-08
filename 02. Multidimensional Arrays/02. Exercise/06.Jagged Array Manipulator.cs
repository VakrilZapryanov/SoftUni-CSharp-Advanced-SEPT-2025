int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] currentRow = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    jaggedArray[row] = currentRow;
}

for (int row = 0; row < rows - 1; row++)
{

    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        Multiply(jaggedArray[row]);
        Multiply(jaggedArray[row + 1]);
    }
    else
    {
        Divide(jaggedArray[row]);
        Divide(jaggedArray[row + 1]);
    }
    
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();

    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);

    if (row >= 0 && row < rows &&
        col >= 0 && col < jaggedArray[row].Length)
    {
        if (command.StartsWith("Add"))
        {
            jaggedArray[row][col] += value;
        }
        else if (command.StartsWith("Subtract"))
        {
            jaggedArray[row][col] -= value;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    Console.WriteLine(string.Join(" ", jaggedArray[row]));
}

static void Divide(int[] currentRow)
{
    for (int i = 0; i < currentRow.Length; i++)
    {
        currentRow[i] /= 2;
    }
}

static void Multiply(int[] currentRow)
{
    for (int i = 0; i < currentRow.Length; i++)
    {
        currentRow[i] *= 2;
    }
}