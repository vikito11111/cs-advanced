HashSet<string> carPark = new HashSet<string>();

string input;

while ((input = Console.ReadLine()) != "END")
{
    var tokens = input.Split(separator: new[] { ", " },options: StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string action = tokens[0];
    string carID = tokens[1];

    if (action == "IN")
    {
        carPark.Add(carID);
    }
    else if (action == "OUT")
    {
        carPark.Remove(carID);
    }
}

if (carPark.Count > 0)
{
    foreach (var car in carPark)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}