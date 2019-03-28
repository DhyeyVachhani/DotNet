using System;
class pattern 
{
    public static void Main()
    {
        int i, j;
        for (i = 5; i > 0; i--)
        {
            for (j = i; j > 0; j--)
            {
                Console.Write("@");
            }
            Console.WriteLine("\n");
        }
    }
}