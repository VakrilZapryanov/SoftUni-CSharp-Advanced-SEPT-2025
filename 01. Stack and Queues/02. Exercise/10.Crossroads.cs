int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

Queue<string> cars = new();
string hitSymbol = string.Empty;
bool crashed = false;
string crashedCar = string.Empty;
int passedCars = default;

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "green")
    {
        int secondsToPass = greenLight;
        string currentCar = string.Empty;
        string partsFreeWindow = string.Empty;

        while (cars.Any() && secondsToPass > 0)
        {
            currentCar = cars.Dequeue();

            if (currentCar.Length <= secondsToPass)
            {
                secondsToPass -= currentCar.Length;
                passedCars++;
            }
            else
            {
                int pastParts = currentCar.Length - secondsToPass;
                int lastIndex = currentCar.Length - pastParts;

                partsFreeWindow = currentCar.Substring(lastIndex);
                break;
            }
        }

        if (partsFreeWindow.Length > freeWindow)
        {
            hitSymbol = partsFreeWindow.Remove(0, freeWindow)[0].ToString();

            crashed = true;
            crashedCar = currentCar;
            break;
        }
        else if (partsFreeWindow.Length > 0)
        {
            passedCars++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}

if (!crashed)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
}
else
{
    Console.WriteLine("A crash happened!");
    Console.WriteLine($"{crashedCar} was hit at {hitSymbol}.");
}
