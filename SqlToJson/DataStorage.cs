using Newtonsoft.Json;

using System.IO;
using System.Text;

namespace SqlToJson
{
	internal static class DataStorage
	{
		internal static void SaveObject(object obj, string filePath, bool useIndentations)
		{
			var formatting = (useIndentations) ? Formatting.Indented : Formatting.None;

			string json = JsonConvert.SerializeObject(obj, formatting);
			File.WriteAllText(filePath, json, Encoding.UTF8);
		}
	}
}
