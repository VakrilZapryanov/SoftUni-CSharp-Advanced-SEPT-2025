//Input
var tokens = Console.ReadLine()
    .Split()
    .Reverse()
    .ToArray();

//Calculations
var stack = new Stack<string>(tokens);

bool isAddition = true;
int sum = 0;

while (stack.Count > 0)
{
    var currentToken = stack.Pop();

    if (currentToken == "+")
    {
        isAddition = true;
    }
    else if (currentToken == "-")
    {
        isAddition = false;
    }
    else
    {
        int number = int.Parse(currentToken);

        if (!isAddition)
        {
            number *= -1;
        }

        sum += number;
    }
}

//Output
Console.WriteLine(sum);

/*
2 + 5 + 10 - 2 - 1
2 - 2 + 5

*/