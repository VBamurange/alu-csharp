using System;

/// <summary>
/// Shape class is a base class for all shapes
/// </summary>
public class Shape
{
    /// <summary>
    /// Empty area calculation
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class Rectangle which inherits from Shape
/// </summary>
public class Rectangle : Shape
{
    // width of rectangle
    private int width;

    // height of rectangle
    private int height;

    /// <summary>
    /// Manages width
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Manages height
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }

            height = value;
        }
    }

    /// <summary>
    /// Calculates area of rectangle
    /// </summary>
    /// <returns> Area of rectangle</returns>
    public override int Area()
    {
        return height * width;
    }

    /// <summary>
    /// Local representation of the Rectangle in string format
    /// </summary>
    /// <returns>String</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Rectangle class
        Rectangle myRectangle = new Rectangle
        {
            Width = 5,
            Height = 10
        };

        // Calculating the area of the rectangle
        int rectangleArea = myRectangle.Area();
        Console.WriteLine($"Area of {myRectangle}: {rectangleArea}");
    }
}
