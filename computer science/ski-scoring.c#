using System;

// Max function finds the maximum value in an array and returns the index of it
int max(string[] input) {
	double highest = 0;
	int highestid = -1;
	for (int i = 0;i < input.Length; i++) {
		if (double.Parse(input[i]) > highest) {
			highest = double.Parse(input[i]);
			highestid = i;
		}
	}
	return highestid;
}

// Min function finds the minimum value in an array and returns the index of it
int min(string[] input) {
	double lowest = max(input);
	int lowestid = -1;
	for (int i = 0;i < input.Length; i++) {
		if (int.Parse(input[i]) < lowest) {
			lowest = double.Parse(input[i]);
			lowestid = i;
		}
	}
	return lowestid;
}

// Take input for the athlete name
string name = "";
while (name == "") {
	Console.WriteLine("Enter Contestant Name");
	name = Console.ReadLine().ToString();
}

// Take in the judges scores from the user in a single line
string[] getscore() {
string[] getscores = new string[5];
bool inputtingscores = true;

while (inputtingscores) {
	// Reset the end while loop flag 
	Console.WriteLine("Enter Judge Scores In A Row, Seperated by Spaces");
	getscores = Console.ReadLine().ToString().Replace(","," ").Replace("  "," ").Split(' ');
	// Ask for 5 scores untill the user inputs 5 scores
	while (getscores.Length != 5) {
		Console.WriteLine("Please Input 5 Scores");
		getscores = Console.ReadLine().ToString().Replace(","," ").Replace("  "," ").Split(' ');
		Console.WriteLine();
	}
	Console.WriteLine();
	
	for (int i = 0;i < 5;i++) {
		if (double.Parse(getscores[i]) <= 20 && double.Parse(getscores[i]) >= 0) {
			Console.WriteLine("Validated Judge " + (i + 1) + "'s Score");
		} else {
			// Tells the program that there has been a modification to this data, during this loop
			while (double.Parse(getscores[i]) > 20 || double.Parse(getscores[i]) < 0) {
				Console.WriteLine("Score" + (i + 1) + " (" + getscores[i] + ") must be between 0 and 20. Re-enter this value below");
				getscores[i] = Console.ReadLine().ToString();
			}
			
		}
		
	}
	// check scores to make sure they are valid
	inputtingscores = false;
	for (int i = 0;i < 5;i++) {
		if (double.Parse(getscores[i]) > 20 && double.Parse(getscores[i]) < 0) {
			inputtingscores = true;
		}
	}
	
}
	return getscores;
}

Console.WriteLine("\nPlease Enter The First Set Of 5 Scores");
string[] scores = getscore();
Console.WriteLine("\nPlease Enter The Second Set Of 5 Scores");
string[] scores2 = getscore();

// stores the indexes of the biggest and smallest scores
Console.WriteLine("\nFinding Min Of Your Scores");
int minscore = min(scores);
int minscore2 = min(scores2);
Console.WriteLine("\nFinding Max Of Your Scores");
int maxscore = max(scores);
int maxscore2 = max(scores2);

Console.WriteLine("\nAveraging Score");
// crosses out the max and min scores for both sets
scores[maxscore] = scores[maxscore] + "(Removed)";
scores[minscore] = scores[minscore] + "(Removed)";
scores2[maxscore2] = scores2[maxscore2] + "(Removed)";
scores2[minscore2] = scores2[minscore2] + "(Removed)";

Console.WriteLine("\nFound Outlier Scores");
// Display the removed items from the scores list on the console
Console.WriteLine();
double total = 0;
for (int i = 0;i < 5;i++) {
	Console.Write(scores[i] + " ");
	if (!scores[i].Contains("(Removed)")) {
		total += double.Parse(scores[i]);
	}
}
Console.Write("Total: " + total);

Console.WriteLine();
double total2 = 0;
for (int i = 0;i < 5;i++) {
	Console.Write(scores2[i] + " ");
	if (!scores2[i].Contains("(Removed)")) {
		total2 += double.Parse(scores2[i]);
	}
}
Console.Write("Total: " + total2);

Console.WriteLine();
Console.WriteLine(name + " Has A Total Of " + (total + total2));
