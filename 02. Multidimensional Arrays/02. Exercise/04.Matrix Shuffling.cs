int[] matrixDimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixDimensions[0], cols = matrixDimensions[1];

string[,] matrix = ReadMatrix(rows, cols);

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (arguments[0] != "swap" || arguments.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    int row1 = int.Parse(arguments[1]);
    int col1 = int.Parse(arguments[2]);
    int row2 = int.Parse(arguments[3]);
    int col2 = int.Parse(arguments[4]);

    if (row1 >= 0 && row1 <= matrix.GetLength(0) &&
        row2 >= 0 && row2 <= matrix.GetLength(0) &&
        col1 >= 0 && col1 <= matrix.GetLength(1) &&
        col2 >= 0 && col2 <= matrix.GetLength(1))
    {
        string original = matrix[row1, col1];

        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = original;

        PrintMatrix(matrix);
    }
    else
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}

static string[,] ReadMatrix(int rows, int cols)
{
    var matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] currentRow = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}