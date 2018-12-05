using System;

namespace Day3
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\GIT\AoC18\Day3\input.txt");
			//part1(input);
			part2(input);

			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}

		static void part1(string input)
		{
			int[,] fabric = new int[1000, 1000];
			var inp = input.Split('\n');
			string x = "", y = "", width = "", height = "";
			foreach (string s in inp)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if (s[i] == ' ' && s[i - 1] == '@')
					{
						for (int j = i + 1; s[j] != ','; j++)
						{
							x += s[j];
						}
					}
					if (s[i] == ',')
					{
						for (int j = i + 1; s[j] != ':'; j++)
						{
							y += s[j];
						}
					}
					if (s[i] == ' ' && s[i - 1] == ':')
					{
						for (int j = i + 1; s[j] != 'x'; j++)
						{
							width += s[j];
						}
					}
					if (s[i] == 'x')
					{
						for (int j = i + 1; j < s.Length; j++)
						{
							height += s[j];
						}
					}
				}
				for (int nx = int.Parse(x); nx < int.Parse(width) + int.Parse(x); nx++)
				{
					for (int ny = int.Parse(y); ny < int.Parse(height) + int.Parse(y); ny++)
					{
						fabric[nx, ny] = fabric[nx, ny] + 1;
					}
				}
				x = "";
				y = "";
				width = "";
				height = "";
			}

			int sum = 0;
			for (int resx = 0; resx < 1000; resx++)
			{
				for (int resy = 0; resy < 1000; resy++)
				{
					if (fabric[resx, resy] > 1)
					{
						sum++;
					}
				}
			}
			Console.WriteLine($" so many inches are claimed more than once: {sum} ");
		}

		static void part2(string input)
		{
			int[,] fabric = new int[1000, 1000];
			var inp = input.Split('\n');
			string x = "", y = "", width = "", height = "";
			int row = 1;
			int counter = 0;

			foreach (string s in inp)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if (s[i] == ' ' && s[i - 1] == '@')
					{
						for (int j = i + 1; s[j] != ','; j++)
						{
							x += s[j];
						}
					}
					if (s[i] == ',')
					{
						for (int j = i + 1; s[j] != ':'; j++)
						{
							y += s[j];
						}
					}
					if (s[i] == ' ' && s[i - 1] == ':')
					{
						for (int j = i + 1; s[j] != 'x'; j++)
						{
							width += s[j];
						}
					}
					if (s[i] == 'x')
					{
						for (int j = i + 1; j < s.Length; j++)
						{
							height += s[j];
						}
					}
				}
				for (int nx = int.Parse(x); nx < int.Parse(width) + int.Parse(x); nx++)
				{
					for (int ny = int.Parse(y); ny < int.Parse(height) + int.Parse(y); ny++)
					{
						fabric[nx, ny] = fabric[nx, ny] + 1;
					}
				}
				x = "";
				y = "";
				width = "";
				height = "";
			}


			foreach (string s in inp)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if (s[i] == ' ' && s[i - 1] == '@')
					{
						for (int j = i + 1; s[j] != ','; j++)
						{
							x += s[j];
						}
					}
					if (s[i] == ',')
					{
						for (int j = i + 1; s[j] != ':'; j++)
						{
							y += s[j];
						}
					}
					if (s[i] == ' ' && s[i - 1] == ':')
					{
						for (int j = i + 1; s[j] != 'x'; j++)
						{
							width += s[j];
						}
					}
					if (s[i] == 'x')
					{
						for (int j = i + 1; j < s.Length; j++)
						{
							height += s[j];
						}
					}
				}

				Console.WriteLine($"x: {x}, y: {y}, width: {width}, height: {height}");

				for (int nx = int.Parse(x); nx < int.Parse(width) + int.Parse(x); nx++)
				{
					for (int ny = int.Parse(y); ny < int.Parse(height) + int.Parse(y); ny++)
					{
						counter += fabric[nx, ny];
					}
				}

				if (int.Parse(width) * int.Parse(height) == counter)
				{
					Console.WriteLine($" row and maybe id: {row}");
					return;
				}
				x = "";
				y = "";
				width = "";
				height = "";
				row++;
				counter = 0;
			}
		}
	}
}
