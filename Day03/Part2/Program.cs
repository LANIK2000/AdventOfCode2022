
int getPriority(char c) {
	if (c < 'a')
		return c - 'A' + 27;
	else
		return c - 'a' + 1;
}

int priorities_sum = 0;

string? line;

while ((line = Console.ReadLine()) != null) {
	var elf1 = line;
	var elf2 = Console.ReadLine() ?? throw new System.Exception("Unreachable Code");
	var elf3 = Console.ReadLine() ?? throw new System.Exception("Unreachable Code");
	
	foreach (var item in elf1.Intersect(elf2).Intersect(elf3))
		priorities_sum += getPriority(item);
}

Console.WriteLine($"Part two: {priorities_sum}");

