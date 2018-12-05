using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\GIT\AoC18\Day5\input.txt").Trim();
			//string input = "dabAcCaCBAcCcaDA";

			Console.WriteLine($"input: {input.Length}");
			part2(input);
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static string part1(string input)
		{
			int i = 0;
			while (i < input.Length - 1)
			{
				string first = input[i].ToString();
				string second = input[i + 1].ToString();
				if (first != second && first.Equals(second, StringComparison.InvariantCultureIgnoreCase))
				{
					input = input.Remove(i, 2);
					--i;
					i = Math.Max(i, 0);
				}
				else
				{
					++i;
				}
			}
			return input;
		}
		static void part2(string input)
		{
			var l = new HashSet<string>();
			var reactlist = new HashSet<string>();
			string remov = "";
			int j = 0;
			for (int i = 0; i < input.Length; i++)
			{
				remov = input[i].ToString().ToLower();
				if (!l.Contains(remov))
				{
					l.Add(remov);
					string res = input;
					j = 0;
					while (j < res.Length)
					{
						if (res[j].ToString().ToLower() == remov)
						{
							res = res.Remove(j, 1);

						}
						else
						{
							j++;
						}
					}

					reactlist.Add(res);
					Console.WriteLine($" char removed: {input[i].ToString().ToLower()}, result length: {res.Length}");
				}
			}

			foreach (var v in reactlist)
			{
				Console.WriteLine(part1(v).Length);
			}
		}
	}
}
