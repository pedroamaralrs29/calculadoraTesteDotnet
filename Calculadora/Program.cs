// See https://aka.ms/new-console-template for more information
using Calculadora.Services;

CalculadoraImplementacao c = new CalculadoraImplementacao();

int num1 = 1;
int num2 = 1;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");