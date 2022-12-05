using System.Text.RegularExpressions;

/* Init stacks */
var stacks = new LinkedList<char>[9];
for (int i = 0; i < 9; i++)
	stacks[i] = new();

string? line;

{/* Fill stacks */
	var regex = new Regex(@"\[\w\]");

	while ((line = Console.ReadLine()) != null && line[0] != ' ')
		foreach (Match match in regex.Matches(line))
			stacks[match.Index / 4].AddLast(match.ToString()[1]);
}

Console.ReadLine(); // Skip empty line

{/* Move crates around */
	var regex = new Regex(@"\d+");

	while ((line = Console.ReadLine()) != null) {
		var matches = regex.Matches(line);
		var amount  = int.Parse(matches[0].ToString());
		var from    = int.Parse(matches[1].ToString()) - 1;
		var to      = int.Parse(matches[2].ToString()) - 1;
		
		foreach (var crate in stacks[from].Take(amount).Reverse()) {
			stacks[to].AddFirst(crate);
			stacks[from].RemoveFirst();
		}
	}
}

Console.WriteLine($"Part two: {string.Join("", stacks.Select(x => x.First()))}");
