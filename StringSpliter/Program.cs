using StringSpliter;

internal class Program
{
    private static void Main(string[] args)
    {
        StringSplit splitter = new StringSplit();

        var text = "C makes it easy for you to shoot yourself in the foot. C++ makes that harder, but when you do, it blows away your whole leg. (с) Bjarne Stroustrup";
        var resp = splitter.UniqueChar(text);

        Console.WriteLine(resp);

        Console.ReadLine();
        
    }
}