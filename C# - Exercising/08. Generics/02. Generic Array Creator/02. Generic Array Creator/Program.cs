using _02._Generic_Array_Creator;

var array = ArrayCreator.Create(5, "Pesho");

foreach (var item in array)
{
    Console.WriteLine(item);
}