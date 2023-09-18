Console.WriteLine("What Temperature is the water? (INT)")
int temperature = int.Parse(Console.ReadLine());
if (temperature <= 0) {
  Console.WriteLine("Ice");
}
else if (temperature > 0 && temperature < 100) {
  Console.WriteLine("Water");
}
else {
  Console.WriteLine("Steam");
}
