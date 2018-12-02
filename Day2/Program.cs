using System;
using System.Linq;
using System.Collections.Generic;


namespace Day2
{
	class Program
	{
		static void Main(string[] args)
		{
			// The files used in this example are created in the topic
			// How to: Write to a Text File. You can change the path and
			// file name to substitute text files of your own.

			// Example #1
			// Read the file as one string.
			string input = System.IO.File.ReadAllText(@"C:\Users\samue\source\repos\AoC18_2\Day2\input.txt");
			part1(input);
			part2(input);
			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static void part1(string input)
		{
			int threes = 0;
			int twos = 0;
			var inp = input.Split('\n');
			bool foundTwo, foundThree;
			for (int i = 0; i < inp.Length; i++)
			{
				foundTwo = false;
				foundThree = false;

				for (int j = 0; j < inp[i].Length; j++)
				{
					int count = inp[i].Count(f => f == inp[i][j]);
					if (count == 3 && !foundThree)
					{
						foundThree = true;
						//Console.WriteLine("found the 3");
						threes++;
					}
					if (count == 2 && !foundTwo)
					{
						foundTwo = true;
						//Console.WriteLine("found the 2");
						twos++;
					}

				}
			}
			int r = twos * threes;
			Console.WriteLine($"this is result: {r}");
		}

		static void part2(string input)
		{
			var inp = input.Split('\n');
			int same = 0;
			string res ="";
			for (int n = 0; n < inp.Length; n++)
			{
				for (int i = n + 1; i < inp.Length; i++)
				{
					same = 0;
					res = "";
					for (int j = 0; j < inp[i].Length; j++)
					{
						if (inp[n][j] == inp[i][j])
						{
							same++;
							res += inp[n][j];
						}
					}
					if (same == inp[i].Length - 1)
					{
						Console.WriteLine($"this is the same ones: {res}");
						Console.WriteLine($"{inp[i]}");
						return;
					}
				}
			}
		}
	}
}
