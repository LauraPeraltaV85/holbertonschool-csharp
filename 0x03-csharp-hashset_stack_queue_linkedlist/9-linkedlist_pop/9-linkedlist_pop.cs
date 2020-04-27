using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> head = new LinkedListNode<int>(myLList.First.Value);
        if (myLList.Count == 0)
        {
            return 0;
        }
        else 
        {
           myLList.RemoveFirst();
           return head.Value; 
        }
    }
}