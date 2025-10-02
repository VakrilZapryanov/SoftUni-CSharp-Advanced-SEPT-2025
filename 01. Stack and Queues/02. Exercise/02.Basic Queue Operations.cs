int[] arguments = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] n = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int s = arguments[1], x = arguments[2];

Queue<int> queue = new(n);

for (int i = 1; i <= s; i++)
    queue.Dequeue();

if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    bool isFound = false;
    int minNumber = int.MaxValue;

    foreach (var element in queue)
    {
        if (element == x && !isFound)
            isFound = true;

        minNumber = Math.Min(minNumber, element);
    }

    if (isFound)
        Console.WriteLine("true");
    else
        Console.WriteLine(minNumber);
}
