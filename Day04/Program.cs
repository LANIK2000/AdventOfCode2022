
bool rangeOverlapComplete(ReadOnlySpan<int> values) {
	var res =
		Math.Sign(values[0] - values[2])
		+
		Math.Sign(values[1] - values[3]);
	
	return Math.Abs(res) < 2;
}

bool rangeOverlapPartial(ReadOnlySpan<int> values)
	=> values[1] >= values[2] && values[3] >= values[0];

var count_part_1 = 0;
var count_part_2 = 0;

string? line;
while ((line = Console.ReadLine()) != null) {
	var values = line
		.Split(new[]{',', '-'})
		.Select(x => int.Parse(x))
		.ToArray().AsSpan();
	
	if (rangeOverlapComplete(values))
		count_part_1++;
	
	if (rangeOverlapPartial(values))
		count_part_2++;
}

Console.WriteLine($"Part one: {count_part_1}");
Console.WriteLine($"Part two: {count_part_2}");
