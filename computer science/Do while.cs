using System;
string pass = "1234";
string inpass = "";
do
{
    Console.WriteLine("Enter Your Password: ");
    inpass = Console.ReadLine();
} while(pass!=inpass);

Console.WriteLine("You Got The Right Password");
