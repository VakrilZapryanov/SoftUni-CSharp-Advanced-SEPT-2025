//Input
int bulletPrice= int.Parse(Console.ReadLine());
int barrelSize = int.Parse(Console.ReadLine());

int[] bulletsInformation = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] locksInformation = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int intelligenceValue = int.Parse(Console.ReadLine());

//Action
Stack<int> barrel = new(bulletsInformation);
Queue<int> locks = new(locksInformation);

int bulletCounter = default;
int totalBullets = default;

while (locks.Count > 0)
{
    if (barrel.Count == 0) break;

    int currentBullet = barrel.Pop();
    int currentLock = locks.Peek();

    bulletCounter++;
    totalBullets++;

    if (currentBullet <= currentLock)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
        Console.WriteLine("Ping!");

    if (bulletCounter == barrelSize && barrel.Count > 0)
    {
        bulletCounter = 0;
        Console.WriteLine("Reloading!");
    }
}

//Output
if (locks.Count == 0)
    Console.WriteLine($"{barrel.Count} bullets left. Earned ${intelligenceValue - (bulletPrice * totalBullets)}");
else
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
