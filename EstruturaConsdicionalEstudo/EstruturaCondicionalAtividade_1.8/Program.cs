/*### **9. Classificação de Nota**

Receba uma nota e classifique-a conforme a seguinte tabela:

-**A * *(90 - 100)
- **B * *(80 - 89)
- **C * *(70 - 79)
- **D * *(60 - 69)
- **F * *(menor que 60)*/

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
}
