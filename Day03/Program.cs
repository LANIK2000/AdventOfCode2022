
int getPriority(char c) {
	if (c < 'a')
		return c - 'A' + 27;
	else
		return c - 'a' + 1;
}

int priorities_sum = 0;

string? line;

string compartment_1;
string compartment_2;

while ((line = Console.ReadLine()) != null) {
	int half_point = line.Length / 2;
	compartment_1 = line.Substring(0, half_point);
	compartment_2 = line.Substring(half_point);
	
	var common_items = compartment_1.Intersect(compartment_2);
	foreach (var item in common_items)
		priorities_sum += getPriority(item);
}

Console.WriteLine($"Part one: {priorities_sum}");
