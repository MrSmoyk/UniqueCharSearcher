using StringSpliter;

internal class Program
{
    private static void Main(string[] args)
    {
        StringSplit splitter = new StringSplit();

        var text = Console.ReadLine();
        var resp = splitter.UniqueChar(text);

        Console.WriteLine(resp);

        Console.ReadLine();
        
    }
}