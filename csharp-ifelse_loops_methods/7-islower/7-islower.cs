using System;

class Character
{
    public static bool IsLower(char c)
    {
        // ASCII values of lowercase letters range from 97 ('a') to 122 ('z')
        int asciiValue = (int)c;
        
        // Check if the ASCII value falls within the range of lowercase letters
        return asciiValue >= 97 && asciiValue <= 122;
    }
}

class Program
{
    static void Main()
    {
        // Testing the IsLower method
        char testChar = 'b';
        bool isLower = Character.IsLower(testChar);

        Console.WriteLine($"Is '{testChar}' a lowercase letter? {isLower}");
    }
};