using System;


/// <summary>
///public class queue
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>  {


/// <summary>
/// class Node
/// </summary>
    public class Node{

        public T? Value;
        public Node? Next;

        public Node(T value){
            Value = value;
            Next = null;
        }
    }

// node 1
    protected Node? head;
    // node 2
    protected Node? tail;
    // counts nodes
    int count;

// constructor 
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }


/// <summary>
/// enqueue method
/// </summary>
/// <param name="value"></param>
    public void Enqueue(T? value){

        Node newNode = new Node(value!);
    
        if(head == null){
            head = newNode;
            tail = newNode;
        }else{
            tail!.Next = newNode;
            tail = newNode;
        }
         count++;
    }

    
    

/// <summary>
/// checktype method
/// </summary>

    public Type CheckType(){
        return typeof(T);
    }

/// <summary>
/// count method
/// </summary>

    public int Count(){
        return count;
    }
    
}