using System;

using System.Threading.Tasks;

class Program

{

	static async Task Main(string[] args)

	{

		Console.WriteLine("Začínám načítat data...");



		var progressTask = Task.Run(async () =>

		{

			for (int i = 1; i <= 100; i++)

			{

				await Task.Delay(1000); 

				Console.Clear(); 

				Console.WriteLine($"Načítání... {i}%"); 

			}

		});


		string result = await FetchDataAsync();



		Console.WriteLine(result);



		await progressTask;

	}

	public static async Task<string> FetchDataAsync()

	{

int i = 0;
		while (i < 500)
		{
			await Task.Delay(50);
			Console.WriteLine("Data byla úspěšně načtena, protože jsi sigma!");
			i++;
		}
		int x = 0;
		while (x < 3000)
		{
			await Task.Delay(5);
			Console.WriteLine("Data byla úspěšně načtena, protože jsi největší sigma!!!!!");
			x++;
		}
		int y = 0;
		while (y < 50000)
		{
		
			Console.WriteLine("skibidihotovo!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
			y++;
		}
		return "hotovo";
	}

}

