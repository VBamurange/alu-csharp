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
/// testObject class that inherits from base
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable {

/// <summary>
/// durability implementation
/// </summary>
    public int durability { get; set; }

/// <summary>
/// isCollected implementation
/// </summary>
    public bool isCollected { get; set; }

/// <summary>
/// interact method
/// </summary>
    public void Interact() {

    }

/// <summary>
/// break method
/// </summary>
    public void Break() {

    }

/// <summary>
/// collect method
/// </summary>
    public void Collect() {

    }
}
