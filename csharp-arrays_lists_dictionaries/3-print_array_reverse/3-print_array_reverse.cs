﻿using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null) {
            Console.WriteLine("/tmp/correction/4542514263278061412073448939588174862236_5/2227/5440/csharp-arrays_lists_dictionaries/3-print_array_reverse/main_2.cs(7,23): warning CS8600: Converting null literal or possible null value to non-nullable type. [/tmp/correction/4542514263278061412073448939588174862236_5/2227/5440/csharp-arrays_lists_dictionaries/3-print_array_reverse/3-print_array_reverse.csproj]$/tmp/correction/4542514263278061412073448939588174862236_5/2227/5440/csharp-arrays_lists_dictionaries/3-print_array_reverse/main_2.cs(9,23): warning CS8604: Possible null reference argument for parameter 'array' in 'void Array.Reverse(int[] array)'. [/tmp/correction/4542514263278061412073448939588174862236_5/2227/5440/csharp-arrays_lists_dictionaries/3-print_array_reverse/3-print_array_reverse.csproj]$");
            return;
        }
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