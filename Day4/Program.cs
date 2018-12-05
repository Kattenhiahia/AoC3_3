using System;
using System.Collections.Generic;

namespace Day4
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\GIT\AoC18\Day4\input.txt");
			part1(input);
			//part2(input);

			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}

		static void part1(string input)
		{
			var inp = input.Split('\n');
			int testmonth = 0, testday = 0, testhour = 0,testminute = 0;
			int month = 0, day = 0, hour = 0, minute = 0;
			int ki = 0;
			for (int i = 0; i < inp.Length; i++)
			{
				ki = i;

				month = int.Parse(inp[i][6].ToString() + inp[i][7].ToString());
				day = int.Parse(inp[i][9].ToString() + inp[i][10].ToString());
				hour = int.Parse(inp[i][12].ToString() + inp[i][13].ToString());
				minute = int.Parse(inp[i][15].ToString() + inp[i][16].ToString());

				for (int j = i + 1; j < inp.Length; j++)
				{
					testmonth = int.Parse(inp[j][6].ToString() + inp[j][7].ToString());
					testday = int.Parse(inp[j][9].ToString() + inp[j][10].ToString());
					testhour = int.Parse(inp[j][12].ToString() + inp[j][13].ToString());
					testminute = int.Parse(inp[j][15].ToString() + inp[j][16].ToString());
					//ändra jämförelsen till Ki
					if (testmonth < month)
					{
						ki = j;
					}
					else if (testday < day)
					{
						ki = j;
					}
					else if (testhour < hour)
					{
						ki = j;
					}
					else if (testminute < minute)
					{
						ki = j;
					}
				}

				var temp = inp[ki];
				inp[ki] = inp[i];
				inp[i] = temp;
				Console.WriteLine($"{ki}");
			}
		}
	}
}
