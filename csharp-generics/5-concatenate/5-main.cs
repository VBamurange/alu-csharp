class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        myStrQ.Enqueue("Hello");
        myStrQ.Enqueue("World");

        Console.WriteLine("Concatenated string: " + myStrQ.Concatenate());

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Enqueue(1);
        myIntQ.Enqueue(2);
        myIntQ.Enqueue(3);

        Console.WriteLine("Concatenated string: " + myIntQ.Concatenate());
    }
}