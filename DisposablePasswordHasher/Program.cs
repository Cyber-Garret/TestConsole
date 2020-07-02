using Microsoft.AspNetCore.Identity;

using System;

namespace DisposablePasswordHasher
{
	class Program
	{
		private readonly static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

		static void Main(string[] args)
		{
			Console.WriteLine("Please type strong password and hit Enter.");
			var pass = Console.ReadLine();

			Console.WriteLine(passwordHasher.HashPassword(null, pass));
			Console.ReadKey();
		}
	}
}
