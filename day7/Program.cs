using System;
using System.Collections.Generic;
using System.Linq;

namespace day7
{
	class node
	{
		public string tail { get; set; }
		public int indegree { get; set; }
		public node(string t, int indeg)
		{
			tail = t;
			indegree = indeg;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\GIT\AoC18\day7\input.txt");


			Console.WriteLine($"input: {input.Length}");
			part1(input);
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static void part1(string input)
		{
			Dictionary<string, node> instructions = new Dictionary<string, node>();
			var inp = input.Split('\n');
			foreach (string row in inp)
			{
				//Console.WriteLine($"first: {row[5]}, 2nd: {row[36]}");
				if (!instructions.ContainsKey(row[5].ToString()))
				{
					instructions.Add(row[5].ToString(), new node(row[36].ToString(), 0));
				}
				if (!instructions.ContainsKey(row[36].ToString()))
				{
					instructions.Add(row[36].ToString(), new node("", 1));
					if (!instructions[row[5].ToString()].tail.Contains(row[36].ToString()))
					{
						instructions[row[5].ToString()].tail = instructions[row[5].ToString()].tail + row[36].ToString();
					}
				}
				else
				{
					instructions[row[36].ToString()].indegree = instructions[row[36].ToString()].indegree + 1;
					if (!instructions[row[5].ToString()].tail.Contains(row[36].ToString()))
					{
						instructions[row[5].ToString()].tail = instructions[row[5].ToString()].tail + row[36].ToString();
					}
				}
			}
			int nodes = 0;
			foreach (var v in instructions)
			{
				Console.WriteLine($"{v.Key} : {v.Value.indegree},{v.Value.tail}");
				nodes++;
			}
			Console.WriteLine($"rows: {nodes}");

			int j = 0;
			string result = "";
			string exec = "";
			//string comp = "";
			while (j < nodes)
			{
				exec = "Z";
				foreach (var ins in instructions)
				{

					if (ins.Value.indegree == 0)
					{
						if (string.Compare(exec, ins.Key.ToString(), StringComparison.InvariantCulture) == 1)
						{
							exec = ins.Key.ToString();
						}
					}
				}
				instructions[exec].indegree= -1;
				foreach (char c in instructions[exec].tail)
				{
					instructions[c.ToString()].indegree -= 1;
				}

				result += exec; 

				j++;
			}
			Console.WriteLine($"result: {result}");
		}
	}
}
