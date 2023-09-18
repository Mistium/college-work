using System;

Console.WriteLine("Welcome To The Maths Tester");

bool running = true;
int tot = 0;
string problem = "";
double answer = 0;
static string generate_problem(int total_mathstuff)
{
    string output = "";
    Random rnd = new Random();
    string Operations = "+-/*";
    
    string addtoout;
    for (int i = 0; i < total_mathstuff; i++)
    {
        
        int num = rnd.Next(1,99);
        addtoout = num.ToString();
        if (i % 2 == 1)
        {
            num = rnd.Next(1,3);
            addtoout = " " + Operations.Substring(num,1) + " ";

        }
        output = output + addtoout;
    }
    
    Console.WriteLine(output);
    return output;
}

while (running) {
    Console.WriteLine("Your question is...");
    Random total = new Random();
    tot = total.Next(2, 6) * 2 - 1;
    problem = generate_problem(tot);
    string[] splitproblem = problem.Split(' ');
    answer = double.Parse(splitproblem[0]);
    for (int sub = 0; sub < splitproblem.Length; sub++)
    {
        switch (splitproblem[sub]) {
            case "+":
                answer += int.Parse(splitproblem[sub+1]);

                break;
            case "-":
                answer -= int.Parse(splitproblem[sub + 1]);
                break;
            case "/":
                answer /= int.Parse(splitproblem[sub + 1]);
                break;
            case "*":
                answer *= int.Parse(splitproblem[sub + 1]);
                break;
        }
    }
    Console.WriteLine(answer);
    Console.ReadLine();
}
