
// Rock     A X >> 0
// Paper    B Y >> 1
// Scissors C Z >> 2
// Game result key: 0 < 1 < 2 < 0

int getScore(int them, int me)
	=> 1 + me + (them - me) switch {
			-2 => 0,// -2 >> 02        LOSE
			-1 => 6,// -1 >> 12 01     WIN
			 0 => 3,//  0 >> 00 11 22  DRAW
			 1 => 0,//  1 >> 21 10     LOSE
			 2 => 6,//  2 >> 20        WIN
			 _ => throw new Exception("Unreachable Code")
		};

var score_part_1 = 0;
var score_part_2 = 0;

string? line;
while ((line = Console.ReadLine()) != null) {
	var me = line[2] - 'X';
	var them = line[0] - 'A';
	
	{/* -~={ Part 1 }=~-*/
		score_part_1 += getScore(them, me);
	}
	
	{/* -~={ Part 2 }=~-*/
		var strategy = them + me switch {
			0 => -1, // LOSE
			1 =>  0, // DRAW
			2 =>  1, // WIN
			_ => throw new Exception("Unreachable Code")
		};
		
		me = strategy switch { // Handle overflows
			-1 => 2,
			 3 => 0,
			 _ => strategy
		};
		
		score_part_2 += getScore(them, me);
	}
}

Console.WriteLine($"Part one: {score_part_1}");
Console.WriteLine($"Part two: {score_part_2}");
