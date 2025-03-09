// See https://aka.ms/new-console-template for more information
using RekenMachine.Lib;
using System;

double result = 0;

double num1 = 0;
double num2 = 0;
int _operator = 0;

Console.Write("Type a number, and then press Enter: ");
string strnum1 = Console.ReadLine();

while (!double.TryParse(strnum1, out num1))
{
    Console.Write("Input is not a number. Please enter a number: ");
    strnum1 = Console.ReadLine();
}

Console.WriteLine("Choose an operator:");
Console.WriteLine($"\t0 - {ExpressionOperator.Add}");
Console.WriteLine($"\t1 - {ExpressionOperator.Sub}");
Console.WriteLine($"\t2 - {ExpressionOperator.Multiply}");
Console.WriteLine($"\t3 - {ExpressionOperator.Divide}");

_operator = Convert.ToInt16(Console.ReadLine());

Console.Write("Type a second number, and then press Enter: ");
string strnum2 = Console.ReadLine();

while (!double.TryParse(strnum2, out num2))
{
    Console.Write("Input is not a number. Please enter a number: ");
    strnum2 = Console.ReadLine();
}

result = num1.Calculate(_operator, num2);

Console.WriteLine("Your result: {0:0.##}\n", result);