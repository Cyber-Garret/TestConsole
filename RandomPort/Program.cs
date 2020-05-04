using System;

namespace RandomPort
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();
			int rInt = rand.Next(49152, 65535);

			Console.WriteLine($"Random dynamic port in range 49152-65535 is: {rInt}");
			Console.ReadKey();
		}
	}
}
