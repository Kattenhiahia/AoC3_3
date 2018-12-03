using System;

namespace Day3
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\GIT\AoC18\Day3\input.txt");
			part1(input);
			//part2(input);

			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}

		static void part1(string input)
		{
			bool[,] fabric = new bool[2048, 2048];
			var inp = input.Split('\n');
			string x = "", y = "", width = "", height = "";
			bool check = false;
			foreach (string s in inp)
			{
				check = false;
				for (int i = 0; i < s.Length; i++)
				{
					if (s[i]==' ' && s[i-1] == '@')
					{
						for (int j = i + 1; s[j]!=',';j++)
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
						for (int j = i + 1; j <s.Length; j++)
						{
							height += s[j];
						}
					}
				}
				Console.WriteLine($"x: {x}, y: {y}, width: {width}, height: {height}");
				x = "";
				y = "";
				width = "";
				height = "";
			}
			
		}

	}
}
