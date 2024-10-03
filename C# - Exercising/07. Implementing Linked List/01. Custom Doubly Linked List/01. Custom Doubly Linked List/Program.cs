//using _01._Custom_Doubly_Linked_List;
using _01._Custom_Doubly_Linked_List;

CustomLinkedList linkedList = new CustomLinkedList();

linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);

linkedList.ForEach(x =>
{
    Console.WriteLine($"ForEach is cool -> {x.Value}");
});

int[] array = linkedList.ToArray();

Console.WriteLine($"{string.Join(" ", array)}");

/*var ten = new Node(10);
var twenty = new Node(20);
var thirty = new Node(30);
var fourty = new Node(40);

Node head = new Node(10,
                new Node(20,
                    new Node(30,
                        new Node(40))));

Node currentNode = head;

ten.Next = twenty;
twenty.Previous = ten;

twenty.Next = thirty;
thirty.Previous = twenty;

thirty.Next = fourty;
fourty.Previous = thirty;

while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}*/