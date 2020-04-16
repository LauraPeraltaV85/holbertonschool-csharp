using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0){
            Console.WriteLine("List is empty");
            return -1;
        }
        int i = 1;
        int maxVal = myList[0];
        while (i < myList.Count) {
            if (myList[i] > maxVal) {
                maxVal = myList[i];
            }
            i++;
        }
        return maxVal;
    } 
}
