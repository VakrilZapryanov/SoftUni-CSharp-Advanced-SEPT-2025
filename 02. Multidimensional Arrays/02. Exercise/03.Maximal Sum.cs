int[] matrixDimensions = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixDimensions[0], cols = matrixDimensions[1];

int[,] matrix = ReadMatrix(rows, cols);

int bestRow = default, bestCol = default, bestSum = int.MinValue;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if (currentSum > bestSum)
        {
            bestRow = row;
            bestCol = col;
            bestSum = currentSum;
        }
    }
}

Console.WriteLine("Sum = " + bestSum);
Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]} {matrix[bestRow, bestCol + 2]}");
Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]} {matrix[bestRow + 1, bestCol + 2]}");
Console.WriteLine($"{matrix[bestRow + 2, bestCol]} {matrix[bestRow + 2, bestCol + 1]} {matrix[bestRow + 2, bestCol + 2]}");

static int[,] ReadMatrix(int rows, int cols)
{
    var matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}