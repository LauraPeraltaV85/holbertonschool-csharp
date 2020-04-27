using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int i = 0;
        foreach (int index in myList)
        {
            i++;
        }
        return i;
    }
}