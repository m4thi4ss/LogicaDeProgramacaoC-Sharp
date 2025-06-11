/*### **1. Maior de Dois Números**

Peça dois números inteiros ao usuário e exiba o maior entre eles.

Console.WriteLine("Digite o primeiro numero: "); //Aqui seria o WriteLine, onde ele vai lançar uma mensagem na tela do console para o usuario, nesse caso ele esta solicitando para digitar o primeiro numero.
int num1 = int.Parse(Console.ReadLine());// int - Seria o tipo de dados. num1 - Seria o nome da variavel. int.Parse - Serve para avisar que não sera uma string e sim um int. Console.ReadLine - Ele serve para ler a informação do usuario e guardar a informação. Sendo assim foi feito um WriteLine para solicitar a usuario que digite um numero, após isso foi criado uma variavel para guardar essa informação, a variavel foi criada com o nome num1 com o tipo de dado int e como vai ser um numero inteiro coloquei o int.Parse para informar que não sera um string e sim um int, pra finalizar utilizei o RedLine para ler e transformar o que o usuario vai informar não sera um string e sim um int.

Console.WriteLine("Digite o segundo numero: "); // Aqui seria o WriteLine ele vai aparecer uma mensagem no cosole para usuario, nesse caso ele esta solicitando o segundo numero
int num2 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel. num2 - Seria o nome da variavel. int.Parse - Serve para informar que não sera uma string e sim um int. Console.ReadLine - Ele vai fazer uma leitura e vai transformar a resposta do usuario de strind para int. Sendo assim foi criado um WriteLine para informar no console para o usuario pra ele digitar o segundo numero, após isso foi criado uma variavel chamada num2 com o tipo de dado int, como esta como int precisei usar o int.Parse para informar que a informação que vai ser passada pelo usuario vai ser int e não uma string, e finalizamos com o ReadLine onde ele e utilizado para fazer a leitura e transformar a informação que foi guardada de string para int.

int maior = Math.Max(num1, num2); //int - Seria o tipo de dado da variavel. maior - Seria o nome da variavel. Math.Max - Esse é usado para verificar qual é o maior numero informado pelo usuario. num1 e num2 - Seria as variaveis que guarda as informações passada pelo usuario. Sendo assim foi criado uma variavel para com o nome maior com o tipo de dado int, usando o Math.Max para verificar qual das variaveis são a maior.

Console.WriteLine(maior); //Esse seria o WriteLine onde vai mostrar no console uma mensagem para o usuario, nesse caso ele vai mostrar o resultado da variavel maior.

Console.WriteLine("Digite o primeiro numero: "); //Aqui seria um WriteLine onde vai mostrar uma mensagem para usuario, nesse caso ele vai solicitar o primeiro numero.
int num3 = int.Parse(Console.ReadLine()); //int - Esse seria o tipo de dado da variavel. num3 - Seria o nome da variavel. int.Parse - Ele serve para informar que a informação que o usuario passar não vai ser uma string e sim um int. Console.ReadLine - Aqui serve para ele ler a informação passada pelo usuario e transformar de string para int. Sendo assim foi utilizado um WriteLine para informar o usuario colocar o primeiro numero, após isso ele criou uma variavel chamada num3 onde tem o tipo de dado int e como vai ser guardado um int colocou o int.Parse para informar que sera um int e não uma string e pra finalizar usei o ReadLine para transformar a informação do usuario de string para int.

Console.WriteLine("Digite o segundo numero: "); //Aqui seria um WriteLine onde vai mostar uma mensagem na tela do console para o usuario, nesse caso esta pedindo para digitar o segundo numero.
int num4 = int.Parse(Console.ReadLine()); //int - Seria um tipo de dado; num4 - Seria o nome da variavel; int.Parse - Esse esta informando que a informação passada pelo usuario não sera um string e sim um int; Console.ReadLine - Ele vai ler a informação e vai transformar a mesma de string para int.  Sendo assim usou o WriteLine para solicitar o segundo numero e após ter solicitado o segundo numero criou uma variavel onde se chama num4 sendo um tipo de dado int, como ele vai ser um int usei o int.Parse para informar que sera um int e não uma string e para finalizar eu usei o Console.ReadLine para transformar a informação do usuario de string para int. 

if (num3 > num4) //if - Ele seria o SE, nesse caso seria SE o num3 for maior que o num4 ele vai mostrar o num3 
{
    Console.WriteLine(num3); // Esse seria o WriteLine onde ele vai mostrar o resultado do if
}
else //Esse seria o else, ele serve quando tem pouca informação, para ele fazer o SE NÃO, nesse caso ele vai servir para SE NÃO for maior que o num4 ele vai mostrar o num4 ao inves do num3. Referente a pouca informação é que caso tivesse 5 variaveis e ele tem que verificar o maior entre os 5, ai teria que criar o elseif.
{
    Console.WriteLine(num4); //Esse seria o WriteLine onde ele vai mostar o resultado num4.
}
Console.WriteLine("Digite o primeiro numero: ");
int num5 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
int num6 = int.Parse(Console.ReadLine());

int maior1 = Math.Max(num5, num6);

Console.WriteLine(maior1);

Console.WriteLine("Digite o primeiro numero: ");
int num7 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
int num8 = int.Parse(Console.ReadLine());

if (num7 > num8)
{
    Console.WriteLine(num7);
}
else
{
    Console.WriteLine(num8);
}*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **2. Classificação de Idade**

Peça a idade do usuário e classifique-o como:

-"Criança"(0 a 12 anos)
- "Adolescente"(13 a 17 anos)
- "Adulto"(18 anos ou mais)

Console.WriteLine("Qual seria a sua idade?"); //Aqui foi criado um WriteLine onde ele vai mostrar uma mensagem na tela do console para o usuario, nesse caso ele solicitou a idade.
int idade = int.Parse(Console.ReadLine()); //int - Ele seria um tipo de dado; idade - Seria o nome da variavel; int.Parse - Ele esta informando que o usuario vai mandar um informação int e não string; Console.ReadLine - Aqui ele vai ler a informação passada pelo o usuario e vai transformar o tipo de dado de string para int. Sendo assim ele criou uma mensagem para o usuario informando que precisa da idade do mesmo. int - Seria um tipo de dado. idade - Seria o nome da variavel. int.Parse - Aqui ele esta informando o que sera guardado não sera uma string e sim um int. Console.ReadLine - Ele lê a informação passada pelo usuario e transforma de string para int. 

if (idade >= 0 &&  idade <= 12) //Esse seria o if
                                //onde ele serve para SE a informação tal for essa ele vai mostrar tal mensagem. Nesse caso ele usa o if para informar que SE a idade for maior ou igual a 0 será criança.
{
    Console.WriteLine("Criança"); //Esse seria um WriteLine onde ele lança uma mensagem para o usuario pelo console, nesse caso se a idade que o usuario informar for menor que 12 ou igual, vai aparecer criança.
}
else if (idade >= 13 && idade <= 17) //Else if - Quando tem diversas informações, nesse caso tem 3 etapas de idade Criança, Adolescente e Adulto, então ele tem que ser usado para a nomenclatura não seja atingida. Nesse caso ele esta informando que se a idade for igual ou maior a 13 vai ser adolescente e se for menor e igual a 17 sera adolescente.
{
    Console.WriteLine("Adolescente");
}
else //Else ele não a precisão de um paramentro, por que ele pega os paramentros que foi ja informado e cria um else SE NÃO for nenhum desses parametros ele vai emitir a minha mensagem.
{
    Console.WriteLine("Adulto"); //Aqui seria o WriteLine onde ele vai mostrar na tela uma mensagem para o usuario. Nesse caso ele vai mostrar adulto na tela se o numero indicado pelo usuario for maior ou igual que 18.
}

Console.WriteLine("Me informe sua idade: ");
int idade1 = int.Parse(Console.ReadLine());

if (idade1 >= 0 && idade1 <= 12)
{
    Console.WriteLine("Criança");
}
else if (idade1 >= 13 && idade1 <= 17)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Adulto");
}*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **3. Par ou Ímpar**

Crie um programa que receba um número inteiro do usuário e exiba se ele é par ou ímpar.

Console.WriteLine("Me informe um numero: "); //Esse seria o WriteLine onde ele vai mandar uma mensagem para o usuario na tela do console, nesse caso ele esta solicitando um numero para verificar se é impar ou par.
int num1 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel; num1 - seria o nome da variavel; int.Parse - Aqui esta informando que não sera uma string e sim um int; Console.ReadLine() - Esse ele le a informação que o usuario manda e transforma de string para int. Sendo assim usei o Console.WriteLine para solicitar um numero, criando uma variavel onde vai ser um tipo de dado int se chamando num1, como ela vai ter um tipo de dado int, usei um int.Parse pra avisar que não sera uma string e sim uma int, concluindo a configuração com Console.ReadLine onde ele vai le a informação do usuario e vai trocar de string para int.

int num2 = num1 % 2; //int - Tipo de dado da variavel; num2 - nome da variavel; num1 - Seria a variavel que guarda a informação passada pelo usuario; % - Esse seria um operador logica; 2 - Por que o "2", porque ele é um numero perfeito pra ve o resto da divisão. Sendo assim foi criado uma variavel chamada num2 com tipo de dado int, e ele pega a informação que foi passada pelo usuario sendo a variavel num1, onde vai fazer a divisão por 2, usando o operador logico % onde vai pegar o resto da divisão, então se der 0 é par e se der 1 e impar.

if (num2 == 0) //if - Ele seria o SE for tal coisa ele vai lançar uma mensagem, nesse caso SE o num2 for igual a 0 ele vai retornar uma mensagem em WriteLine.
{
    Console.WriteLine("Par"); //Essa seria a mensagem WriteLine, onde vai mandar uma mensagem no console para o usuario conseguir ve, nesse caso se for o if informado ele vai ser PAR.
}
else //O ELSE ele serve para caso de qualquer coisa diferente do if ele vai lançar mensagem abaixo.
{
    Console.WriteLine("Impar"); //Esse seria a mensagem, o WriteLine ele vai lançar uma mensagem no console informando que é o impar.
}

Console.WriteLine("Digite um numero: ");
int num3 = int.Parse(Console.ReadLine());

if (num3 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Impar");
}*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **4. Maior de Três Números**

Receba três números e determine o maior entre eles.

Console.WriteLine("Digite o primeiro numero: "); //Esse o WriteLine ele serve para mandar uma mensagem na tela do console para o usuario, neste caso seria solicitando o primeiro numero.
int num1 = int.Parse(Console.ReadLine()); //int - Esse seria o tipo de dado da variavel; num1 - Seria o nome da variavel; int.Parse - Ta avisando que o tipo de dado vai ser o int não a string. Console.ReadLine - Ele vai ler a informação que vai ser passada pelo usuario e vai transformar ele em int ao inves de deixar em string. Sendo assim vai ser utilizado um WriteLine para solicitar o primeiro numero, criando uma variavel para guardar a informação que for passado pelo usuario, essa variavel vai ser criada com o tipo de dado int, e como vai ser um int como tipo de dado usei o int.Parse para avisar que não vai ser uma string e sim um int, e finalizei com o Console.ReadLine para ele ler a informação que for passado pelo usuario e transformar o string pelo int.
Console.WriteLine("Digite o segundo numero: "); //Esse seria o WriteLine ele serve para mandar a mensagem para a tela do console, neste caso ele esta pedindo o segundo numero.
int num2 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado; num2 - nome da variavel;int.Parse - Vai avisar que não sera uma string e sim um int a informação que usuario passar; Console.RedLine() - Ele serve para ler a informação que foi mandado pelo usuario e transformar o tipo de dado de string para int. Sendo assim foi usado um WriteLine para solicitar um segundo numero, e para salvar essa informação, criei uma variavel onde vai se chamar num2 tendo um tipo de dado int e como vai ser esse tipo de dado usei o int.Parse para avisar que não vai ser uma string e sim um int e para finalizar usei o Console.ReadLine() para ler a informação que foi passado pelo usuario e transfomar ele de string para int.
Console.WriteLine("Digite o terceiro numero: "); //Esse seria o WriteLine onde vai mandar uma na tela do console para o usuario, nesse caso ele esta solicitando o terceiro numero.
int num3 = int.Parse(Console.ReadLine()); //int - Esse seria o tipo de dado; num3 - nome da variavel; int.Parse - avisa que a informação que for passado pelo usuario vai ser um int e não uma string; Console.ReadLine - Ele le a informação que foi passada pelo usuario e transforma a mesma de string para int. Sendo assim ele usou o WriteLine para solicitar o terceiro numero, criou uma variavel chamada num3 com o tipo de dado int e como foi esse tipo de dado usei o int.Parse para avisar que vai ser um int e não uma string e finalizei com o ReadLine para fazer a leitura da informação do usuario e transformar a mesma de string para int.

int num4 = Math.Max(num1, Math.Max(num2, num3)); //int - tipo de dado; num4 - nome da variavel; Math.Max - Ele serve para verificar qual numero é maior dentro do parentese, lembrando que só pode ter duas variaveis, se passar fazer mais um Math dentro do proprio parentes; num1, num2, num3 - Esse seria as informações que o usuario passou para guardar. Sendo assim foi criado um variavel num4 com o tipo de dado int e colocou o Math.Max para verificar qual seria informação maior que o usuario vai passar, como seria 3 coloquei 1 e as outras duas coloquei dentro do Math.Max para ele analisar as duas e pegar a que for maior e analisar com que a sobrou, trazendo o resultado da maior.

Console.WriteLine(num4); // Esse seria o WriteLine onde e uma mensagem que mostra na tela do console. nesse caso ele vai mostrar qual seria o maior numero que foi colocado pelos usuarios.

Console.WriteLine("Digite o primeiro numero: "); //Esse seria o WriteLine onde vai mostrar uma mensagem no console para o usuario, nesse caso esta solicitando o primeiro numero.
int num5 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel; num5 - Seria o nome da variavel; int.Parse - Ele avisa que o tipo de dado da variavel vai ser um int e não uma string; Console.ReadLine - Ele vai ler a informação enviada pelo usuario e vai pegar ela e transfomar de string para int. Sendo assim foi criado um WriteLine para solicitar o primeiro numero, e criei uma variavel onde eu vou guardar a informação que for passada pelo usuario ela vai se chamar num5 onde e vai ter um tipo de dado int e como vai ser um numero inteiro vou avisar com o int.Parse informando que não vai ser uma string e sim uma int e finalizei com o Console.ReadLine lendo a informação que vai ser passado pelo usuario e vai transformar o tipo de dado de string para int.
Console.WriteLine("Digite o segundo numero: "); //Seria um WriteLine onde você vai mandar uma mensagem para o usuario no console, nesse caso ele esta solicitando o segundo numero.
int num6 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel; num6 - Seria o nome da variavel; int.Parse - Ele avisa que sera guardado uma informação do usuario com o tipo de dado int; Console ReadLine - Aqui ele vai ler a informação passada pelo usuario e vai transformar de string para int. Sendo assim vou usar o WriteLine para solicitar pro usuario colocar o segundo numero, e criei uma variavel chamada num6 com o tipo de dado int para guardar a informação que sera passada pelo usuario, e como o tipo de dado sera um int vou usar o int.Parse que a informação sera uma int e não uma string, e pra finalizar usei o Console.ReadLine para ler a informação passada pelo usuario e transformar ela de string para int.
Console.WriteLine("Digite o terceiro numero: "); //Esse seria o WriteLine onde vai mostrar a mensagem para o usuario no console, nesse caso ele esta solicitando o terceiro numero
int num7 = int.Parse(Console.ReadLine()); //int - Seria um tipo de dado. num7 - Seria o nome da variavel. int.Parse - Esse ele vai avisar que a informação passada pelo usuario não vai ser uma string e sim um int; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transformar o tipo de dado de string para int. Sendo assim ele vai solicitar o terceiro numero com um WriteLine, criando uma variavel chamada num7 onde vai ter um tipo de dado int ela vai guardar a informação que for passado pelo usuario e como o tipo de dado vai ser um int ele vai avisar com o int.Parse falando que não sera um string e sim um int e vai concluir com o Console.ReadLine onde ele vai ler a mensagem que for passada pelo usuario e vai transformar o tipo de dado de string para int.

if (num1 > num2 && num1 > num3) //if - Ele seria o SE for algo ele vai mandar mostrar um metodo ou uma mesagem, nesse caso SE o num1 for maior que o 2 ou 3 ele vai mostrar a variavel num1
{
    Console.WriteLine(num1); //Aqui ele usou o WriteLine que mostra uma mensagem na tela do console, nesse caso SE o if der certo vai mostrar a variavel num1
}
else if (num2 > num3 && num2 > num1) //Aqui seria o else if, como tem mais de um SE com atributos detalhados e necessario criar um ELSE IF, nesse caso ele esta informando que SE o num2 for maior que o num3 e num1 ele vai mostrar na tela a variavel num2
{
    Console.WriteLine(num2); //O Console.WriteLine ele mostra uma mensagem para o usuario no console, nesse caso SE o if der certo ele vai mostrar no console a variavel num2
}
else //Como não tem mais atributos detalhados, ele vai pegar o atributo que sobrou automaticamente, por isso não precisa especificar. Nesse caso se o num3 for maior que o num2 e o num1 ele vai mostrar na tela o num3.
{
    Console.WriteLine(num3); //O WriteLine seria uma mensagem que vai mostrar no console para o usuario ver, nesse caso se o else der certo ele vai mostrar a variavel num3.
}*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **5. Cálculo do Delta (Fórmula de Bhaskara)**

Receba os coeficientes de uma equação quadrática (ax² + bx + c = 0) e calcule o delta.

> Delta: b² - 4 * a * c
> 

**EXTRA**: Finalize toda a fórmula de Bhaskara, descobrindo x e x’ 

Console.WriteLine("Me informe o a: "); //Esse seria o WriteLine onde ele vai mandar uma mensagem no console, nesse caso ele esta solicitando que informe o A.
double a = double.Parse(Console.ReadLine()); //double - Seria um tipo dado onde vai ser um numero quebrado. a - nome da variavel. double.Parse - Ele informa que não sera uma string e sim um double. Console.ReadLine - Ele faz a leitura da informação passada pelo usuario e transforma o tipo de dado de string para int.
Console.WriteLine("Me informe o b: "); //Esse seria o WriteLine ele mostra uma mensagem na tela para o usuario, nesse caso ele esta solicitando o numero do b.
double b = double.Parse(Console.ReadLine()); //double - ele seria um tipo de dado, nesse caso ele vai guardar um numero quebrado; b - Ele seria o nome da variavel; double.Parse - Ele esta informando que a variavel não vai ser uma string e sim um double. Console.ReadLine - Ele vai ler a informação que foi passado pelo usuario e após ele ler a informação ele vai transformar o tipo de dado de string para double.
Console.WriteLine("Me informe o c: "); //Esse seria o WriteLine ele manda uma mensagem na tela para o usuario no console, nesse caso ele esta solicitando o numero c.
double c = double.Parse(Console.ReadLine()); //double - Ele seria um tipo de dado; c - nome da variavel; double.Parse - Ele esta avisando que não sera uma string e sim um double; Console.ReadLine - Aqui ele vai ler a informação que foi passada pelo usuario e vai fazer a troca do tipo de dado de string pra double

double delta = (b * b) - (4 * a * c); //double - Seria um tipo de dado; delta - nome da variavel; a, b, c - variaveis que guarda a informação pássada pelo usuario;

Console.WriteLine($"O resultado da formula delta seria {delta}"); //WriteLine mostra uma mensagem no console para o usuario, nesse caso ele mostra o resultado das variaveis acima.

Console.WriteLine("Me informe a letra a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Me informe a letra b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Me informe a letra c: ");
double c = double.Parse(Console.ReadLine());

double delta = (b * b) - (4 * a * c);

Console.WriteLine($"Segue o resultado do delta{delta}");*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **6. Calculadora Simples**

Crie um programa que recebe dois números e uma operação (+, -, *, /) e realiza o cálculo correspondente.*/

/*Console.WriteLine("Digite o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

int soma = num1 + num2;
int subtracao = num1 - num2;
int mutiplicação = num1 * num2;
int divisao  = num1 / num2;

Console.WriteLine($"O resultado da soma é {soma}, da subtração {subtracao} , da multiplicação {mutiplicação} e da divisão {divisao}");

Console.WriteLine("Digite o primeiro numero: ");//Aqui seria um WriteLine ele serve para mostrar uma mensagem no console para o usuario, nesse caso ele está solicitando 
double num3 = double.Parse(Console.ReadLine()); //double - tipo de dado da variavel; num3 - Seria o nome da variavel; doble.Parse - Esta avisando que será um double e não uma string; Console.ReadLine - Esta informando que vai fazer a leitura e vai transformar o tipo de dado para de string para double. Sendo assim foi feito um WriteLine para solicitar no console para o usuario digita o primeiro numero e criei uma variavel onde vai guardar a informação que foi passado pelo usuario, essa variavel vai ter um tipo de dado double e vai ser chamar num3 e como vai ser um tipo de dado double usei o double.Parse pra avisar que não vai ser uma string e sim um double e vou concluir com o Console.ReadLine() - onde ele vai ler a informação do usuario e vai transformar de string para double.
Console.WriteLine("Digite o segundo numero: "); //Esse seria o WriteLine ele mostra uma mensagem para o usuario no console, nesse caso ele esta solicitando o segundo numero.
double num4 = double.Parse(Console.ReadLine()); //double - Ele seria um tipo de dado da variavel; num4 - Seria o nome da variavel; double.Parse - Aqui ele vai avisar que vai ter o tipo de dado double e não a string; Console.ReadLine - Ele faz a leitura e transforma de string para double. Sendo assim ele usou o WriteLine onde ele vai mandar uma mensagem solicitando o segundo numero, criando uma variavel onde ele vai guardar a informação que o usuario passar, a variavel vai ser chamar num4 onde ela vai ter um tipo de dado Double, e como o tipo de dado vai ser double, vou ter que avisar com o int.Parse e concluindo com o Console ReadLine para ler a informação que vai ser passada pelo usuario e vai transforma de string para double.
Console.WriteLine("Digite o operador lógico"); //WriteLine serve para entregar uma mensagem para o usaurio, nesse caso ta solicitando um operador logico para fazer a conta.
char operador = char.Parse(Console.ReadLine()); //char - Seria tipo de dado da variavel; operador - Seria o nome da variavel; char.Parse - Iria avisar que a informação que for enviada pelo usuario, vai ser um char e não um string; Console.ReadLine - Aqui ele vai ler a informação enviada pelo usario e vai transformar o string em char. Sendo assim criou um Console.WriteLine para solicitar o operador logico para o usuario no console, e foi criado uma variavel para guardar a informação do usuario, onde a variavel se chamada operador com o tipo de dado char e usei o char.Parse para avisar que a variavel vai ter um tipo de dado char e não uma string e conclui com o Console.ReadLine para ele fazer a leitura da informação do usuario e vai fazer a transformação da string para char.

double resultado = 0; //double - Esse seria o tipo de dado; resultado - seria o nome da variavel. Por que seria uma variavel que não tem informação, por que ela vai ser utilizada para ganhar a informação no if, para quando o usuario colocar os numeros e a operação logica ele fazeria a conta com o if e o resultado seria o que foi informado no resultado.

if (operador ==  '-') //if - Ele seria o SE for aquilo que foi informado no parametro ele vai mostrar um metodo ou uma mensagem; () - Seria o parametro; operador - Seria o operador que foi informado pelo usuario; == - Esse esta informando SE for igual, nesse caso ele esta informando que se o operador logico for igual o '-'; '-' - Esse seria o char um operador logico, esta '' por que ele seria uma caracter.
{
    resultado = num3 - num4; //resultado - Seria a variavel sem informação; num3 e num4 - Seria a variavel que guarda as informações do usuario. Sendo assim o resultado vai ser a resposta da conta das variaveis que guarda a informação dos usuarios e vai mostrar a resposta.
}
else if (operador == '+') // else if - Seria um segundo if e só vem como else por questão de nomenclatura; operador - Seria a variavel que o usuario vai informar que seria o operador logico da conta; == - Ele seria SE for igual ao que esta informando no paramentro; '+' - Esse seria o operador logico, '' e ta assim por que seria um caracter. Sendo assim usei um if pra caso SE for um operador logico + ele vai dar o resultado dentro da {}.
{
    resultado = num3 + num4; // resultado - Seria a variavel vazia para pegar a conta criada por conta do if; num3 e num4 - Seria as variaveis que guarda as informações do usuario; 
}
else if (operador == '*') //else if - Ele seria igual o if, mas colocar else if por questao de nomenclatura; operador - seria a variavel que vai ser informada pelo usuario; == - Seria o igual; '*' - Seria o operador logico, tem o '' por que ele seria o caracter; () - Esse seria o parametro.
{
    resultado = num3 * num4; //resultado - Seria a variavel vazia, que vai receber o valor no else if; num3 e num4 - Seria as variaveis que vão guardar as informações do usuario; 
}
else if (operador == '/') //else if - Seria a mesma coisa que o if, só esta com esse nome por conta da nomenclatura; () - O que vai dentro seria o parametro do else if; operador - Seria o nome da variavel que vai guardar o operador logico pelo usuario; == - Ele serve para falar se for igual, vai seguir esse parametro; '/' - Esse seria o caracter que vai ser colocado pelo usuario no operador, '' esta com esse aspas por conta que é um caracter;
{
    resultado = num3 / num4; //resultado - Seria a variavel vazia que vai receber a conta que foi feita no else if, se for o parametro ele vai receber o resultado; num3 e num4 - Seria a variavel que vai guardar as informações do usuario; 
}
else //else - ele ja é diferente do if e do else if ele ja pega qualquer informação diferente do que foi informado nos parametros anteriores e usa como parametro .
{
    Console.WriteLine("Operador inválido."); //Aqui se a informação for diferente ele vai informar que o operador e invalido. 
}

    Console.WriteLine($"Segue o resultado {resultado} "); //Aqui vai mostrar a variavel vazia que foi criada para o else if ou if que for usado o parametro.

Console.WriteLine("Me informe o primeiro numero: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Me informe o operador lógico: ");
char operador1 = char.Parse(Console.ReadLine());

if (operador1 == '+')
{
    resultado = num1 + num2;
}
else if (operador1 == '-')
{
    resultado = num1 - num2;
}
else if (operador1 == '*')
{
    resultado = num1 * num2;
}
else if (operador1 == '/')
{
    resultado = num1 / num2;
}
else
{
    Console.WriteLine("Informou o operador lógico errado!");
}

Console.WriteLine($"E o resultado seria {resultado}");*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **7. Ano Bissexto**

Crie um programa que recebe um ano e verifica se ele é bissexto.
 * https://learn.microsoft.com/pt-br/office/troubleshoot/excel/determine-a-leap-year

> Qualquer ano que seja uniformemente divisível por 4 é um ano bissexto: por exemplo, 1988, 1992 e 1996 são anos bissextos.
> 

> No entanto, ainda há um pequeno erro que deve ser contabilizado. Para eliminar esse erro, o calendário gregoriano estipula que um ano que é uniformemente divisível por 100 (por exemplo, 1900) é um ano bissexto apenas se também é igualmente divisível por 400.
>

using System.ComponentModel.Design;

Console.WriteLine("Me informe o ano: "); //Usei o Console.WriteLine para mandar uma mensagem no console para o usuario, nesse caso usei para solicitar o ano.
int ano = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel; ano - Seria o nome da variavel; int.Parse - Aqui esta avisando que não sera uma string e sim um int; Console.ReadLine - Ele le a informação passada pelo usuario e transforma de string para int. Sendo assim utilizei o console WriteLine para comunicar o usuario para informar o ano, apos isso criei uma variavel com o nome de ano e usando o tipo de dado int, como vai ser um int usei o int.Parse para informar que não sera uma string e sim um int e pra finalizar eu usei o ReadLine para ler a informação do usuario e transformar de string para int.


if (ano % 4 == 0 && ano % 100 == 0 && ano % 400 == 0) //if - Ele seria o SE, SE o paramentro for esse, ele vai retornar uma mensagem ou um metodo; () - Seria o parametro; ano - Seria o nome da variavel que guarda a informação do usuario; % - Ele informa se o resto da divisão de 1 ou 0, usamos para verificar se o numero e divisivel pelos numeros informados; && - Ele seria "E" ele acaba acresentando algo no paramento, podendo ser um novo if ou um novo parametro; Sendo assim utilizei esse if para verificar se o ano passa pela a primeira etapa, se o ano for divisivel por 4, 100 e 400 ele seria um ano bissexto.
{
    Console.WriteLine("O ano é bissexto.") ; //Console.WriteLine - Caso seja esse paramentro ele vai retornar essa mensagem.
}
else if (ano % 4 > 0) //else if - Ele seria a mesma coisa que o if, só que tem que usar ele como segundo, terceiro ... por questão de nomenclatura; () - Seria o parametro do else if; ano - Seria o nome da variavel que vai guardar a informação do usuario; % - Ele dividi o numero informado e entrega o resto da divisão, se for 1 vai ser um numero quebrado e se for 0 vai ser um numero inteiro; > - Seria se o numero for maior que o outro. Sendo assim esta usando um segundo if, por isso else if onde ele esta informando se o ano não for divisor por 4 e o resto der maior que 0 ele vai lançar uma mensagem informando que ele ano não e um ano bissexto.
{
    Console.WriteLine("O ano não é bissexto."); //Console.WriteLine - Seria uma mensagem que manda no console para o usuario, nesse caso se for esse parametro ele vai mandar que o ano não Bissexto.
}
else if (ano % 4 == 0 && ano % 100 > 0) //else if - Seria igual o if, mas como é um segundo if ele tem que esta escrito dessa forma por questão de nomenclatura; () - Esse seria o parametro do else if, ele informa SE for aquilo ele vai lançar um metodo ou mensagem; ano - Seria a variavel que vai guardar a informação que foi passado pelo usuario; % - Ele seria um operador logico onde vai dividir e o resultado dele é o resto da divisão retornando 1 ou 0 sendo 1 quebrado e 0 inteiro; == - Esse seria o igual, SE aquela variavel for igual o numero tal; && - Seria o e da operação podendo acrescentar variaveis ou contas; > - Ele seria o maior; Sendo assim foi criado o else if para informar se passar da primeira etapa que seria ano é divisor por 4 se for ele vai pra segunda etapa, que seria ser divisor de 100 se ele não for ele é ano bissexto.
{
    Console.WriteLine("O ano é bissexto."); //Console.WriteLine - Ele serve para mandar uma mensagem na tela do console para o usuario, nesse caso ele vai informar que o ano é bissexto.
}
else if (ano % 4 == 0 && ano % 100 == 0 && ano % 400 > 0)//else if - Ele é igual o if mas ele tem esse nome por que ele seria o segundo if, como vai ser o segundo if ele tem que ter esse nome por questão de nomenclatura; () - Seria o parametro do else if, informando SE for esse parametro ele vai mostrar um metodo ou uma mensagem; ano - Seria a variavel que guarda a informação do usuario; % - Ele é um operador logico que pega o resto da divisão pegando o 1 sendo quebrado ou 0 que numero inteiro; == - Seria o de igual; && - Ele seria o E onde ele pode acrescentar mais uma variavel; > - Esse seria o operador de logica que seria o maior;
{
    Console.WriteLine("O ano não é bissexto."); //Esse seria o Console.WriteLine onde ele vai mostrar uma mensagem na tela do console, nesse caso ele vai mandar que não vai ser um ano bissexto;
}

Console.WriteLine("Informe o ano: "); //Console.WriteLine ele manda uma mensagem na tela do console, nesse caso esta solicitando um ano para o usuario.
int ano1 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel; ano1 - Seria o nome da variavel; int.Parse - Ele informa que vai ser um int e não uma string; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transforma de string para int; Sendo assim criou um WriteLine para solicitar o ano para usuario, guardando a informação do usuario com a variavel chamada ano1 com o tipo de dado int e como vai ser um int avisei com o int.Parse informando que vai ser um int e não uma string, e finalizei com o console.ReadLine elçe vai fazer a leitura e vai transformar de string para int.

if((ano1 % 4 == 0 && ano1 % 100 != 0) || (ano % 400 == 0)) //if - Ele seria o SE, SE for aquilo que foi informado no parametro ele vai retornar uma mensagem ou um metodo; () - Seria o parametro; ano1 - variavel que vai guardar as informações do usuario; % - Ele seria um operador lógico onde ele vai dar o resto da divisão onde vai vim um 1 que seria numero quebrado ou 0 que seria numero inteiro; && - Ele seria o E, usado para acrescentar algo no parametro;!= Ele informa que se for diferente ao numero informado; || - Ele seria o ou, ele serve para dar uma segunda opção para as coisas; Sendo assim foi criado o if com dois parametros, o primeiro seria se o ano for divisor de 4 e não de 100 ele vai retornar que é bissexto e no segundo paramentro ele esta informando que se o ano for divisor por 400 ele vai retornar que é ano bissexto;
{
    Console.WriteLine("O ano é bissexto."); // Console.WriteLine - Ele serve para mandar uma mensagem na tela do console para o usuario, nesse caso ele vai informar que o ano é bissexto.
} 
else // O else ele vai pegar qualquer informação diferente do parametro informado anteriormente, então esse seria o parametro dele retornando uma mensagem ou metodo.
{
    Console.WriteLine("O ano não é bissexto."); //Esse seria o Console.WriteLine onde ele vai mandar uma mensagem para o usuario no console, nesse caso ele vai informar que o ano não é bissexto.
}
Console.WriteLine("Me informe o ano: ");
int ano2 = int.Parse(Console.ReadLine());

if ((ano2 % 4 == 0 && ano2 % 100 != 0) || (ano2 % 400 == 0))
{
    Console.WriteLine("Seria o ano bissexto");
}
else
{
    Console.WriteLine("Não seria um ano bissexto");
}*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **8. Triângulo Válido e Tipo**

Receba três valores numéricos e verifique se eles podem formar um triângulo. Caso possam, determine se ele é equilátero, isósceles ou escaleno.

Console.WriteLine("Me informe o primeiro numero: "); //Esse seria um Console.WriteLine onde ele vai lançar uma mensagem para o usuario, nesse caso ele esta solicitando o primeiro numero;
int num1 = int.Parse(Console.ReadLine()); //int - Esse seria um tipo de dado da variavel; num1 - Seria nome da variavel; int.Parse - Ele avisa que não vai ser um string e sim um int; Console.ReadLine - Ele vai ler a informação do usuario e vai transformar essa informação de string para int. Sendo assim ele criou um WriteLine para o usuario informar o primeiro numero e criou uma variavel chamada num1 onde vai ter um tipo de dado int e como vai ser um int vou usar o int.Parse onde ele vai avisar que não é uma string e sim um int, usando o Console.ReadLine onde vai ler a informação passada pelo usuario e vai transformar de string para int.

Console.WriteLine("Me informe o segundo numero: "); //Console.WriteLine onde ele manda uma mensagem na tela para o usuario, nesse caso é solicitando o segundo numero.
int num2 = int.Parse(Console.ReadLine()); //int - Esse seria um tipo de dado da variavel; num2 - seria o nome da variavel; int.Parse - Ele esta avisando que vai ser um int e não uma string; Console.ReadLine() - Ele vai ler a informação passada pelo usuario e vai transformar de string para int;

Console.WriteLine("Me informe o terceiro numero: "); //Console.WriteLine - Ele manda uma mensagem na tela do console, nesse caso ele esta informando o terceiro numero;
int num3 = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado; num3 - Seria o nome da variavel; int.Parse - Aqui ele esta avisando que vai ser um int e não uma string; Console.ReadLine() - Ele vai ler a informação e vai transformar de string para int;


if ((num1 + num2 > num3) || (num1 + num3 > num2) || (num2 + num3 > num1)) // if - Ele seria o SE, SE for o parametro informado ele vai retornar uma mensagem ou um metodo; () - Seria o parametro; num1, num2 e num3 - Seria as variaveis que vai guardar as informações que o usuario passou; || - Seria OU onde você pode dar outras opções de variaveis; Aqui ele esta verificando se é um triangulo ou não;
{
    if (num1 == num2 && num2 == num3) //if - O if seria o SE, SE for o parametro ele vai retornar o metodo ou uma mensagem; () - Seria o paramentro;num1, num2 e num3 - Seria a variavel que vai guardar as informações passadas pelos usuarios; == - Sinal de igual; && - Esse seria o E ele acrescenta um parametro;
    { Console.WriteLine("Ele é um triangulo Equilátero"); } // Aqui seria o WriteLine, onde ele vai retornar a mensagem se for esse parametro;

    else if(num1 == num2 || num2 == num3 || num2 == num3) //else if - Ele seria o segundo if, ele tem a mesma função do if, ele tem esse nome por conta da nomenclatura; () - Parametro; num1, num2 e num3 - Seria as variaveis que guarda as informações que o usuario passou; || - Esse seria o OU;
    {Console.WriteLine("Ele é um triangulo Isósceles");} //Esse mostra uma mensagem na tela;

    else { Console.WriteLine("Ele é um triangulo escaleno"); } //Ele vai pegar todas informações que vai diferente dos parametros acima e vai retornar a mensagem;
}
else  // else - Ele pega todas informações que são diferentes do parametro acima, e retorna um metodo ou uma mensagem 
{
    Console.WriteLine("Os valores não formam um triangulo."); // Ele seria o writeLine onde ele vai mostrar a mensagem na tela do console;
}*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **9. Classificação de Nota**

Receba uma nota e classifique-a conforme a seguinte tabela:

-**A * *(90 - 100)
- **B * *(80 - 89)
- **C * *(70 - 79)
- **D * *(60 - 69)
- **F * *(menor que 60)

Console.WriteLine("Me informe a nota: "); //Console.WriteLine - Ele lança uma mensagem no console para usuario, nesse caso ele esta solicitando a nota 
double num1 = double.Parse(Console.ReadLine()); //double - Seria o tipo de dado da variavel; num1 - Esse seria o nome da variavel; double.Parse - Aqui ele está avisando que não sera uma string e sim um int; Console.ReadLine - Ele vai fazer a leitura da variavel num1 e vai transformar de string para int; Sendo assim foi criado um WriteLine para solicitar a nota para o usuario, e informação vai ser guardada na variavel num1 onde tem o tipo de dado double e como vai ser double usei o double.Parse pra avisar que não vai ser um string e sim uma double e finalizei com Console.ReadLine para ler a informação e transforma de string para double.


if(num1 < 0 || num1 > 100) //if - Seria o SE, SE o usuario mandar dentro do parametro ele vai retornar um metodo ou uma mensagem. num1 - Seria a variavel que guardou a informação do usuario. Esse esta informando que as notas só pode ir do 0 ao 100, se passar ou for menor que 0 ele vai dar erro.
{
    Console.WriteLine("Essa nota não existe"); //Esse seria o WriteLine onde manda mensagem no console, sendo assim ele vai mandar uma mensagem de erro nesse caso.
}
else if (num1 >= 90) //else if - Ele seria a mesma coisa que o if, só que tem o nome diferente por conta da nomenclatura do segundo em diante dos if. Nesse caso ele esta informando que se a informação do usuario for entre o 90 ao 100 ele vai mandar uma mensagem informando que será uma nota A.
{
    Console.WriteLine("Sua nota é A"); //WriteLine - Seria uma mensagem no console, nesse caso ele vai informar que a nota é A.
}
else if (num1 >= 80) //else if - Ele seria a mesma coisa que o if, mas como ja existe um if por questão de nomenclatura ele se chama else if. Nesse caso ele esta com um parametro informando que entre o 80 e 90 a nota será B.
{
    Console.WriteLine("Seua nota é B"); //Esse seria o WriteLine que manda uma mensagem no console. Nesse caso vai informar que a nota vai ser B
}
else if (num1 >= 70) //else if - ele é a mesma coisa que o if, mas como ja tem um a nomenclatura muda para else if. No parametro esta informando que se a informação passada pelo usuairo for um numero de 70 a 80 vai ser nota C.
{
    Console.WriteLine("Sua nota é C"); //WriteLine - Seria uma mensagem que manda para o console. E nesse caso ele vai informar que vai ser nota C.
}
else if (num1 >= 50) //else if - Ele seria a mesma coisa que o if, mas como ja existe um if por questão da nomenclatura ele tem que ser chamado de else if. Nesse caso ele tem o parametro informando que a informação do usuario for 50 a 70 ele vai mandar uma nota D.
{
    Console.WriteLine("Sua Nota é D"); //WrtieLine seria uma mensagem que manda para o usuario. Nesse caso ta informando que a nota vai ser D.
}
else if (num1 >= 40) //else if - Seria igual o if, mas como ja tem um if por questão de nomenclatura tem que se chamar assim. Dentro do parametro ele esta informando que a informação do usuario for de 40 a 50 vai ser nota F
{
    Console.WriteLine("Sua Nota é F"); //WriteLine - Seria uma mensagem no console, nesse caso ele vai mandar que é uma nota F
}
else //O else ele vai pegar as informações que não foi passada nos outros parametros. Nesse caso informações abaixo de 40 até 0 vai ser nota F.
{
    Console.WriteLine("Sua Nota é F"); //WriteLine - Seria uma mensagem para o usuari no console, nesse caso informou que a nota é F.*/
}
