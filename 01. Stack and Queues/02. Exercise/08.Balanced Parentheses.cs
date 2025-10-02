string sequence = Console.ReadLine();

Stack<char> openingBrackets = new();

bool isValid = true;

foreach (var symbol in sequence)
{
    if (symbol == '(' || symbol == '[' || symbol == '{')
        openingBrackets.Push(symbol);
    else
    {
        if (!openingBrackets.Any())
        {
            isValid = false;
            break;
        }

        char currentOpeningBracket = openingBrackets.Pop();

        if (currentOpeningBracket == '(' && symbol == ')' ||
            currentOpeningBracket == '[' && symbol == ']' ||
            currentOpeningBracket == '{' && symbol == '}')
            continue;

        isValid = false;
    }
}

Console.WriteLine(isValid ? "YES" : "NO");