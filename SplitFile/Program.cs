using System;
using System.IO;
using System.Linq;

namespace SplitFile
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Guardian!");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Please input file name:");
			Console.ResetColor();
			var fileName = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Now, please input number of rows for chunk:");
			Console.ResetColor();
			var chunksize = Convert.ToInt32(Console.ReadLine());

			Console.Title = $"File: {fileName} Chunk Size: {chunksize}";
			Console.ResetColor();

			string[] rows = File.ReadAllLines(fileName);

			var cycle = 1;

			var chunk = rows.Take(chunksize);
			var rem = rows.Skip(chunksize);

			while (chunk.Take(1).Count() > 0)
			{
				string filename = "file" + cycle.ToString() + ".txt";
				using (StreamWriter sw = new StreamWriter(filename))
				{
					foreach (string line in chunk)
					{
						sw.WriteLine(line);
					}
				}
				chunk = rem.Take(chunksize);
				rem = rem.Skip(chunksize);
				cycle++;
				Console.WriteLine($"{filename} ready!");
			}
		}
	}
}
