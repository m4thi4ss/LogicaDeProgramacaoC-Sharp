/*### **1. Contagem de 1 a 20**

Crie um programa que exiba os números de 1 a 20 na tela.

for(int i = 1; i < 21 ; i++)
{
    Console.WriteLine(i);
}*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **2. Validação de senha**

Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

int senha;

do
{
    Console.WriteLine("Me informe a senha:");
    senha = int.Parse(Console.ReadLine());

    if(senha == 1234 )
    {
        Console.WriteLine("Acesso liberado!");
    }
    else
    {
        Console.WriteLine("Senha incorreta");
    }

}while(senha != 1234);*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **3. Tabuada de um número**

Peça ao usuário um número e exiba a tabuada dele de 1 a 10.

Console.WriteLine("Me informe um numero: ");
int num = int.Parse(Console.ReadLine());

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
}*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **4. Contagem regressiva**

Peça um número ao usuário e faça uma contagem regressiva até 0.

Console.WriteLine("Me informe um numero: ");
int num = int.Parse(Console.ReadLine());

for (int i = num; i >= 0; i--)
{
    Console.WriteLine(i);
}*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **5. Média de notas**

Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.

int numero;
int resultado = 0;
int qtdNotas = 0;

do
{
    Console.WriteLine("Me informe a nota:");
    numero = int.Parse(Console.ReadLine());

    if (numero >= 0 && numero <= 10)
    {
        resultado = numero + resultado;
        qtdNotas++;
    }

} while (numero >= 0 && numero <= 10);

int media = numero / qtdNotas;

Console.WriteLine($"A média é {media}");*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **6. Somatório de números positivos**

Escreva um programa que peça números ao usuário e some-os, parando quando o usuário inserir um número negativo.

int numero;
int resultado = 0;

do
{
    Console.WriteLine("Me informe um numero: ");
    numero = int.Parse(Console.ReadLine());

    if(numero >= 0)
    {
        resultado = numero + resultado;
    }
}while(numero >= 0);

Console.WriteLine(resultado);*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **7. Número primo**

Peça ao usuário um número e determine se ele é primo.

Console.WriteLine("Me informe um numero: ");
int num = int.Parse(Console.ReadLine());

int resultado = num % 1;
int resultado1 = num % num;
int resultado2;

for (int i = 2; i <= num; i++)
{
    resultado2 = num % i;

    if (resultado == 0 && resultado1 == 0 && resultado2 == 1)
    {
        Console.WriteLine("É um numero Primo");
        break;
    }
    else if(num == 2)
    {
        Console.WriteLine("É um numero Primo");
        break;
    }
    else
    {
        Console.WriteLine("Não é um numero Primo");
        break;
    }
}*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **8. Sequência de Fibonacci**

Peça um número N ao usuário e exiba os N primeiros termos da sequência de Fibonacci.


Console.WriteLine("Me informe um numero: ");
int num = int.Parse(Console.ReadLine());

int primeiro = 0;
int segundo = 1;
int resultado;

for (int i = 0; i <= num; i++)
{
    resultado = primeiro + segundo;

    
    primeiro = segundo;
    segundo = resultado;

    Console.Write(primeiro);
    
}*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **9. Adivinhe o número**

O programa escolhe um número aleatório entre 1 e 100. O usuário tenta adivinhar e o programa dá dicas.


int numero;
int escolhido;

Random random = new Random();
escolhido = random.Next(0, 100);

do
{
    Console.WriteLine("Me informe o número correto: ");
    numero = int.Parse(Console.ReadLine());

    if (numero == escolhido)
    {
        Console.WriteLine("Acertou!");
    }
    else if (numero < escolhido)
    {
        Console.WriteLine("Errou! O número é maior.");
    }
    else
    {
        Console.WriteLine("Errou! O número é menor.");
    }

}while(numero != escolhido);*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------