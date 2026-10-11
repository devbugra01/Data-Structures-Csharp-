class Node
{
    public int data;
    public Node? next;
}

class Program
{
    static void Main(string[] args)
    {
        Node first = new Node();
        Node second = new Node();
        Node third = new Node();
        first.data = 10;
        second.data = 20;
        third.data = 30;
        first.next = second;
        second.next = third;

        Console.WriteLine($"{first.next.next.data}");
    }
}