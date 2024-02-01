using System;
using System.Collections.Generic;

class LList{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n){
        if (myLList.Count == 0)
        {
            return myLList.AddFirst(n);
        }

        LinkedListNode<int> myNode = myLList.First!;

        if (myNode.Value >= n)
        {
            return myLList.AddFirst(n);
        }

        while (myNode.Next != null)
        {
            if (myNode.Next!.Value >= n)
            {
                return myLList.AddAfter(myNode, n);
            }
            myNode = myNode.Next;
        }

        return myLList.AddLast(n);
    }
}