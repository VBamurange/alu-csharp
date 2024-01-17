public class Character
{
    public static bool IsLower(char c)
    {
        return c >= 'a' && c <= 'z';
    }

    static void Main()
    {
        char testChar = 'g';
        bool result = IsLower(testChar);
        Console.WriteLine($"Is '{testChar}' lowercase? {result}");
    }
}
