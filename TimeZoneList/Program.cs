using System;
using System.Collections.ObjectModel;

namespace TimeZoneList
{
	class Program
	{
		static void Main(string[] args)
		{
			ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();
			Console.WriteLine("The local system has the following {0} time zones", zones.Count);
			foreach (TimeZoneInfo zone in zones)
				Console.WriteLine(zone.Id);

			Console.ReadKey();
		}
	}
}
