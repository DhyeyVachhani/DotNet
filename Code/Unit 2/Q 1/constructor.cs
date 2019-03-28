using System;
class ClassA
{
    public ClassA(out bool result)
    {
        result = false;
    }
}

class ClassB
{
    public static void Main()
    {
        bool result=true;
        Console.WriteLine("Result value is(Before Constructor):" + result);
        ClassA objA = new ClassA(out result);
        Console.WriteLine("Result value is(After Constructor):" + result);

    }
}