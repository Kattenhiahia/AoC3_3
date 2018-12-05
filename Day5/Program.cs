using System;
using System.Text;

namespace Day5
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\Users\samue\source\repos\AoC18_2\Day2\input.txt");
			part1(input);
			//part2(input);
			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static void part1(string input)
		{
			string s = input;
			while (true)
			{
				Console.WriteLine($"length: {s.Length}");
				for (int i = 0; i < (s.Length - 1); i++)
				{
					if (isOpposites(s[i], s[i + 1]))
					{
						// Sample: We want to remove 3 chars "cde"(index=2-4)
						// Don't forget to make sure the string is not empty or too short
						StringBuilder sb = new StringBuilder(input);
						sb.Remove(i, 2);
						s = sb.ToString();
					}
				}
				if (s.Length < 15)
				{
					Console.WriteLine($" this is polymer: {s}");
				}
			}
		}
		static Boolean isOpposites(char a, char b)
		{
			if (a == char.ToUpper(b) || a == char.ToLower(b))
			{
				return true;
				//ToLower, ToUpper
			}
			return false;
		}
	}
}
