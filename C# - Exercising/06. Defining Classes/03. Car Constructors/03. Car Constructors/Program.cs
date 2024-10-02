using _03._Car_Constructors;

string make = Console.ReadLine();
string model = Console.ReadLine();
int year = int.Parse(Console.ReadLine());
double fuelQuantity = double.Parse(Console.ReadLine());
double fuelConsumption = double.Parse(Console.ReadLine());

var firstCar = new Car();

var secondCar = new Car(make, model, year);

var thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);