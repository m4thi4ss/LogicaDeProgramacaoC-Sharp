/*3.Valor máximo entre três números (usando operadores de comparação)
    
    Escreva um programa que recebe três números e imprime o maior deles sem utilizar if/else ou laços de repetição.*/

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine(maior);

