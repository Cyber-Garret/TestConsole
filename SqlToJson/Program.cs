using System;
using System.IO;

namespace SqlToJson
{
	class Program
	{
		private static readonly string CatalystFolder;
		private static readonly string ExoticFolder;
		static Program()
		{
			CatalystFolder = Path.Combine(Directory.GetCurrentDirectory(), "catalysts");
			ExoticFolder = Path.Combine(Directory.GetCurrentDirectory(), "exotics");

			if (!Directory.Exists(CatalystFolder))
				Directory.CreateDirectory(CatalystFolder);

			if (!Directory.Exists(ExoticFolder))
				Directory.CreateDirectory(ExoticFolder);
		}
		static void Main(string[] args)
		{
			try
			{
				var data = new DataRepo("Server=IP;Database=DBNAME;User Id=LOGIN;Password=PASSWORD;MultipleActiveResultSets=true;");

				var exo = data.GetExotics();
				foreach (var item in exo)
					DataStorage.SaveObject(item, Path.Combine(ExoticFolder, $"{item.Name.Replace("\"", "")}.json"), true);

				var cat = data.GetCatalysts();
				foreach (var item in cat)
					DataStorage.SaveObject(item, Path.Combine(CatalystFolder, $"{item.WeaponName}.json"), true);

				Console.WriteLine("Done save Catalysts and Exotics");
				Console.ReadKey();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				Console.ReadKey();
			}
		}
	}
}
