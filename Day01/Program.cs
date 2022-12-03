string? line;

int weight = 0;
List<int> elves = new();

while ((line = Console.ReadLine()) != null) {
	if (line == "") {
		elves.Add(weight);
		weight = 0;
	}
	else
		weight += int.Parse(line);
}

var top_elves = elves.OrderByDescending(x => x).ToArray();

Console.WriteLine($"Part one: {top_elves[0]}");
Console.WriteLine($"Part two: {top_elves[0] + top_elves[1] + top_elves[2]}");
