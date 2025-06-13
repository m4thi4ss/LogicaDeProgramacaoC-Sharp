/*### **2. Classificação de Idade**

Peça a idade do usuário e classifique-o como:

-"Criança"(0 a 12 anos)
- "Adolescente"(13 a 17 anos)
- "Adulto"(18 anos ou mais)*/

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
}