string[] tempArr = File.ReadAllLines("reciept.txt");
string[,] purchases = new string[11, 3];

for (int i = 0; i < tempArr.Length; i++) {
    string[] temp2 = tempArr[i].Split(";");
    purchases[i, 0] = temp2[0];
    purchases[i, 1] = temp2[1];
    purchases[i, 2] = temp2[2];
}

double gardening_discount = 1;
double total = 0;
for (int i = 0; i < tempArr.Length; i++) {
    if (purchases[i, 1] == "Gardening") {
        total += double.Parse(purchases[i, 2]);
    }
}

if (total >= 20) { gardening_discount -= 0.1; }

for (int i = 0; i < tempArr.Length; i++)
{
    if (purchases[i, 1] == "Gardening")
    {
        double output = double.Parse(purchases[i, 2]) * (1 - gardening_discount);
        string input = (Math.Round(output * 100) / 100).ToString();
        if (output < 1) { input = input + 0; }
        tempArr[i] = tempArr[i] + "\n-£" + input + " discount";
    }
    Console.WriteLine(tempArr[i]);
}

Console.WriteLine("------------");
Console.WriteLine("");
