using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;
        List<int> newList = new List<int> ();
        if (size < 0) {
              Console.WriteLine("Size cannot be negative");
            return null;
        }
        else {
            for (i = 0; i < size; i++) {
                newList.Add(i);
                if (i < size - 1) {
                    Console.Write(newList[i] + " ");
                }
                else {
                    Console.WriteLine(newList[i]);
                }
            }
        }
        return newList;
    }
}