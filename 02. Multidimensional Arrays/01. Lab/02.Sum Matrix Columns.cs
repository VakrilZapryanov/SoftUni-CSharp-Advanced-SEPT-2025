int[] matrixSize = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

var matrix = ReadMatrix(rows, cols);

for (int col = 0; col < cols; col++)
{
    int sum = default;

    for (int row = 0; row < rows; row++)
    {
        sum += matrix[row, col];
    }

    Console.WriteLine(sum);
}

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int value = currentRow[col];

            matrix[row, col] = value;
        }
    }

    return matrix;
}