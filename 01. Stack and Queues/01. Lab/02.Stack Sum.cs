//Input
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

//Calculations
var stack = new Stack<int>(numbers);

string command = string.Empty;
while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] arguments = command.Split();

    switch (arguments[0])
    {
        case "add":
            int firstNumber = int.Parse(arguments[1]);
            int secondNumber = int.Parse(arguments[2]);

            stack.Push(firstNumber);
            stack.Push(secondNumber);
            break;
        case "remove":
            int numbersToRemove = int.Parse(arguments[1]);

            if (stack.Count - numbersToRemove > 0)
            {
                for (int i = 1; i <= numbersToRemove; i++)
                {
                    stack.Pop();
                }
            }
            break;
    }
}

//Output
Console.WriteLine($"Sum: {stack.Sum()}");