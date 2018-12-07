using System;
using System.Collections.Generic;

namespace day7
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\Users\samue\source\repos\AoC18_2\day7\test.txt");

			//string input = "dabAcCaCBAcCcaDA";

			Console.WriteLine($"input: {input.Length}");
			part1(input);
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static void part1(string input)
		{
			Dictionary<string, int> instructions = new Dictionary<string, int>();
			var inp = input.Split('\n');
			foreach (string row in inp)
			{
				Console.WriteLine($"first: {row[5]}, 2nd: {row[36]}");
				if (!instructions.ContainsKey(row[5].ToString()))
				{
					instructions.Add(row[5].ToString(), 0);
				}
				else if (!instructions.ContainsKey(row[36].ToString()))
				{
					instructions.Add(row[36].ToString(), 1);
				}
				else
				{
					instructions[row[36].ToString()] = instructions[row[36].ToString()] + 1;
				}
			}
			foreach (var v in instructions)
			{
				Console.WriteLine($"{v}");
			}
		}
	}
}
