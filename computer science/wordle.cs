string[] words = { "hello","fortn" };

Random random = new Random();

string current_word = words[random.Next(0,words.Length)];
string[] green_letters = new string[5];
string[] yellow_letters = new string[5];

for (int i2 = 0; i2 < 7; i2++)
{
    string input_word = Console.ReadLine().ToString();
    for (int i = 0; i < 5; i++)
    {
        if (current_word[i] == input_word[i])
        {
            green_letters[i] = "1";
        }
        if (current_word.Contains(input_word[i]))
        {
            yellow_letters[i] = "1";
        }
    }

    for (int i = 0; i < 5; i++)
    {
        if (green_letters[i] == "1")
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (yellow_letters[i] == "1")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else { 
            Console.ForegroundColor = ConsoleColor.Gray; 
        }
        Console.Write(input_word[i] + " ");
    }
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Gray;
    if (current_word == input_word) {
        Console.WriteLine("You guessed it in {0} tries",i2);
        break;
    }
}

if (current_word != input_word)
{
    Console.WriteLine("You failed to guess the word");
    Console.WriteLine("The word was {0}", current_word);
}
