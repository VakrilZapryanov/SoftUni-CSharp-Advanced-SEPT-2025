int[] matrixDimensions = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rows = matrixDimensions[0], cols = matrixDimensions[1];

string[,] matrix = ReadMatrix(rows, cols);

int squaresCount = default;
for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] &&
            matrix[row, col] == matrix[row + 1, col] &&
            matrix[row, col] == matrix[row + 1, col + 1])
        {
            squaresCount++;
        }
    }
}

Console.WriteLine(squaresCount);

static string[,] ReadMatrix(int rows, int cols)
{
    var matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] currentRow = Console.ReadLine().Split();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}
