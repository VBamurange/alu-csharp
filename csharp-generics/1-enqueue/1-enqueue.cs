using System;
/// <summary>
/// class queue
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T> {
    /// <summary>
    /// public class Node
    /// </summary>
    public class Node {
        public T value {get; set; }
        public Node next { get; set;}

        public Node(T value) {
            this.value = value;
            this.next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public Queue()
    {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }
/// <summary>
/// enqueue method
/// </summary>
/// <param name="value"></param>
    public void Enqueue( T value)
    {
        Node newNode = new Node(value);

        if (tail != null) {
            tail.next = newNode;
        }  
        tail = newNode;
        
        if (tail != null)
        {
            tail = newNode;
        }  
        if (head == null) {
            head = newNode;
        }
        count++;
        
    }
    /// <summary>
    /// count method
    /// </summary>
    /// <returns></returns>
    public int Count() {
        return count;
    }
}