// See https://aka.ms/new-console-template for more information
using MoreCSharpFun;

internal class Program
{
    public static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff();
        
        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }
} 