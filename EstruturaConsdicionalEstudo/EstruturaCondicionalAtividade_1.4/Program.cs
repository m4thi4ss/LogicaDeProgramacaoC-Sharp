/*### **5. Cálculo do Delta (Fórmula de Bhaskara)**

Receba os coeficientes de uma equação quadrática (ax² + bx + c = 0) e calcule o delta.

> Delta: b² - 4 * a * c
> 

**EXTRA**: Finalize toda a fórmula de Bhaskara, descobrindo x e x’*/

Console.WriteLine("Me informe o a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o c: ");
int c = int.Parse(Console.ReadLine());

double delta = (b * b) - ((4 * a) * c);

Console.WriteLine($"O valor do delta seria {delta}");
