/*### **4. Maior de Três Números**

Receba três números e determine o maior entre eles.*/

Console.WriteLine("Me informe o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine($"O maior numero seria {maior}");