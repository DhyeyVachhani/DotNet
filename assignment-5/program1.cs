using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace fileHandling
{
class A5_1
{
public static void Main(){
string f1 = @"file1.txt";
string f2 = @"file2.txt";
using (StreamReader reader = new StreamReader(f1))
using (StreamWriter writer = new StreamWriter(f2))
writer.Write(reader.ReadToEnd());
}
}
}
