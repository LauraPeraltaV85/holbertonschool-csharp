﻿using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current;
        current = myLList.First;
        while (current.Next != null)
        {
            if (current.Value < n)
            {
                current = current.Next;
            }
            else 
            {
                myLList.AddBefore(current, node);
                break;
            }
        }
        return node;
    }
}