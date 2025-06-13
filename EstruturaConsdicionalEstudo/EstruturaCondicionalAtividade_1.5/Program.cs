/*### **6. Calculadora Simples**

Crie um programa que recebe dois números e uma operação (+, -, *, /) e realiza o cálculo correspondente.*/

Console.WriteLine("Me informe o primeiro numero: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Me informe o operador lógico: ");
char operador = char.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;

if (operador == '-')
{
    resultado = num1 - num2;
    Console.WriteLine($"O resultado da operação seria: {resultado}");
}
else if(operador == '+')
{
    resultado = num1 + num2;
    Console.WriteLine($"O resultado da operação seria: {resultado}");
}
else if(operador == '/')
{
    resultado = num1 / num2;
    Console.WriteLine($"O resultado da operação seria: {resultado}");
}
else if(operador == '*')
{
    resultado = num1 * num2;
    Console.WriteLine($"O resultado da operação seria: {resultado}");
}
else
{
    Console.WriteLine("Alguma informação foi passada incorretamente");
}
