string[] stops = new string[10] {"Brighton Beach",
"London Rd","Patcham","Pycombe","HurstPeirPoint","Albourne",
"Sayers Common","Hickstead","Goddards Green","Burgess Hill"};
while (true) {
    Console.WriteLine("Run Bus Stops: 1\nSearch Bus Stops: 2");
    string choice = Console.ReadLine();
    if (choice == "1") {
        break;
    }
    if (choice == "2") {
    string search = Console.ReadLine();
    for (int i = 0; i < stops.Length; i++)
    {
        if (stops[i].ToLower().Contains(search))
        {
            Console.WriteLine(stops[i]);
        }
    }
}
    Console.ReadLine();
}
before:
for (int i = 0; i < 10; i++)
{
    Console.Clear();
    Console.WriteLine(stops[i]);
    Console.ReadLine();
}
for (int i = 8; i > 0; i--)
{
    Console.Clear();
    Console.WriteLine(stops[i]);
    Console.ReadLine();
}
goto before;
