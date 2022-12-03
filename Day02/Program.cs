
// Rock     A X >> 1
// Paper    B Y >> 2
// Scissors C Z >> 3
// Lookup key: 0 < 1 < 2 < 0

int toScore(int them, int me)
	=> 1 + me + (them - me) switch {
			-2 => 0,// -2 >> 02        LOSE
			-1 => 6,// -1 >> 12 01     WIN
			0  => 3,//  0 >> 00 11 22  DRAW
			1  => 0,//  1 >> 21 10     LOSE
			2  => 6,//  2 >> 20        WIN
			_  => throw new Exception("Unreachable Code")
		};

string? line;

int score_part_1 = 0;
int score_part_2 = 0;

while ((line = Console.ReadLine()) != null) {
	int me = line[2] - 'X';
	int them = line[0] - 'A';
	
	{/* -~={ Part 1 }=~-*/
		score_part_1 += toScore(them, me);
	}
	
	{/* -~={ Part 2 }=~-*/
		int strategy = them + me switch {
			0 => -1, // LOSE
			1 =>  0, // DRAW
			2 =>  1, // WIN
			_ => throw new Exception("Unreachable Code")
		};
		
		me = strategy switch { // Handle overflows
			-1 => 2,
			3  => 0,
			_  => strategy
		};
		
		score_part_2 += toScore(them, me);
	}
}

Console.WriteLine($"Part one: {score_part_1}");
Console.WriteLine($"Part two: {score_part_2}");
