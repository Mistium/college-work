using System;

string answer = "digger";

string checkanswer(string test) {
	string output = "";
	for (int i = 0; i< answer.Length;i++) {
		if (answer[i] == test[i]) {
			output = output + answer[i];
		} else {
			output = output + "?";
		}
	}
	return output;
}

string guess = "";
while (guess != answer) {
Console.WriteLine(checkanswer("bigger"));
}
