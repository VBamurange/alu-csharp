using System;

/// <summary>
/// Represents the most basic form of an animal.
/// </summary>
public class Animal
{
    // Empty class
}

/// <summary>
/// Represents a dog, which is a derivative of an animal.
/// </summary>
public class Dog : Animal
{
    // Empty class
}

class Program
{
    static void Main()
    {
        // Creating instances of Animal and Dog
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();

        // Displaying the types of the created objects
        Console.WriteLine("Type of genericAnimal: " + genericAnimal.GetType().Name);
        Console.WriteLine("Type of myDog: " + myDog.GetType().Name);

        // Checking the relationship between Dog and Animal using IsAssignableFrom
        bool isDogDerivedFromAnimal = typeof(Animal).IsAssignableFrom(typeof(Dog));
        Console.WriteLine("Is Dog derived from Animal? " + isDogDerivedFromAnimal);

        // Checking the relationship between genericAnimal and Dog using IsInstanceOfType
        bool isGenericAnimalOfTypeDog = typeof(Dog).IsInstanceOfType(genericAnimal);
        Console.WriteLine("Is genericAnimal of type Dog? " + isGenericAnimalOfTypeDog);
    }
}

