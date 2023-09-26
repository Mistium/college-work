using System.Diagnostics;


String[] towns = File.ReadAllLines("C:\\Users\\89728\\Downloads\\TownArray.txt");

String Search = "";
Console.WriteLine("Search Items For:");
Search = Console.ReadLine();
int total = 0;
double elapsed_time = 0;
var stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i < towns.Length; i++)
{
    if (towns[i].Contains(Search))
    {
        total += 1;
    }
}
stopwatch.Stop();
elapsed_time = stopwatch.ElapsedMilliseconds;
Console.WriteLine("Found " + total + " Items In " + elapsed_time + " Miliseconds");

for (int i = 0; i < towns.Length; i++)
{
    if (towns[i].Contains(Search))
    {
        Console.WriteLine(towns[i]);
    }
}
