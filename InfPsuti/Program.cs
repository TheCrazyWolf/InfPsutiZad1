using InfPsuti;

internal class Program
{
    private static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        Controller num = new Controller(180.5);

        Console.WriteLine(num.ToString());

    }
}