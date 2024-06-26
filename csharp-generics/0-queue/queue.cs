using System;

/// <summary>
/// public class queue
/// </summary>
public class Queue<T>
{   
    /// <summary>
    /// The CheckType method
    /// </summary>

    public Type CheckType()
    {
        return typeof(T);
    }
}