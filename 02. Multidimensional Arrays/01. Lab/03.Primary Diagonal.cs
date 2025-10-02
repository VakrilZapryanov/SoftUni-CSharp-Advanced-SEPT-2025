int size = int.Parse(Console.ReadLine());

int rows = size, cols = size;

var matrix = ReadMatrix(rows, cols);

int sum = default;
for (int i = 0; i < size; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum);

static int[,] ReadMatrix(int rows, int cols)
{
    var matrix = new int[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            int value = currentRow[col];
            matrix[row, col] = value;
        }
    }

    return matrix;
}