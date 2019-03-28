using System;
using System.Collections.Generic;
using System.Linq; using System.Text; using System.IO;

namespace fileHandling
{
	public class CopyFile
{
		public void copyFile(string f1, string f2)
	{
			using (StreamReader reader = new StreamReader(f1))
			using (StreamWriter writer = new StreamWriter(f2))
		{
			string line = null;
			while ((line = reader.ReadLine()) != null)
				writer.WriteLine(line);
		}
	}	
}
	public class run{
		public static void Main(){
		CopyFile cp = new CopyFile();
		string f1 = @"file1.txt";
		string f2 = @"file2.txt";
		cp.copyFile(f1,f2);

		}
	}
}
