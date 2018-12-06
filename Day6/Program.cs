using System;

namespace Day6
{
	class Program
	{
		public class place
		{
			public int closest { get; set; }
			public int length { get; set; }

			public place()
			{
				length = 9999;
			}
		}
		static void Main(string[] args)
		{
			string input = System.IO.File.ReadAllText(@"C:\Users\samue\source\repos\AoC18_2\Day6\input.txt");
			string input2 = "1, 1\n1, 6\n8, 3\n3, 4\n5, 5\n8, 9";

			Console.WriteLine($"input: {input2.Length}");
			part1(input2);
			//part2(input);
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
		static void part1(string input)
		{
			var inp = input.Split('\n');
			place[,] map = new place[10, 10];
			for (int yasd = 0; yasd < 10; yasd++)
			{
				for (int xasd = 0; xasd < 10; xasd++)
				{
					map[xasd,yasd] = new place();
				}
			}
			bool x = true;
			string cx = "", cy = "";
			int rowcounter = 1;
			foreach (string cord in inp)
			{
				for (int i = 0; i < cord.Length; i++)
				{
					if (cord[i] != ',' && x)
					{
						cx += cord[i];
					}
					if (cord[i] == ',')
					{
						x = false;
					}
					if (cord[i] != ',' && !x)
					{
						cy += cord[i];
					}
				}

				Console.WriteLine($"x:{int.Parse(cx)}  y:{int.Parse(cy)}");
				map[int.Parse(cx), int.Parse(cy)].closest = rowcounter;
				rowcounter++;
				x = true;
				cx = "";
				cy = "";
			}
			for (int yi = 0; yi < 10; yi++)
			{
				for (int xi = 0; xi < 10; xi++)
				{
					map[xi, yi] = findClosest(xi, yi, map);
					//Console.Write($" {map[xi, yi].closest}");
					Console.WriteLine("");
				}
				//Console.WriteLine("");
			}

			for (int yi = 0; yi < 10; yi++)
			{
				for (int xi = 0; xi < 10; xi++)
				{
					Console.Write($" {map[xi, yi].length}");
				}
				Console.WriteLine("");
			}
		}
		static place findClosest(int x, int y, place[,] map)
		{

			place result = new place();

			for (int yi = 0; yi < 10; yi++)
			{
				for (int xi = 0; xi < 10; xi++)
				{
					if (map[xi, yi].closest != 0)
					{
						if (map[xi, yi].length > (Math.Abs(x - xi) + Math.Abs(y - yi)))
						{
							result.closest = map[xi, xi].closest;
							result.length = Math.Abs(x - xi) + Math.Abs(y - yi);
						}
						//if (result.length == (Math.Abs(x - xi) + Math.Abs(y - yi)))
						//{
						//	result.closest = 0;
						//	result.length = Math.Abs(x - xi) + Math.Abs(y - yi);
						//}
						Console.Write($" {(Math.Abs(x - xi) + Math.Abs(y - yi))}");
					}
					else
					{
						Console.Write($" x");
					}
				}
				Console.WriteLine("");
			}
			return result;
		}
	}
}
