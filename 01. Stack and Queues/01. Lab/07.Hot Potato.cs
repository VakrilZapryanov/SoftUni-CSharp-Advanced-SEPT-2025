//Input
string[] names = Console.ReadLine().Split();
int n = int.Parse(Console.ReadLine());

//Calculations
var queue = new Queue<string>(names);

while (queue.Count > 1)
{
    for (int i = 1; i < n; i++)
    {
        string currentKid = queue.Dequeue();
        queue.Enqueue(currentKid);
    }

    Console.WriteLine("Removed " + queue.Dequeue());
}

//Output
Console.WriteLine("Last is " + queue.Dequeue());