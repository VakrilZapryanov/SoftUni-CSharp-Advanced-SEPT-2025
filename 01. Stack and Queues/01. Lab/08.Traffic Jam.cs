//Input
int n = int.Parse(Console.ReadLine());

//Calculations
var queue = new Queue<string>();
int counter = default;

string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    if (command == "green")
    {
        for (int i = 1; i <= n; i++)
        {
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue() + " passed!");
                counter++;
            }
        }
        continue;
    }

    string currentCar = command;

    queue.Enqueue(currentCar);
}

//Output
Console.WriteLine($"{counter} cars passed the crossroads.");
