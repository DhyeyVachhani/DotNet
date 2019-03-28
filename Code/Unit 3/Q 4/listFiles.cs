using System;
using System.IO;
class MyClass
{
    public static void Main()
    {
        string[] Directories = Directory.GetDirectories(@"C:\Users\crpatel\Desktop\Code\Unit 3\Q 3");
        foreach (string dir in Directories)
            Console.WriteLine(dir);
        string[] files = Directory.GetFiles(@"C:\Users\crpatel\Desktop\Code\Unit 3\Q 3");
        foreach (string file in files)
            Console.WriteLine(file);

    }
}