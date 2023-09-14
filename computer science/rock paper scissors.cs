using System;

bool game = true;
char move = 'n';
char comp = 'n';
string win;
int wins = 0;
int plays = 0;
int choice = -1;
string moves = "rps";
Random random = new Random(); // Added a Random object for generating computer moves

Console.WriteLine("Welcome To Rock Paper Scissors, Type 'x' At Any Point To Close The Game");

difficulty:
Console.WriteLine("Choose a difficulty (Impossible or Normal)");
string difficulty = Console.ReadLine().ToLower();
if (difficulty != "impossible" && difficulty != "normal") // Changed || to &&
{
    goto difficulty;
}

while (game)
{
choosemove:
    Console.WriteLine("Rock Paper Or Scissors? (R/P/S)");
    move = Console.ReadLine().ToLower()[0];

    if (move == 'x') // Added the ability to exit the game
    {
        game = false;
        break;
    }

    if (!moves.Contains(move))
    {
        Console.WriteLine("Invalid Move");
        goto choosemove;
    }

    if (difficulty == "impossible")
    {
        if (move == 'r')
            comp = 'p';
        else if (move == 'p') // Changed if statements to else if
            comp = 's';
        else if (move == 's')
            comp = 'r';
    }
    else
    {
        choice = random.Next(0, 3);
        comp = moves[choice]; // Corrected Character.toString to .ToString()
    }

    Console.WriteLine("You Played {0}", move);
    Console.WriteLine("The Computer Played {0}", comp);
    plays += 1;

    if ((move == 'r' && comp == 's') || (move == 'p' && comp == 'r') || (move == 's' && comp == 'p'))
    {
        win = "Player";
        wins += 1;
    }
    else if (move == comp)
    {
        win = "Tie";
    }
    else
    {
        win = "Computer";
    }

    Console.WriteLine("Winner: {0}", win);
}

Console.WriteLine("You Won {0} Times", wins);
