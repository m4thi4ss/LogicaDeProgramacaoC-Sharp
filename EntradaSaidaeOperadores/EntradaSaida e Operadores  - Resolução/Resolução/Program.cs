/*1. * *Soma de dois números**
    
    Escreva um programa que recebe dois números e imprime a soma deles.

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

return num1 + num2;*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*2.Produto de dois números
    
    Escreva um programa que recebe dois números e imprime o produto deles.

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

return num1 * num2;*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*3.Diferença


    Escreva um programa que recebe dois números e imprime a diferença entre eles.

Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

return num1 - num2;*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*1.Média de três números
    
    Escreva um programa que recebe três números e imprime a média aritmética deles.

Console.WriteLine("Digite primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int num4 = num1 + num2 + num3;

return num4 / 3; */

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*2.Resto da divisão
    
    Escreva um programa que recebe dois números e imprime o resto da divisão do primeiro pelo segundo.

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int num3 = num1 % num2;

Console.WriteLine(num3);*/



//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*1.Troca de valores sem variável auxiliar
    
    Escreva um programa que troca os valores de duas variáveis sem usar variável auxiliar.

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

num1 = num1 + num2; //Primeiro somar todos, para fazer a substituição.
num2 = num1 - num2; //Fazer a substituição do primeiro para o segundo, onde ele vai fazer ex.: 1 + 2 = num1(3); num1(3) - num2(2) = num2(1).
num1 = num1 - num2; //Fazer agora a substituição do segundo pro primeiro, onde ele vai fazer ex.: num2(1) - num1(3) = num1(2)

Console.WriteLine($"O primeiro numero seira {num1} e o segundo seria {num2}");*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*2.Par ou Ímpar(utilizando operadores de comparação e aritméticos)


    Escreva um programa que recebe um número e imprime `1` se for par e `0` se for ímpar.

Console.WriteLine("Digite um numero: ");
int num1 = int.Parse(Console.ReadLine());

int num2 = num1 % 2;

if (num2 == 1)
{
    Console.WriteLine("0 - impar");
}
else
{
    Console.WriteLine("1 - par");
} */

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*3.Valor máximo entre três números (usando operadores de comparação)
    
    Escreva um programa que recebe três números e imprime o maior deles sem utilizar if/else ou laços de repetição.

Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine(maior);*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

