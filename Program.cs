namespace StringToolkit;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reverse (1) - Uppercase (2) - Lowercase (3)");
        input = Console.ReadLine();

        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        Console.WriteLine(reversed);
    }
}
