using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace fileHandling
{
	class ListFile
	{
		public static void Main() {
			string[] Directories = Directory.GetDirectories(@"D:\SEM 6");
			foreach (string dir in Directories){
				Console.WriteLine(dir);
			}
			string[] files = Directory.GetFiles(@"D:\SEM 6");
			foreach (string file in files){ 
				Console.WriteLine(file);
			}
			Console.ReadKey();

		}
	}
}
