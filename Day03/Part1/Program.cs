
int getPriority(char c) {
	if (c < 'a')
		return c - 'A' + 27;
	else
		return c - 'a' + 1;
}

int priorities_sum = 0;

string? line;
while ((line = Console.ReadLine()) != null) {
	var half_point = line.Length / 2;
	var pocket_1 = line.Substring(0, half_point);
	var pocket_2 = line.Substring(half_point);
	
	foreach (var item in pocket_1.Intersect(pocket_2))
		priorities_sum += getPriority(item);
}

Console.WriteLine($"Part one: {priorities_sum}");
