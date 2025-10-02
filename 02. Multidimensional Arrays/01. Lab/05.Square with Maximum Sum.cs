int[] matrixSize = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0], cols = matrixSize[1];

var matrix = ReadMatrix(rows, cols);


int topSum = default, topRow = default, topCol = default;

for (int row = 0; row < rows - 1; row++)
{
    int sum = default;

    for (int col = 0; col < cols - 1; col++)
    {
        sum = matrix[row, col] +
              matrix[row, col + 1] +
              matrix[row + 1, col] +
              matrix[row + 1, col + 1];

        if (sum > topSum)
        {
            topSum = sum;
            topRow = row;
            topCol = col;
        }
    }
}

Console.WriteLine(matrix[topRow, topCol] + " " + matrix[topRow, topCol + 1]);
Console.WriteLine(matrix[topRow + 1, topCol] + " " + matrix[topRow + 1, topCol + 1]);
Console.WriteLine(topSum);

static int[,] ReadMatrix(int rows, int cols)
{
    var matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}
