
class test
{
    static void Main()
    {
        string? str = null;
        // Using the null-coalescing operator to provide a default value
        string result = str ?? "Default Value";
        System.Console.WriteLine(result);
    }
}