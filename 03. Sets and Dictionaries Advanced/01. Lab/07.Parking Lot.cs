HashSet<string> parking = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command.Split(", ");

    string direction = arguments[0];
    string carNumber = arguments[1];

    switch (direction)
    {
        case "IN":
            parking.Add(carNumber);

            break;
        case "OUT":
            if (parking.Contains(carNumber))
                parking.Remove(carNumber);

            break;
    }
}

if (parking.Any())
{
    foreach (var car in parking)
        Console.WriteLine(car);
}
else
    Console.WriteLine("Parking Lot is Empty");