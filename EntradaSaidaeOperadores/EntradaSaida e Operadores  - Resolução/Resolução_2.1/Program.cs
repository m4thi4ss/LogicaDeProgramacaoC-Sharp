/*2.Par ou Ímpar(utilizando operadores de comparação e aritméticos)


    Escreva um programa que recebe um número e imprime `1` se for par e `0` se for ímpar.*/

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
} 
