int totalPetrolPumps = int.Parse(Console.ReadLine());

Queue<int[]> pumps = new();

for (int i = 0; i < totalPetrolPumps; i++)
{
    int[] currentPump = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    pumps.Enqueue(currentPump);
}

int position = default;

while (true)
{
    int fuel = 0;

    foreach (var pump in pumps)
    {
        int fuelInPump = pump[0];
        int distance = pump[1];

        fuel += fuelInPump - distance;

        if (fuel < 0)
        {
            position++;
            pumps.Enqueue(pumps.Dequeue());
            break;
        }
    }

    if (fuel > 0)
    {
        Console.WriteLine(position);
        break;
    }
}