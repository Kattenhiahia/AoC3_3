﻿using System;
using System.Collections.Generic;

namespace Day1
{
	class Program
	{
		static void Main(string[] args)
		{
			string inp = "-16\n+12\n-6\n-16\n+4\n+19\n-10\n+20\n-16\n-6\n+3\n-12\n-7\n+6\n-12\n-7\n-15\n-2\n+11\n+5\n+5\n-9\n-14\n-3\n-4\n+16\n+11\n+7\n+17\n-4\n+17\n+1\n-9\n-6\n-14\n-8\n+3\n-13\n+14\n-8\n-5\n+16\n+18\n-4\n+10\n+16\n-4\n+9\n+14\n+8\n-19\n-11\n+19\n-13\n+8\n-4\n-6\n-7\n+4\n+6\n+6\n+7\n+6\n-3\n+10\n+13\n-19\n+5\n+8\n+16\n+3\n+11\n+7\n+2\n+8\n+5\n-8\n+10\n+6\n-2\n-16\n-9\n-1\n-11\n-12\n-8\n+17\n-16\n-5\n+16\n-9\n+13\n+3\n+6\n-16\n+4\n-6\n-19\n+5\n-6\n+7\n+8\n+20\n-1\n+6\n-3\n+16\n-17\n+10\n+1\n+20\n-15\n+13\n+10\n+15\n-9\n+6\n+11\n+14\n+8\n-3\n+5\n-14\n+2\n-14\n-19\n+1\n-5\n+1\n+18\n+1\n-13\n+11\n+10\n-19\n-13\n+7\n-16\n-5\n+13\n+16\n+18\n-2\n+6\n-11\n+9\n+11\n+6\n-7\n-17\n-18\n+6\n+3\n+19\n+20\n+4\n+15\n+11\n-13\n+12\n-7\n+10\n-5\n-14\n-16\n+11\n+10\n+2\n+13\n+7\n+9\n-18\n-5\n-17\n+14\n+16\n-3\n+9\n+6\n-17\n+16\n+6\n+14\n+12\n+11\n+7\n+17\n+11\n-15\n+8\n+17\n+17\n+2\n-15\n-16\n+15\n+15\n-2\n+16\n-10\n+2\n+5\n-16\n+8\n-19\n+5\n-2\n+7\n-16\n+10\n-9\n-11\n+13\n+11\n+4\n-3\n+15\n-1\n+10\n+18\n-4\n-1\n-12\n+6\n+15\n-3\n-17\n+3\n+21\n+2\n-18\n-15\n-21\n-16\n+5\n-20\n+7\n-5\n-16\n+18\n-19\n+14\n+10\n-19\n-15\n-14\n+13\n-15\n+6\n-13\n+17\n+4\n+15\n-7\n-13\n+21\n+17\n-8\n-4\n+9\n-11\n+4\n-1\n-15\n-20\n-14\n-9\n-11\n-17\n-11\n-12\n-4\n+3\n-10\n-13\n+18\n-14\n+10\n+18\n+6\n-13\n+9\n-1\n-4\n+8\n+6\n+25\n-11\n-11\n+19\n+15\n+15\n-2\n-16\n+11\n+8\n-13\n-4\n-5\n+2\n+5\n+20\n-14\n-18\n+17\n-4\n+12\n+8\n-11\n+17\n+13\n+8\n-19\n-1\n+11\n+29\n+5\n+26\n+14\n-1\n+10\n-16\n+11\n+12\n-4\n-15\n-16\n+32\n-8\n+5\n+12\n-4\n+21\n-7\n-7\n-31\n-5\n-15\n-16\n+9\n-36\n-11\n-25\n+16\n+12\n+14\n-72\n+7\n+4\n+15\n+15\n+16\n+39\n+73\n+20\n-14\n+6\n+13\n-2\n+1\n-28\n+75\n-14\n+15\n+8\n-10\n-3\n-16\n-6\n-19\n-5\n-24\n-24\n+106\n+14\n-2\n+19\n-8\n-16\n-13\n+33\n+20\n-2\n-2\n+24\n-2\n-11\n+8\n+4\n+9\n+32\n-9\n+19\n-2\n-22\n-6\n+50\n-17\n+10\n+6\n+23\n+10\n+3\n+88\n+112\n+11\n+18\n+12\n+55\n+9\n+29\n+13\n-88\n+6\n+423\n+55676\n+1\n-8\n-16\n-16\n+19\n+7\n-5\n+4\n-3\n-16\n+9\n+3\n-7\n-10\n-8\n-3\n-4\n+8\n-7\n-15\n+2\n-1\n+8\n+3\n+4\n-3\n+13\n-19\n-15\n-11\n+10\n+3\n-9\n-19\n-1\n-4\n+19\n+13\n-10\n+14\n+9\n+14\n+15\n-8\n-24\n-15\n+11\n-1\n-16\n-15\n-4\n-18\n-5\n+10\n-8\n-3\n+2\n+13\n+14\n+7\n+12\n-9\n+17\n-9\n-9\n-21\n+6\n+17\n-24\n-6\n+10\n+13\n-20\n-15\n-14\n-11\n-3\n-8\n-1\n+15\n+9\n-17\n-18\n+4\n+6\n-11\n-19\n-7\n+18\n-4\n-12\n-5\n-18\n-3\n+10\n-4\n-10\n-11\n+6\n+11\n+6\n+8\n+12\n+8\n-1\n+19\n+14\n-1\n-3\n+19\n-5\n+15\n+3\n+1\n+22\n-19\n-8\n-2\n-9\n+13\n+1\n-7\n+18\n+16\n+4\n+6\n+19\n-18\n+2\n+3\n+34\n-14\n+8\n+7\n+12\n+9\n-15\n+24\n+7\n+11\n-4\n-13\n+16\n+7\n-13\n-15\n-12\n+20\n+21\n-4\n+21\n+19\n+19\n+10\n-7\n-9\n+11\n-6\n+5\n+5\n-13\n-17\n+8\n+4\n-13\n-8\n+14\n+11\n+7\n-9\n-17\n-3\n-5\n-16\n+9\n-2\n-8\n-3\n+10\n+16\n+18\n+5\n+15\n+14\n+2\n+15\n-8\n+1\n+15\n+11\n+18\n-5\n+3\n-13\n-9\n-19\n+15\n-7\n-14\n-18\n+12\n-1\n+16\n-8\n+9\n+16\n+20\n-16\n+11\n+1\n+14\n-16\n-4\n+3\n+14\n+10\n+12\n-16\n-4\n+14\n-19\n-12\n-20\n+17\n-16\n-6\n+15\n-20\n-16\n-17\n+10\n+13\n-14\n+18\n-6\n+3\n-10\n-3\n+4\n+13\n-16\n-7\n+31\n+11\n+1\n+1\n+13\n-5\n-5\n+21\n+18\n+20\n-9\n-3\n-9\n-11\n+8\n-1\n-4\n+14\n+14\n-15\n-6\n+14\n+1\n+2\n+14\n+21\n+8\n-15\n+20\n-10\n-20\n-5\n-10\n-17\n-15\n+16\n-8\n+16\n+15\n+12\n+11\n-3\n+21\n-17\n+6\n-15\n+1\n-19\n+8\n+21\n-16\n-19\n+8\n+7\n-8\n+3\n-20\n-39\n-18\n+14\n-12\n-29\n+3\n-14\n-10\n-9\n-3\n-22\n-8\n+1\n+3\n-5\n-1\n-19\n-25\n+9\n-7\n-14\n+19\n+19\n-27\n-6\n+27\n+10\n+29\n+19\n-23\n+17\n-10\n+5\n+13\n-15\n-25\n+13\n+3\n+14\n-37\n+6\n+18\n+18\n+89\n+57\n-17\n+39\n-2\n+27\n+13\n-18\n-17\n+9\n+1\n+14\n-4\n+10\n-19\n+18\n+7\n+13\n+8\n+7\n+11\n-7\n-9\n-3\n-4\n+9\n+24\n-3\n-16\n-23\n+7\n-16\n-1\n-15\n-12\n+19\n-2\n+14\n-21\n-2\n-12\n-14\n-62\n+22\n+7\n+66\n+26\n-21\n+61\n+5\n-6\n+11\n-7\n+18\n+67\n+38\n+18\n+30\n-18\n-120\n+24\n-18\n-16\n+31\n-102\n+11\n+149\n+96\n+9\n-40\n+69\n+13\n+757\n+55505\n+6\n+11\n+13\n-16\n+14\n-13\n-2\n-14\n-19\n+18\n-14\n-18\n+1\n+11\n+19\n-6\n-2\n-13\n+3\n-14\n-2\n+6\n+4\n+4\n-18\n+16\n-13\n-16\n+8\n+10\n-9\n+1\n-19\n+14\n-15\n-10\n+8\n-10\n-18\n-3\n-7\n+3\n+2\n+10\n-18\n-2\n-18\n+17\n-13\n-9\n+16\n-3\n-19\n-7\n-6\n-10\n+6\n-12\n+17\n-18\n+11\n+5\n-2\n-4\n-15\n-2\n-19\n-9\n+15\n-4\n-17\n+16\n+17\n+13\n-7\n-9\n+10\n-5\n-11\n+4\n-16\n-19\n-13\n-8\n-8\n+18\n-6\n+19\n+2\n+16\n-11\n+18\n+3\n-14\n+2\n+7\n+19\n-8\n+24\n-9\n+17\n+9\n+10\n-8\n-4\n-8\n+24\n+19\n-6\n+4\n+13\n+4\n+18\n-8\n+12\n-17\n-17\n-2\n-17\n-11\n-2\n+5\n-6\n+2\n+8\n-5\n-16\n-17\n+5\n-1\n-6\n-12\n-9\n-14\n-17\n+5\n-2\n-17\n-11\n+9\n-12\n+4\n-8\n+2\n+9\n+18\n+19\n+20\n-23\n-5\n+6\n+21\n+12\n+28\n+23\n-4\n+10\n+16\n+15\n+6\n+9\n-10\n-1\n+18\n-21\n-10\n+20\n-15\n-9\n+21\n+5\n-15\n-15\n+12\n+29\n-12\n+21\n-2\n-8\n+4\n+5\n-11\n+19\n-14\n-113326";
			part1(inp);
			part2(inp);
			Console.ReadKey();

		}
		static void part1(string input)
		{
			int sum = 0;
			var inp = input.Split('\n');
			foreach (string s in inp)
			{
				sum += int.Parse(s);
			}
			Console.WriteLine($"this is sum {sum}");
		}
		static void part2(string input)
		{
			var sums = new HashSet<int>();
			int sum = 0;
			var inp = input.Split('\n');
			while (true)
			{

				foreach (string s in inp)
				{
					sum += int.Parse(s);
					if (sums.Contains(sum))
					{
						Console.WriteLine($"FREQUENCY: {sum}");
						return;
					}
					sums.Add(sum);
				}
			}
		}

	}
}
