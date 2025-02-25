using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace NixUloha2
{
	class Program
	{
		static async Task Main()
		{
			string[] hodneURLadres = { "https://thisisnotavirus.com/", "https://hackertyper.com/", "https://time.is/" };
			Task<string> task1 = NestahniDataAsync(hodneURLadres[0]);
			Task<string> task2 = NestahniDataAsync(hodneURLadres[1]);
			Task<string> task3 = NestahniDataAsync(hodneURLadres[2]);
			string[] obsah = await Task.WhenAll(task1, task2, task3);
			Console.WriteLine("yay");
			Console.ReadLine();
		}
		static async Task<string> NestahniDataAsync(string url)
		{
			Console.WriteLine($"Task for url = '{url}' is running.");
			using HttpClient client = new HttpClient();
			try
			{
				string data = await client.GetStringAsync(url);
				return data;
				Console.WriteLine($"Task for url = '{url}' is done.");
			}
			catch (Exception ex) {
				Console.WriteLine($"stranka {url} nechtela dat data :(");
				string data = ex.Message;
				return data;
			}

		}
	}
}
