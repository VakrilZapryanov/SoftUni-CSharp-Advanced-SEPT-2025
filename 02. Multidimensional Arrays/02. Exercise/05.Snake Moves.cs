int[] matrixDimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixDimensions[0], cols = matrixDimensions[1];

string snake = Console.ReadLine();

Queue<char> snakeSymbols = new(snake);

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = NextSymbol(snakeSymbols);
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = NextSymbol(snakeSymbols);
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}

static char NextSymbol(Queue<char> snakeSymbols)
{
    char symbol = snakeSymbols.Dequeue();

    snakeSymbols.Enqueue(symbol);

    return symbol;
}