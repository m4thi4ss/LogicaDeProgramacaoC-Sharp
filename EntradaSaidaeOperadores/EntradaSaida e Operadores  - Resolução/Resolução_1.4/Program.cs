/*1.Troca de valores sem variável auxiliar
    
    Escreva um programa que troca os valores de duas variáveis sem usar variável auxiliar.*/

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

num1 = num1 + num2; //Primeiro somar todos, para fazer a substituição.
num2 = num1 - num2; //Fazer a substituição do primeiro para o segundo, onde ele vai fazer ex.: 1 + 2 = num1(3); num1(3) - num2(2) = num2(1).
num1 = num1 - num2; //Fazer agora a substituição do segundo pro primeiro, onde ele vai fazer ex.: num2(1) - num1(3) = num1(2)

Console.WriteLine($"O primeiro numero seira {num1} e o segundo seria {num2}");
