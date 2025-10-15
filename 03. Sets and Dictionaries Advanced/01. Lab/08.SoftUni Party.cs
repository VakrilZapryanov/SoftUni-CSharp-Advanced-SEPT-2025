HashSet<string> vip = new();
HashSet<string> regular = new();

bool hasParty = false;
string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "PARTY")
    {
        hasParty = true;
        break;
    }

    char firstChar = command[0];

    if (firstChar >= 48 && firstChar <= 57)
        vip.Add(command);
    else
        regular.Add(command);
}

while (hasParty && (command = Console.ReadLine()) != "END")
{
    char firstChar = command[0];

    if (firstChar >= 48 && firstChar <= 57)
        vip.Remove(command);
    else
        regular.Remove(command);
}

int remainingReservations = vip.Count + regular.Count;

Console.WriteLine(remainingReservations);

foreach (var vipReservation in vip)
    Console.WriteLine(vipReservation);

foreach (var regularReservation in regular)
    Console.WriteLine(regularReservation);
