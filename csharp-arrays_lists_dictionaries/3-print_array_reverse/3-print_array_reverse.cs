﻿using System.Collections;

class array
{
    public static voif Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}