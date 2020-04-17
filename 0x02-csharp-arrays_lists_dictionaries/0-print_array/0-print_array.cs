using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int i;
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] length = new int[size];
         if (size == 0) {
            Console.WriteLine();
            return length; 
        }
        for (i = 0; i < size; i++) {
            length[i] = i;
            if (i < size - 1) {
                Console.Write(length[i] + " ");
            }
            else {
                Console.WriteLine(length[i]);
            }
        }
        return length;
    }
}

