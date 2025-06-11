/*1. **Soma de dois números**
    
    Escreva um programa que recebe dois números e imprime a soma deles.
 * 
 * Console.WriteLine("Digite o primeiro número:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero:");
int num2 = int.Parse(Console.ReadLine());

return num + num2;


Console.WriteLine("Informe o primeiro numero:"); //Console.WriteLine - ele manda um texto para o usuario, nesse caso ele manda um texto solicitando o primeiro número.
int num3 = int.Parse(Console.ReadLine()); //int - Esta informando que a resposta sera um numero inteiro; num3 - Seria a informação que será guardada, assim que o usuario informar o numero; int.Parse - Como o WriteLine só pode retorna string que seria texto, ele coloca o .Parse para que informe que daqui pra frente o que o usuario informar vai ser um número inteiro; Console.ReadLine - Esse ele vai fazer com que o console leia a informação passada pelo o usuario e guarde aquela informação. Ao todo ele esta criando uma variavel onde ele vai guardar a informação que o usuario passar no num3

Console.WriteLine("Informe o segundo numero:"); //Console.WriteLine - Esse aqui faz com que o console lance um texto para o usuario responder, aqui ele esta pedindo o segundo numero.
int num4 = int.Parse(Console.ReadLine()); //int - Esta informando que o dado que sera guardado sera um numero inteiro; num4 - Seria onde sera guardado aquele numero inteiro que foi informado pelo usuario; in.Parse - Ele esta informando que o numero não vai vim como uma string e sim vai vim como um numero inteiro; Console.ReadLine() Ele vai le e guardar a informação que foi passada pelo usuario. Sendo assim ele esta criando uma variavel num4, para guardar a informação que for passado pelo o usuario.

return num3 + num4; //return - Aqui ele vai finalizar a conta, ele vai pegar os dois dados que foi informado e vai fazer a soma dos dois, e vai retornar o resultado.*/

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*2. Produto de dois números
    
    Escreva um programa que recebe dois números e imprime o produto deles.
 * 
 * 
 * Console.WriteLine("Informe o primeiro numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

return num1 / num2;

Console.WriteLine("Me informe o primeiro numero: "); //Console.WriteLine - Ele vai lançar uma informação para o usuario no console, aqui ele vai perguntar o numero para o usuario.
int num3 = int.Parse(Console.ReadLine());//int - A informação que o usuario mandar sera um numero inteiro; num3 - Aqui ele vai guardar a informação que o usuario passar; int.Parse - Aqui ele esta informando que a informação do WriteLine não vai ser uma string e sim um numero inteiro.

Console.WriteLine("Me informe o primeiro numero:"); //Console.WirteLine - Ele vai lançar uma mensagem no console para o usuario, nesse ele esta pedindo o segundo numero.
int num4 = int.Parse(Console.ReadLine()); //int - Aqui esta informando que vai ser guardado um numero inteiro; num4 - Esse seria onde será guardado a informação, que seria o nome da variavel; int.Parse - Aqui esta informando que não sera uma srting e sim um numero inteiro; Console.ReadLine - Aqui ele esta informando que será feito uma leitura e sera guardado a varivel. Sendo assim Esta sendo criado uma mensagem usando WriteLine para o usuario, apos o usuario mandar a informação que tera que ser um numero inteiro, ele vai guardar na varivel num3 e sera feito com o int.Parse a conversão de string para int e no ReadLine vai ser feito a leitura da informação e sera guardada a mesma.

return num3 / num4; //Aqui ele vai retornar a divisão, e vai retornar a resposta para o console.*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*3. Diferença
    
    Escreva um programa que recebe dois números e imprime a diferença entre eles.
 * 
 * 
 * Console.WriteLine("Informe o primeiro numero:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero:");
int num2 = int.Parse(Console.ReadLine());

return num1 - num2;

Console.WriteLine("Me informe o primeiro numero:"); //Console.WriteLine - Aqui esta informando que vai ser lançado uma mensagem, nesse ele esta pedindo que informe o primeiro numero
int num3 = int.Parse(Console.ReadLine()); //int - Aqui eles está informando o que sera informado pelo usuario sera um numero inteiro; num3 - Aqui ele está informando que o numero que sera informado pelo usuario vai ser guardado aqui; int.Parse - Aqui ele esta informando o que sera lançado pelo usuario sera um numero inteiro e não uma string; No Console.ReadLine ele vai ler a informação passada pelo usuario e vai guardar essa informação. Sendo assim aqui ele vai mandar uma mensagem para o usuario solicitando o primeiro numero, vai criar uma variavel onde ele vai guardar a informação do usuario sendo o int num3, e vai informar que a informação que sera passada pelo usuario sera um numero inteiro e não uma string usando o int.Parse e no Console.ReadLine ele vai ler a informação que será guardada e vai guardar essa informação dentro da variavel.

Console.WriteLine("Informe o segundo numero: "); //Console.WriteLine ele vai lançar uma mensagem para o usuario, nesse caso ele vai solicitar o segundo numero.
int num4 = int.Parse(Console.ReadLine()); //int - Aqui ele esta informando que o numero que sera informado pelo usuario sera um numero inteiro. num4 - Aqui seria o nome da variavel. int.Parse - Aqui ele esta informando que não sera uma string e sim um numero inteiro. Console.ReadLine() - Aqui ele vai ler a informação e vai guardar na variavel num4. Sendo assim ele esta criando uma mensagem para o usuario solicitando o segundo numero. Onde ele vai guardar essa informação na variavel num4, e a resposta como vai ser em numero inteiro ele vai informar que a resposta não sera uma string e sim um numero inteiro usando o int.Parse. E no Console.ReadLine ele esta informando que a informação que for passada vai ser lida e guardada

return num3 - num4;//Aqui ele vai retornar a diferença entre os numeros.*/

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*1. Média de três números
    
    Escreva um programa que recebe três números e imprime a média aritmética deles.
 * 
 * Console.WriteLine("Me informe o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int num4 = num1 + num2 + num3;

int num5 = 3;

return num4 / num5;

Console.WriteLine("Me informe o primeiro numero:"); //No Console.WriteLine ele esta mandando uma mensagem no console solicitando o primeiro numero 
int num6 = int.Parse(Console.ReadLine()); //int - Esta informando que a variavel que será guardada vai ser um numero inteiro; num 6 é o nome da variavel; int.Parse - onde sera informado para o console que o numero que sera lançado pelo usuario vai ser um numero inteiro; Console.ReadLine - Aqui ele vai ler a informação que for passado pelo usuario e vai guardar essa informação. Sendo assim ele vai usar o WriteLine para lançar uma mensagem no console solicitando o primeiro numero, vai criar uma variavel chamada de num6 onde sera um numero inteiro, como vai ser um numero inteiro ele vai usar o int.Parse para informar que não sera usado uma string e sim um numero inteiro e vai finalizar utilizando o Console.ReadLine para informar que vai ser lido e guardado a informação que for passada pelo usuario.

Console.WriteLine("Me informe o segundo numero:"); //No Console.WriteLine ele manda uma mensagem no console, nesse caso ele esta solicitando o segundo numero para o usuario.
int num7 = int.Parse(Console.ReadLine());//int - Esa informando que o numero que será guardado pela variavel será um numero inteiro; num7 - Aqui ele esta informando que o nome da variavel sera o num7. int.Parse - Está informando para o console que o usuario vai mandar um numero inteiro e não uma string. Console.ReadLine() - Aqui está informando que ele vai ler a informação e vai guardar ela na variavel. Sendo assim que ele vai criar um WriteLine para mandar uma mensagem solicitando o segundo numero, vai informar que vai ser criado uma variavel chamada num7 onde sera um numero inteiro, e como o WriteLine só aceita string ele vai usar o int.Parse para informar que não sera uma string e sim operador int de numero inteiro e vai finalizar usando o ReadLine para ler a informação passada pelo usuario e guardar a mesma. 

Console.WriteLine("Me informe o terceiro numero:"); //No Cosole.WriteLine ele vai lançar uma mensagem no console, nesse caso ele vai solicitar o terceiro numero.
int num8 = int.Parse(Console.ReadLine()); // int - Ele esta informando que a variavel será um numero inteiro. num8 - Sera o nome da variavel. int.Parse - Vai informar para o console que a resposta do usuario vai ser int e não uma string. Console.ReadLine() - Aqui esta informando que sera lido a informação e guardada. Sendo assim ele criou um WriteLine para informar que precisa do terceiro numero, criando uma variavel chamada num8 onde vai ser guardado um numero inteiro, como o numero vai ser guardado o numero inteiro foi utilizado o int.Parse para informar que o usuario não vai lançar uma string e sim um numero inteiro, onde o Console.ReadLine() vai ler a informação e vai guardar na variavel.

int num9 = num6 + num7 + num8; //Aqui foi criado um uma variavel para fazer a soma total de todos os numeros que foram passado pelo usuario

int num10 = 3; //Aqui foi criado uma variavel para guardar o numero 3 e utilizar futuramente para fazer a divisão da soma total dos numeros e saber qual seria a media.

return num9 / num10; //Aqui ele vai retornar a divisão do numero total com o numero 3 para retornar a media dos numeros.*/
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*2.Resto da divisão
    
    Escreva um programa que recebe dois números e imprime o resto da divisão do primeiro pelo segundo.

Console.WriteLine("Me informe o primeiro numero: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
double num2 = double.Parse(Console.ReadLine());

double num3 = num1 % num2;

Console.WriteLine("O resto da divisão é:" + num3);

Console.WriteLine("Me informe o primeiro numero:"); //No Console.WriteLine ele vai mandar uma mensagem no console, nesse caso ele vai solicitar o primeiro numero;
double num4 = double.Parse(Console.ReadLine());// Double esse é o operador logico para o usuario ter liberdade de guardar informação quebrada também, num4 - Aqui seria o nome da variavel onde ele vai guardar a informação passada pelo o usuario. double.Parse - Aqui esta informando que o numero que sera informado pelo usuario sera um numero inteiro ou quebrado e não uma string. Console.ReadLine - Esta informando que a informação que será passada pelo usuario sera lida e guardada na variavel num4. Sendo assim Foi criado um WriteLine onde ele vai lançar uma mensagem solicitando o primeiro numero, depois vai criar uma variavel chamada num4 onde ele vai guardar um numero quebrado ou inteiro, como o numero vai double, tive que usar o double.Parse onde eu vou informar que ser um double que o usuario vai informar e não uma string e finalizo com o Console.ReadLine() onde ele vai ler a informação e vai guardar na variavel.

Console.WriteLine("Me informe o segundo numero:"); //No console.WriteLine ele vai lançar uma mensagem para o usuario no console, nesse caso ele vai solicitar um segundo numero.
double num5 = double.Parse(Console.ReadLine()); //No double ele esta informando que sera guardado um numero quebrado. num5 - Aqui esta informando o nome da variavel. double.Parse - E aqui que ele informa que a informação que será guardada na variavel sera um numero quebrado e não uma string; Console.ReadLine() - É onde ele vai ler a informação passada pelo o isiarop e vai guardar essa informação. Sendo assim ele vai criar uma mensagem e mostrar na tela usando o WriteLine solicitando o segundo numero, criando uma variavel chamada num5 onde vai informar que sera um double onde sera um numero quebrado que vai ser informado pelo usuario, como o numero sera double vai ter que colocar um double.Parse onde ele vai informar que a informação que o usuario passar pode ser um numero quebrado e não uma string e para finalizar ele vai usar o ReadLine onde ele vai ler as informação que foi passada e vai guardar na variavel.

double num6 = num4 % num5; //Aqui ele vai criar uma variavel onde ele vai fazer uma conta onde vai informar o resto da divisão dos numeros que foram passados pelo o usuario.

Console.WriteLine("Segue o resto da divisão" + num6); //Aqui criou um WriteLine para mandar o resultado do num6 na tela, e ele esta concatenando para acrescentar a informação da variavel num6.*/

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*Troca de valores sem variável auxiliar
    
    Escreva um programa que troca os valores de duas variáveis sem usar variável auxiliar.*/

/*Console.WriteLine("Me informe o primeiro numero:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Me informe o segundo numero:");
int num2 = int.Parse(Console.ReadLine());


num1 = num1 + num2; //3 num1
num2 = num1 - num2; //2 num2
num1 = num1 - num2; //1 num1

Console.WriteLine($"O pimeiro numero seria {num1} e o segundo seria {num2}"); 

Console.WriteLine("Me informe o primeiro numero:");//No Console.WriteLine vou mandar uma mensagem para o usuario, nesse caso vou solicitar o primeiro numero 
int num3 = int.Parse(Console.ReadLine()); //int - informando que a variavel sera um numero inteiro; num3 - Esse seria o nome da variavel; int.Parse - Esse esta informando que a informação passado pelo usuario não sera uma string e sim uma int; Console.ReadLine - Aqui ele vai ler o que foi passado pelo usuario e vai guardar essas informações. Sendo assim ele criou uma variavel que sera numero inteiro e como vai ser int usou o int.Parse para fazer a troca da string para o int, usando o Console.ReadLine para ler e guardar a informação.
Console.WriteLine("Me informe o segundo numero:"); //No Console.WriteLine ele vai mandar uma mensagem no console, nesse caso ele vai solicitar que o usuario informe o sengundo numero.
int num4 = int.Parse(Console.ReadLine()); //int - Esta informando que a informação que sera guardada vai ser um numero inteiro; num4 - Esse seria o nome da variavel; int.Parse - Esse ele esta informando que a informação que sera passada pelo usuario não vai ser uma string e sim uma int que seria o numero inteiro. Sendo assim usei o Console.WriteLine para mandar uma mensagem para o usuario solicitando o segundo numero, criei a variavel em operador logico int, como a variavel sera uma operador logico int precisei usar o int.Parse pra informar que a informação passada pelo usuario e sim por int, e usamos a readLine() para salvar e guardar a inforamção que fi passada.

//teste: num3 - 1 num4 - 2

num3 = num3 + num4; //Aqui eu fiz a soma dos dois, para que o num3 seja substitudo pelo num4, mas aqui eu não faço a substituição ainda 
num4 = num3 - num4; //Aqui eu fiz a subtração para que faça a substituição do num3 para o num4, o que vai acontecer o num3(1) de começo depois ficou num3(3), com essa subtração o num4 vai ficar num4(1), por que vai ser num4(2) - num3(3) = transformando o num4 de (3) para (1)
num3 = num3 - num4; //Aqui ele vai transformar o num3(3) em num3(2), Como o num4 ta valendo (1), quando ele for fazer a subtração de num3(3) - num4(1) vai ficar num3(2), fazendo a troca sem vairavel auxiliar.

Console.WriteLine($"O primeiro numero seria {num1} e o segundo {num2}"); //Aqui ele vai usar o Console.WriteLine para mostrar a troca na tela.*/
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*2.Par ou Ímpar(utilizando operadores de comparação e aritméticos)


    Escreva um programa que recebe um número e imprime `1` se for par e `0` se for ímpar.*/

using System;

/*Console.WriteLine("Me informe o primeiro numero:");
int num1 = int.Parse(Console.ReadLine());

int num2 = num1 % 2;

if (num2 == 1)
{
    Console.WriteLine("0 - sendo o impar");
}
else
{
    Console.WriteLine("1 - sendo o par");
}

Console.WriteLine("Me informe um numero: "); //Aqui esta sendo usando o Console.WriteLine para mandar uma mensagem na tela, nesse caso esta solicitando para o usuario digitar um numero.
int num3 = int.Parse(Console.ReadLine()); //int - Aqui esta informando que a variavel vai ser um int; num3 - Nome da variavel; int.Parse - Ele esta sendo usado para quando o usuario mandasse a informação, avisar o c# que não ser uma string e sim um int; Console.ReadLine() - Esse serve para leia a informação passada pelo usuario e guarde a mesma. Sendo assim usou o WriteLine para mandar uma mensagem de digite qualquer numero e depois criamos uma variavel aonde sera guardado um numero inteiro, por ser um numero inteiro usamos o int.Parse para informar que a informação passada pelo usuario não sera uma string e sim um int, e usamos o Console.ReadLine() para ler a informação passada e guardar a mesma. 

int num4 = num3 % 2; //int - informando que foi criado uma variavel numero inteiro; num4 - é o nome da variavel; num3 - É a variavel que guardou a informação passada pelo usuario; % 2 - Esta informando se na divisão der numero quebrado você me volta 1 se não der vai me voltar 0, ele vai pegar o resto da divisão. Sendo assim fez essa variavel em int chamada num4 para caso a conta reste 1 na divisão ou 0 para utilizar a mesma no if.

if (num4 == 1) //Aqui está sendo usado o if, onde ele vai usar a variavel num4 para caso a conta reste 1 ela vai ser 0 - impara
{
    Console.WriteLine("0 - seria o impar"); //Usei um WriteLine para mandar uma mensagem na tela, 0 - seria o impar.
}
else //Aqui usei o else para informar caso de um numero diferente de 1 vai ser par, como o resto só da 1 ou 0 facilitou na utilização do else.
{
    Console.WriteLine("1 - seria o par"); //Usei o WriteLine para mandar uma mensagem na tela do console que o numero seria par.
}*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*3.Valor máximo entre três números (usando operadores de comparação)
    
    Escreva um programa que recebe três números e imprime o maior deles sem utilizar if/else ou laços de repetição.*/

Console.WriteLine("Me informe o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Me informe o terceiro numero: ");
int num3 = int.Parse(Console.ReadLine());

int maior = Math.Max(num1, Math.Max(num2, num3));

Console.WriteLine(maior);

Console.WriteLine("Digite o primeiro numero: "); //Esse é o WriteLine onde vai mandar uma mensagem no console, nesse caso ele vai pedir para digitar o primeiro numero.
int num4 = int.Parse(Console.ReadLine()); //int - Ele seria o operador logico da variavel; num4 - Seria o nome da variavel; int.Parse - Ele serve para informar o que ser digitado pelo usuario não sera uma string e sim um int; Console.ReadLine() - Ele vai ler a informação passada pelo usuario e vai guardar a mesma. Sendo assim ele criou um WriteLine para mandar na tela o que o usuario precisa digitar que seria o primeiro numero, depois criou uma variavel para guardar a o numero, como seria um numero inteiro a variavel vai se chamar num4 e vai guardar um operador logico int, como vai ser um numero inteiro que vai ser guardado, vai precisar usar o int.Parse para avisar que vai ser um int e não uma string, e finalizamos com o ReadLine onde vai ser usado para ler a informação passada pelo usuario e guardar a mesma.

Console.WriteLine("Digite o segundo numero: "); //Esse seria o WriteLine onde você vai usar para mandar uma mensagem na tela do console, nesse caso vai solicitar para digitar o primeiro numero para o usuario. 
int num5 = int.Parse(Console.ReadLine()); //int - Seria o operador logico da variavel; num5 - Nome da variavel; int.Parse - Ele é usado para informar que não ser uma string e sim um int.; Console.ReadLine - Esse informa que ele vai ler a informação passada pelo usuario e vai guardar a mesma. Sendo assim ele vai criar um WriteLine para informar para o usuario digitar o segundo numero, criando uma variavel para guardar esse numero, então ela vai se chamar num5 com operador logico int, como vai ser um numero inteiro vai ter que usar o int.Parse onde vai informar que a informação passada pelo usuario não sera uma string e sim um int, finalizando com o Console.ReadLine que vai ler a informação passada pelo usuario e vai guardar a mesma.

Console.WriteLine("Digite o terceiro numero: "); //O WriteLine ele serve para mandar uma mensagem no console para o usuario, nesse caso ele vai solicitar o segundo numero.
int num6 = int.Parse(Console.ReadLine()); //int - Seria o operador logico da variavel; num6 - Seria o nome da variavel; int.Parse - Ele serve para informar que o usuario vai digitar um int e não uma string; Console.ReadLine() - Aqui ele informa que vai ler a informação passada pelo usuario e vai guardar a mesma. Sendo assim vai ser utilizado o WriteLine para mandar uma mensagem para o usuario digitar o terceiro numero e essa informação vai ser guardada na variavel que foi criada que seria a num6 ela vai guardar um int numero inteiro, como vai ser um numero inteiro vou utilizar o int.Parse que vai informar que não é uma string e sim um int, e para finalizar utilizarei o ReadLine() para ler e guardar a informação passada pelo usuario.

int maior1 = Math.Max(num4, Math.Max(num5, num6)); //int - Vai ser o operador logico da variavel; Math.Max - Informa que ele vai verificar os numeros que estão dentro do parenteses, podendo no maximo ter dois, ele vai verificar qual é o maior dos dois e vai entregar para a variavel como resultado; num1, num2 e num3 - São as informações que são guardadas pelo usuario. Sendo assim criou uma variavel que vai ser um operador logico int tendo o nome de maior e utilizou o Math.Max, como só pode caber dois numeros ou variaveis num parentes do Math.Max ele colocou o num1 em um parentes e criou outro para verificar qual seria maior no outro e assim que descobrisse qual é maior entre o num2 e num3 ele vai verificar qual é maior entre o num1

Console.WriteLine(maior); //Esse ele usou um WriteLine onde vai mostrar qual Seria o maior na tela do console para o usuario.


