using _01._Box_of_T;

var box = new Box<int>();

box.Add(1);
box.Add(2);
box.Add(3);

Console.WriteLine(box.Remove());

box.Add(4);
box.Add(5);

Console.WriteLine(box.Remove());

Console.WriteLine("--------------------------------");

var box2 = new Box<string>();

box2.Add("one");
box2.Add("two");
box2.Add("three");

Console.WriteLine(box2.Remove());