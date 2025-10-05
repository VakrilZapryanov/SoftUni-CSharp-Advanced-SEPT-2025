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

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command.Split();

    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);

    switch (arguments[0])
    {
        case "Add":
            if (!ValidRowsAndCols(jaggedArray, row, col))
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }

            jaggedArray[row][col] += value;

            break;
        case "Subtract":
            if (!ValidRowsAndCols(jaggedArray, row, col))
            {
                Console.WriteLine("Invalid coordinates");
                break;
            }

            jaggedArray[row][col] -= value;

            break;
    }
}

for (int row = 0; row < jaggedArray.Length; row++)
{
    Console.WriteLine(string.Join(" ", jaggedArray[row]));
}


static bool ValidRowsAndCols(int[][] jaggedArray,int row, int col)
{
    bool isValid = false;

    if (row >= 0 && row < jaggedArray.Length &&
        col >= 0 && col < jaggedArray[row].Length)
        isValid = true;

    return isValid;
}