namespace MoreCSharpFun;

internal class PrintStuff
{
    private string language;
    
    //Constructor 
    public PrintStuff()
    {
        language = "EN";
    }
    public PrintStuff(string temp)
    {
        language = temp;
    }
    public void PrintName(string n)
    {
        if (language == "EN")
        {
            System.Console.WriteLine("Hello, " + n + "!");
        }

        if (language == "ES")
        {
            System.Console.WriteLine("Hola, " + n + "!");
        }
    }

}