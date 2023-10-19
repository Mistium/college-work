using System;
using System.Text.RegularExpressions;

Console.WriteLine("Enter An Email");
string email = Console.ReadLine();

Regex r = new Regex(@"[\w.]*[^.@]@\w+(?:\.\w+)+", RegexOptions.IgnoreCase);

if (r.Match(email).ToString().Contains(email)) {
	Console.WriteLine("This Is A Valid Email");
} else {
	Console.WriteLine("This Is An Invalid Email");
}
