int IndexOfUniqueSequance(string line, int length) {
	string buffer = "";

	for (int i = 0; i < line.Length; i++) {
		char c = line[i];
		
		int found = buffer.IndexOf(c);
		if (found != -1)
			buffer = buffer.Substring(found + 1);
		
		buffer += c;
		if (buffer.Length == length)
			return i + 1;
	}
	return -1;
}

string line = Console.ReadLine()
	?? throw new ArgumentException("No line was given.");

Console.WriteLine($"Part one: {IndexOfUniqueSequance(line, 4)}");
Console.WriteLine($"Part two: {IndexOfUniqueSequance(line, 14)}");
