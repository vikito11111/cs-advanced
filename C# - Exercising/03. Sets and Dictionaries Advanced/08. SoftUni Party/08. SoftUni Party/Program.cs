var vip = new HashSet<string>();
var regular = new HashSet<string>();

string guest;

while ((guest = Console.ReadLine()) != "PARTY")
{
    if (char.IsNumber(guest[0]))
    {
        vip.Add(guest);
    }
    else
    {
        regular.Add(guest);
    }
}

while ((guest = Console.ReadLine()) != "END")
{
    if (char.IsNumber(guest[0]))
    {
        vip.Remove(guest);
    }
    else
    {
        regular.Remove(guest);
    }
}

Console.WriteLine(vip.Count + regular.Count);

foreach (var vipGuest in vip)
{
    Console.WriteLine(vipGuest);
}

foreach (var regularGuest in regular)
{
    Console.WriteLine(regularGuest);
}