using System;
class ClassA
{
    ~ClassA()
    {
        Console.WriteLine("Destructor ClassA");
    }
}
class ClassB:ClassA
{
    ~ClassB()
    {
        Console.WriteLine("Destructor ClassB");
    }

}
class ClassC:ClassB
{
    ~ClassC()
    {
        Console.WriteLine("Destructor ClassC");
    }

}

class MainClass
{
    public static void Main()
    {
        ClassC objC = new ClassC();
    }
}
