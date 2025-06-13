/*2.Resto da divisão
    
    Escreva um programa que recebe dois números e imprime o resto da divisão do primeiro pelo segundo.*/

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int num3 = num1 % num2;

Console.WriteLine(num3);
