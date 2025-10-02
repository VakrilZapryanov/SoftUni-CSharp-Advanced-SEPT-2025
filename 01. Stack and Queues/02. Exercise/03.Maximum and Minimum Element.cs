int queries = int.Parse(Console.ReadLine());

Stack<int> stack = new();

for (int i = 1; i <= queries; i++)
{
    int[] arguments = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    int queryCode = arguments[0];

    switch (queryCode)
    {
        case 1:
            stack.Push(arguments[1]);
            break;
        case 2:
            stack.Pop();
            break;
        case 3:
            if (stack.Count > 0) Console.WriteLine(stack.Max());
            break;
        case 4:
            if (stack.Count > 0) Console.WriteLine(stack.Min());
            break;
    }
}

Console.WriteLine(string.Join(", ", stack));
