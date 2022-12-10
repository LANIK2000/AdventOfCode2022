using System;
using System.Linq;
using System.Collections.Generic;

// This program counts how many calories each elf carries
// and prints how much the top 1 carries and how much
// the top 3 carry.
class Program
{
	static void Main()
	{
		int total_calories = 0; // Total calories of a single elf
		List<int> all_elves = new();
		
		while (true)
		{
			string? line = Console.ReadLine()?.Trim();
			if (line == null)
			{
				break;
			}
			
			if (line == "") // Empty lines delimiter the elves
			{
				all_elves.Add(total_calories);
				total_calories = 0;
			}
			else
			{
				if (int.TryParse(line, out int calorie))
				{
					total_calories += calorie;
				}
				else
				{
					Console.Error.WriteLine($"Invalid calorie {{{line}}}");
				}
			}
		}
		
		if (all_elves.Count > 0)
		{
			var top_elves = all_elves
				.OrderByDescending(x=>x)
				.Take(3);
			
			Console.WriteLine($"The top elf carries {top_elves.First()}");
			Console.WriteLine($"The top 3 elves carry {top_elves.Sum()}");
		}
		else
		{
			Console.WriteLine("No elves were found.");
		}
	}
}
