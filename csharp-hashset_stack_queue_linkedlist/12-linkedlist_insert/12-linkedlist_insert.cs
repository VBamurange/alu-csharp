using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n){
        LinkedListNode<int> theeNode = myLList.First;
        if (theeNode.Value >= n)
            return myLList.AddFirst(n);
        while (theeNode.Next != null){
            if (theeNode.Next.Value >= n){
                theeNode = myLList.AddAfter(theeNode, n);
                return theeNode;
            }
            theeNode = theeNode.Next;
        }
        theeNode = myLList.AddLast(n);
        return theeNode;
    }
}
