int rnd = new Random();
int num = rnd.Next(1,101);
int input = 0;
int tries = 0;

while (num != input) {
  Console.WriteLine("Guess The Number 1-100");
  input = Console.ReadLine();
  if (input > num) {
    Console.WriteLine("Lower");
  } else if (input < num) {
    Console.WriteLine("Higher");
  } else if (input == num) {
    Console.WriteLine("You Win");
  }
  tries += 1;
}
Console.WriteLine("You Took " + tries.ToString() + " To Guess " + num.ToString())
