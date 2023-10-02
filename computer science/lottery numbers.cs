
using System.Globalization;

Random rnd = new Random();
int[,] arr = new int[7, 6];
int current_line = 0;
bool morelines = true;



while (current_line < 7 && morelines == true) {
    Console.WriteLine("Line" + (current_line+1));
    Console.WriteLine("Would You Like A Lucky Dip? y/n");
    string input = Console.ReadLine().ToLower();
    if (input == "y")
    {
        for (int i = 0; i < 6; i++)
        {
            arr[current_line, i] = rnd.Next(1,60);
        }
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            Console.Write(arr[current_line, i] + " ");
        }
        Console.WriteLine("");
    } else
    {
        string[] numbers = { };
        while (numbers.Length != 6) {
            numbers = Console.ReadLine().Split(" ");
            for (int i = 0;i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) > 99 || int.Parse(numbers[i]) < 0)
                {
                    numbers = null;
                }
            }
        }
        for (int i = 0; i < 6; i++)
        {
            arr[current_line, i] = int.Parse(numbers[i]);
        }
    }
    Console.WriteLine("Would you like another line on your ticket? y/n");
    input = Console.ReadLine().ToLower();
    if (input == "n") {
        morelines = false;
    } else
    {
        current_line++;
    }
}
