int[] gears = new int[8];
int ringnum = 0;
bool inputting = true;
while (inputting) {
  Console.WriteLine("How many gears on the bike?");
  gears = int.Parse(Console.Readline());
  if (gears > 8 || gears < 1) {
    Console.WriteLine("Too many gears, must be within 1 to 8");
  } else {
    inputting = false
  }
}
int teeth = 101;
int previousteeth = 100;
for (int count = 0;count < gears;count++) {
  while (teeth > previousteeth) {
    Console.WriteLine("How many teeth for gear" + count.ToString() + "?");
    teeth = int.Parse(Console.ReadLine());
  }
  previousteeth = teeth;
  Console.WriteLine(teeth.ToString() + "teeth on this gear");
  gears[count] = teeth
}
for (int count = 0;count < 8;count++) {
  Console.WriteLine(gears[count]);
}
