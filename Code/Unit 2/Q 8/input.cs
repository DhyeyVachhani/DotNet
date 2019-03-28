using System;
class MainClass
{
    public static void Main()
    {
        string name, country;
        Console.WriteLine("Please enter your name:");
        name = Console.ReadLine();
        Console.WriteLine("Please enter your country:");
        country = Console.ReadLine();
        Console.WriteLine("Hello {0} from country {1}", name, country);
    }
}