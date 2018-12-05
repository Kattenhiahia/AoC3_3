using System;
using System.Text;

namespace Day5
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\GIT\AoC18\Day5\input.txt");
			Console.WriteLine($"{part1(input).Length}");
			
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static string part1(string input)
		{
			int i = 0;
			while (i < input.Length - 1)
			{
				string first = input[i].ToString();
				string second = input[i+1].ToString();
				if (first != second && first.Equals(second, StringComparison.InvariantCultureIgnoreCase))
				{
					input = input.Remove(i, 2);
					i--;
					i = Math.Max(i, 0);
				}
				else
				{
					i++;
				}
			}

			return input;
		}
	}
}
