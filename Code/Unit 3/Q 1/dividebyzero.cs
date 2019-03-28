﻿using System;
class Program
{
    public static void division(int num1, int num2)
    {
        double result = 0;
        try
        {
            result = num1 / num2;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Catch: Exception Error !! \n divid by zero !!");
        }
        finally
        {
            Console.WriteLine("Finally: Result: {0} ", result);
        }
    }
    static void Main(string[] args)
    {
        division(10, 0);
        Console.ReadLine();
    }
}