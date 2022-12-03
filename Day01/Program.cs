
int weight = 0;
List<int> elves = new();

string? line;
while ((line = Console.ReadLine()) != null) {
	if (line == "") {
		elves.Add(weight);
		weight = 0;
	}
	else
		weight += int.Parse(line);
}

var top_elves = elves.OrderByDescending(x=>x).Take(3);

Console.WriteLine($"Part one: {top_elves.First()}");
Console.WriteLine($"Part two: {top_elves.Sum()}");
