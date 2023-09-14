bool game = true;
string move;
string comp;
string win;
int wins = 0;
int plays = 0;
int choice = -1;
string moves = "rps";

console.WriteLine("Welcome To Rock Paper Scissors, Type 'Exit' At Any Point To Close The Game");
difficulty:
console.WriteLine("Choose a difficulty (Impossible or Normal)");
string difficulty = console.ReadLine().ToLower();
if (difficulty != "impossible" || difficulty != "normal") {
  goto difficulty;
}
while game {
  choosemove:
  console.WriteLine("Rock Paper Or Scissors? (R/P/S)");
  move = console.ReadLine().ToLower();
  if (!moves.Contains(move)){
    console.WriteLine("Invalid Move");
    goto choosemove;
  }
  if (difficulty == "Impossible") {
    if (move == "r"):
      comp = "p";
    if (move == "p"):
      comp = "s";
    if (move == "s"):
      comp = "r";
  } else {
    choice  = rnd.Next(0, 3);
    move = moves[choice]
  }
  console.WriteLine("You Played {0}", move);
  console.WriteLine("The Computer Played {0}", comp);
  plays += 1;
  if ((move == "r" && comp == "s") || (move == "p" && comp == "r") || (move == "s" && comp == "r")) {
    win = "Player";
    wins += 1
  } else {
    win = "Computer";
  }
}

console.WriteLine("You Won {0} Times", wins)
