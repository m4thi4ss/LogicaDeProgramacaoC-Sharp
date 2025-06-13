/*1.Média de três números
    
    Escreva um programa que recebe três números e imprime a média aritmética deles.*/

Console.WriteLine("Digite primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int num4 = num1 + num2 + num3;

return num4 / 3; 
