using System.ComponentModel;

Console.WriteLine("Welcome to Calculater C sharp\n");

Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter seconed number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter The Opertion Like (* , / , + , - , %)");
string? opertion = Console.ReadLine();

var opertionSwitch = opertion switch{
    "+" => $"{num1} + {num2} =  {num1 + num2}",
    "-" => $"{num1} - {num2} = {num1 - num2} ",
    "*" => $"{num1} * {num2} = {num1 * num2}",
    "/" => $"{num1} / {num2} = {num1 / num2}",
    "%" => $"{num1} % {num2} = {num1 % num2}",
    _ => "please Enter Operation like (* , / , + , - , %))"
};
Console.WriteLine(opertionSwitch);

