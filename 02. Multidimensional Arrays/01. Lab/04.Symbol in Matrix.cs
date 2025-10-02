int size = int.Parse(Console.ReadLine());

int rows = size, cols = size;

var matrix = ReadMatrix(rows, cols);

char symbol = char.Parse(Console.ReadLine());

bool isFound = false;
int symbolRow = default, symbolCol = default;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == symbol) 
        {
            isFound = true;
            symbolRow = row;
            symbolCol = col;
            break;
        }
    }

    if (isFound) break; 
}

if (isFound) Console.WriteLine($"({symbolRow}, {symbolCol})");
else Console.WriteLine($"{symbol} does not occur in the matrix"); 

static char[,] ReadMatrix(int rows, int cols) 
{
    var matrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        char[] currentRow = Console.ReadLine().ToCharArray();

        for (int col = 0; col < cols; col++) 
        {
            char value = currentRow[col]; 
            matrix[row, col] = value; 
        }
    }

    return matrix;
}