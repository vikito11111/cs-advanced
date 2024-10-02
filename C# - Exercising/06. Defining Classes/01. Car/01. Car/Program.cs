var car = new Car("Toyota", "Camry", 2020);

car.DisplayInfo();

public class Car
{
    // Private fields:
    private string make;
    private string model;
    private int year;

    // Public properties with full get and set methods:
    public string Make
    {
        get => make;
        set => make = value;
    }

    public string Model
    {
        get => model;
        set => model = value;
    }

    public int Year
    {
        get => year;
        set => year = value;
    }

    // Constructor:
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Methods:
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
}