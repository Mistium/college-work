Console.WriteLine("What Times Table Do You Want");
int table = int.Parse(Console.ReadLine());
for (int i = 1; i < 12; i++) {
    Console.WriteLine(i + " x " + table + " = " + ( table * i ));
}
