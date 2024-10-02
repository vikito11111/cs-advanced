using _04._Car__engine_and_tires;

var car = new Car("Lamborghini", "Urus", 2010, 250, 9, new Engine(560, 6300), [
    new Tire(1, 2.5),
    new Tire(1, 2.1),
    new Tire(1, 0.5),
    new Tire(1, 2.3)
]);

car.PrintInfo();