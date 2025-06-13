/*# **1. Maior de Dois Números**

Peça dois números inteiros ao usuário e exiba o maior entre eles.*/

Console.WriteLine("Me informe o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, num2);

Console.WriteLine($"O maior vai ser {maior}");
