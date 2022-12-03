
// Rock     A X >> 1
// Paper    B Y >> 2
// Scissors C Z >> 3
// Lookup key: 0 < 1 < 2 < 0

string? line;

int score = 0;

while ((line = Console.ReadLine()) != null) {
	int me = line[2] - 'X';
	int them = line[0] - 'A';
	
	score += 1 + me + (them - me) switch {
		-2 => 0,// -2 >> 02        LOSE
		-1 => 6,// -1 >> 12 01     WIN
		0  => 3,//  0 >> 00 11 22  DRAW
		1  => 0,//  1 >> 21 10     LOSE
		2  => 6,//  2 >> 20        WIN
		_  => throw new Exception("Unreachable Code")
	};
}

Console.WriteLine($"Part one: {score}");
