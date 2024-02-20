using System;

/// <summary>
/// Represents a class with a method to check if an object is an array.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the specified object is an array.
    /// </summary>
    /// <param name="obj">The object to be checked.</param>
    /// <returns>True if the object is an array, otherwise false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj.GetType().IsArray;
    }

    /// <summary>
    /// Main method to demonstrate the usage of IsInstanceOfArray.
    /// </summary>
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        if (IsInstanceOfArray(array))
        {
            Console.WriteLine("a is an instance of type array or inherits from type array");
        }
        else
        {
            Console.WriteLine("a is not an instance of type array or does not inherit from type array");
        }
    }
}
