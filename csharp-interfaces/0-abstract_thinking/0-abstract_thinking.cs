using System;
/// <summary>
/// abstract class Base
/// </summary>
public abstract class Base {
/// <summary>
/// name property
/// </summary>
    public string? name;
/// <summary>
/// ToString() method
/// </summary>
/// <returns></returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}
