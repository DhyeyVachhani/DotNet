using System;

class calc
{
    public static int add(int a, int b)
    {
        return a+b;
    }
    public static float add(float a,  float b)
    {
        return a+b;
    }
    public static float add(int a, float b)
    {
        return a+b;
    }
}
class MainClass
{
    public static void Main()
    {
        int a=3, b=4, intResult;
        float c = 3.5f, d = 4.5f, floatResult;
        intResult = calc.add(a,b);
        Console.WriteLine("Addition of {0} and {1} is {2}", a, b, intResult);
        floatResult = calc.add(c,d);
        Console.WriteLine("Addition of {0} and {1} is {2}", c, d, floatResult);
        floatResult = calc.add(a,c);
        Console.WriteLine("Addition of {0} and {1} is {2}", a, c, floatResult);

    }
}