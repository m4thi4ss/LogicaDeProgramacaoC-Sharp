/*### **3. Par ou Ímpar**

Crie um programa que receba um número inteiro do usuário e exiba se ele é par ou ímpar.*/

Console.WriteLine("Me informe um numero: ");
int num1 = int.Parse(Console.ReadLine());

int impar = num1 % 2;

if (num1 < 0)
{
    Console.WriteLine("Esse numero não pode ser informado");
}
else if (impar == 1)
{
    Console.WriteLine("Impar");
}
else
{
    Console.WriteLine("Par");
}
