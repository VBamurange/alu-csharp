using System;
/// <summary>
/// abstract class Base
/// </summary>
public abstract class Base {
/// <summary>
/// name property
/// </summary>
    public string? name { get ; set; }
/// <summary>
/// ToString() method
/// </summary>
/// <returns></returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

/// <summary>
/// IInteractive interface
/// </summary>
public interface IInteractive {

/// <summary>
/// interact method
/// </summary>
    public void Interact();
}

/// <summary>
/// IBreakable interface
/// </summary>
public interface IBreakable {

/// <summary>
/// durability
/// </summary>
    public int durability { get ; set;}
/// <summary>
/// break method
/// </summary>
    public void Break();
}

/// <summary>
/// ICollectable interface
/// </summary>
public interface ICollectable{
/// <summary>
/// isCollected
/// </summary>
    public bool isCollected { get ; set; }

/// <summary>
/// collect method
/// </summary>
    public void Collect();

}

/// <summary>
/// class Door
/// </summary>
public class Door : Base , IInteractive{

/// <summary>
/// constructor that sets the value of name
/// </summary>
/// <param name="value"></param>
    public Door(string value = "Door"){
        name = value;
    }

/// <summary>
/// Interact() implementation
/// </summary>
    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}