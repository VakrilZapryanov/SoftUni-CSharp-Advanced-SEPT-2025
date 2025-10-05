int size = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix(size);

int primaryDiagonalSum = default;
for (int row = 0; row < size; row++)
{
    int col = row;

    primaryDiagonalSum += matrix[row, col];
}

int secondaryDiagonalSum = default;
for (int row = 0; row < size; row++)
{
    secondaryDiagonalSum += matrix[row, size - row - 1];
}

Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));

static int[,] ReadMatrix(int size)
{
    var matrix = new int[size, size];

    for (int row = 0; row < size; row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < size; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}