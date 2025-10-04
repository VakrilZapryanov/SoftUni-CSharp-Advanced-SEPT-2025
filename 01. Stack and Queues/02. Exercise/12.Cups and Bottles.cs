int[] cupsCapacity = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] bottlesFilled = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> cups = new(cupsCapacity);
Stack<int> bottles = new(bottlesFilled);

int wastedLitters = default;

while (cups.Count > 0 && bottles.Count > 0)
{
    int currentCup = cups.Peek();

    while (bottles.Any())
    {
        int currentBottle = bottles.Pop();
        currentCup -= currentBottle;

        if (currentCup <= 0)
        {
            cups.Dequeue();

            int currentWastedWater = currentCup * -1;
            wastedLitters += currentWastedWater;

            break;
        }
    }

    if (cups.Count == 0)
    {
        Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
    }

    if (bottles.Count == 0)
    {
        Console.WriteLine($"Cups: {string.Join(" ", cups)}");
    }
}

Console.WriteLine($"Wasted litters of water: {wastedLitters}");