using Microsoft.AspNetCore.Identity;

using System;

namespace DisposablePasswordHasher
{
	class Program
	{
		static void Main(string[] args)
		{
			var passwordHasher = new PasswordHasher<string>();
			Console.WriteLine(passwordHasher.HashPassword(null, "strong password"));
			Console.ReadLine();
		}
	}
}
