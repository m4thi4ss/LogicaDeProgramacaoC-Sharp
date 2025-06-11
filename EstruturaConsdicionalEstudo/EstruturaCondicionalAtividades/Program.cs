/*# **1. Maior de Dois Números**

Peça dois números inteiros ao usuário e exiba o maior entre eles.

Console.WriteLine("Me informe o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, num2);

Console.WriteLine($"O maior vai ser {maior}");*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **2. Classificação de Idade**

Peça a idade do usuário e classifique-o como:

-"Criança"(0 a 12 anos)
- "Adolescente"(13 a 17 anos)
- "Adulto"(18 anos ou mais)

Console.WriteLine("Me informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 0 || idade > 100)
{
    Console.WriteLine("Essa idade não pode ser informada");
}
else if (idade <= 12)
{
    Console.WriteLine("Criança");
}
else if(idade <= 17 )
{
    Console.WriteLine("Adolescente");
}
else if(idade >= 18 )
{
    Console.WriteLine("Adulto");
}*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **3. Par ou Ímpar**

Crie um programa que receba um número inteiro do usuário e exiba se ele é par ou ímpar.

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
}*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **4. Maior de Três Números**

Receba três números e determine o maior entre eles.

Console.WriteLine("Me informe o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine($"O maior numero seria {maior}");*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **5. Cálculo do Delta (Fórmula de Bhaskara)**

Receba os coeficientes de uma equação quadrática (ax² + bx + c = 0) e calcule o delta.

> Delta: b² - 4 * a * c
> 

**EXTRA**: Finalize toda a fórmula de Bhaskara, descobrindo x e x’

Console.WriteLine("Me informe o a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o c: ");
int c = int.Parse(Console.ReadLine());

double delta = (b * b) - ((4 * a) * c);

Console.WriteLine($"O valor do delta seria {delta}");*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **6. Calculadora Simples**

Crie um programa que recebe dois números e uma operação (+, -, *, /) e realiza o cálculo correspondente.

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
}*/

//-------------------------------------------------------------------------------------------------
/*### **7. Ano Bissexto**

using static System.Runtime.InteropServices.JavaScript.JSType;

Crie um programa que recebe um ano e verifica se ele é bissexto.

https://learn.microsoft.com/pt-br/office/troubleshoot/excel/determine-a-leap-year

> Qualquer ano que seja uniformemente divisível por 4 é um ano bissexto: por exemplo, 1988, 1992 e 1996 são anos bissextos.
> 

> No entanto, ainda há um pequeno erro que deve ser contabilizado. Para eliminar esse erro, o calendário gregoriano estipula que um ano que é uniformemente divisível por 100 (por exemplo, 1900) é um ano bissexto apenas se também é igualmente divisível por 400.
>

Console.WriteLine("Me informe o ano: ");
int ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine("O ano é bissexto");
}
else
{
    Console.WriteLine("O ano não é bissexto");
}*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **8. Triângulo Válido e Tipo**

Receba três valores numéricos e verifique se eles podem formar um triângulo. Caso possam, determine se ele é equilátero, isósceles ou escaleno.

Console.WriteLine("Me informe lado a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe lado b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe lado c: ");
int c = int.Parse(Console.ReadLine());

if (a + b > c || a + c > b || b + c > a)
{
    if(a == b && b == c)
    {
        Console.WriteLine("Seria um triangulo Equilátero.");
    }
    else if(a == b && b != c)
    {
        Console.WriteLine("Seria um triangulo Isósceles");
    }
    else if (a != b && b != c)
    {
        Console.WriteLine("Seria um triangulo Escaleno");
    }
}
else
{
    Console.WriteLine("Não é um triangulo!");
}*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **9. Classificação de Nota**

Receba uma nota e classifique-a conforme a seguinte tabela:

-**A * *(90 - 100)
- **B * *(80 - 89)
- **C * *(70 - 79)
- **D * *(60 - 69)
- **F * *(menor que 60)

Console.WriteLine("Me informe a nota: ");
int nota = int.Parse(Console.ReadLine());

if(nota < 0 && nota > 100)
{
    Console.WriteLine("Essa nota não existe");
}
else if(nota > 90)
{
    Console.WriteLine("Sua nota é A");
}
else if(nota > 80)
{
    Console.WriteLine("Sua nota é B");
}
else if (nota > 70)
{
    Console.WriteLine("Sua nota é C");
}
else if(nota > 60)
{
    Console.WriteLine("Sua nota é D");
}
else 
{
    Console.WriteLine("Sua nota é F");
}*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

