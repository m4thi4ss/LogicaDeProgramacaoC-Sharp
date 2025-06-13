/*### **8. Triângulo Válido e Tipo**

Receba três valores numéricos e verifique se eles podem formar um triângulo. Caso possam, determine se ele é equilátero, isósceles ou escaleno.*/

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
}
