class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("Hello");
        myStrQ.Enqueue("World");

        Console.WriteLine("Print queue:");
        myStrQ.Print();

        Console.WriteLine("Dequeue: " + myStrQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("Print queue:");
        myStrQ.Print();

        Console.WriteLine("Dequeue: " + myStrQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("Print queue:");
        myStrQ.Print();

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(3.8f);
        myFloatQ.Enqueue(2.4f);

        Console.WriteLine("Print queue:");
        myFloatQ.Print();

        Console.WriteLine("Dequeue: " + myFloatQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("Print queue:");
        myFloatQ.Print();

        myFloatQ.Enqueue(-9.8f);

        Console.WriteLine("Print queue:");
        myFloatQ.Print();
    }
}