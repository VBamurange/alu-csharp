using System;
/// <summary>
/// queue of type defined
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    public Type CheckType()
    {
        return typeof(T);
    }
}