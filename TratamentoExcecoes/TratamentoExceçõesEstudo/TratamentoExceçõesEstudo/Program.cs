/*### **1. Entrada Segura de Números**

Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve usar `try/catch` para garantir que o usuário insira um número válido.

**Erros a serem tratados:**

-Usuário digitar um texto ao invés de um número. (`FormatException`)
int num = 0;

do //Ele seria uma estrutura de repetição, sendo um laço de repetição.
{
    try //TRY - Ele serve para testar tudo que é inserido no bloco de codigo dele, podendo dar erro se não seguir o que está sendo informado no catch.
    {

        Console.WriteLine("Me informe um número: "); //Console.WriteLine - Seria uma mensagem que aparece na tela do console. Nesse caso ele vai solicitar para inserir um numero.
        num = int.Parse(Console.ReadLine()); // int - Seria o tipo de dado da variavel; num - Seria a variavel que vai guardar a informação do usuario; int.Parse - Aqui ele vai informar que vai ser um tipo de dado int e não uma string; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transformar tentar transformar de string para int. Nesse caso eu criei um Console.WriteLine para mandar uma mensagem no console para solicitar um numero para o usuario e esse numero vai ser guardado pela variavel num que tem o tipo de dado int e como o WriteLine só aceita informação em string, usei o int.Parse para avisar que vai ser um int e não uma string e usei para o Console.ReadLine para ler a informação e tentar transformar em int a informação passada.
        break; //Ele para o laço de repetição, então quando for digitar o numero, ele vai para e não criar um novo laço.

    }
    catch (FormatException) //Catch - Ele é utilizado para colocar dentro do parametro dele qual seria o erro que ele vai declarar; () - Seria o parametro; FormatException - Ele vai verificar a informação passada pelo bloco de codigo do try e se estiver com o erro de formato ele vai executar o bloco de codigo do catch. Nesse caso o catch ele serve para ter um parametro e dentro de parametro de o erro especifico e nesse caso seria o FormatException onde ele vai verificar a execução do bloco de codigo do try e se estiver com o erro de formato ele vai executar o bloco de codigo do catch caso coloque realmente um numero do tipo de dado int, ele para e não o bloco de codigo do catch.
    {
        Console.WriteLine("Erro: A informação passada não é um número!!!"); //Console.WriteLine - Seria uma mensagem que é enviada no console, nesse caso se o catch encontrar o um erro de formato ele vai lançar automaticamente essa mensagem.
        
    }
} while (num >= 0); //while - Ele tem um parametro onde tem uma regra, se o bloco de codigo rodar e trazer o resultado e ele estiver dentro da regra do parametro do while ele vai para, caso ao contrario ele vai continuar rodando o codigo. Sendo assim, tudo que estiver dentro do "do" ele vai continuar rodando e so vai parar caso o while informe que esta dentro da regra e que pode parar.

int num1 = 0;

do
{
    try
    {
        Console.WriteLine("Me informe um número inteiro: ");
        num1 = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: A informação passada não é um número inteiro.");
    }
} while (num1 >= 0);*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **2. Divisão Segura**

Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use `try/catch` para evitar divisão por zero e entrada inválida.

**Erros a serem tratados:**

-Usuário digitar um valor não numérico. (`FormatException`)
- Tentativa de divisão por zero. (`DivideByZeroException`)

using System;

int num = 0; // int - tipo de dado da variavel; num - Seria o nome da variavel. Nesse caso ele esta pra fora, por que ele não pode ficar dentro do laço de repetição pois ele seria finalizado toda vez que fosse inserido pelo usuario.
int num1 = 0; //int - Seria o tipo de dado da variavel; num1 - Seria o nome da variavel. Nesse caso ele esta para forar para guardar a informação que for passada pelo usuario, e não zera a informação por conta do laço "DO";
int resultado = 0; //int - Seria o tipo de dado da variavel; resultado - Seria o nome da variavel. Nesse caso foi criado uma variavel chamada resultado que tem o tipo de dado int, e ela esta pra fora do laço pois toda vez que terminasse o laço ela perderia a informação, coisa que não pode acontecer.

do //Seria um laço de repetição, que fica rodando o codigo até o while informar que é falso. 
{

    try //O try ele serve para testar tudo que esta sendo colocado no bloco de codigo, podendo voltar um erro se não seguir a regra que esta dentro do parametro do catch
    {
        Console.WriteLine("Me informe um número: "); //Console.WriteLine - Ele manda uma mensagem no console para o usuario. Nesse Caso ele vai solicitar um numero para o usuario.
        num = int.Parse(Console.ReadLine()); //num - Seria a variavel que vai ser guardada a informação que vai ser passada pelo usuario. int.Parse - Aqui ele vai informar que vai ser um int e não uma string. Console.ReadLine - Aqui ele vai ler a informação que for passada pelo usuario e vai transformar de string para int. Sendo assim ele usou o Console.WriteLine para solicitar o numero para o usuario, guardando essa informação na variavel num que tem o tipo de dado int, como ele tem o tipo dado diferente da string usei o int.Parse para informar que vai ser um int e não uma string, usando o Console.ReadLine para ler a informação passada pelo usuario e transformar em int.

        Console.WriteLine("Me informe outro número: "); //Console.WriteLine - Ele manda uma mensagem para o usuario no console, nesse caso ele esta pedindo o segundo numero.
        num1 = int.Parse(Console.ReadLine()); //num1 - Seria o nome da variavel; int.Parse - Aqui ele esta informando que vai ser um int e não um string; Console.ReadLine - Aqui ele vai ler a informação e vai transformar de string para int. Sendo assim ele vai usar o console.WriteLine para solicitar o segundo numero e vai guardar a informação passada pelo usuario na variavel num1 essa variavel vai ter o tipo de dado int e como vai um tipo de dado diferente de string por conta do Console.WriteLine, usei o int.Parse para a avisar que vai ser um int e não uma string e usei o Console.ReadLine para ler a informação passada pelo usuario e transformar em int.

        resultado = num / num1; //resultado - Seria o nome da variavel; num e num1 - Seria a variaveis que guarda a informação passada pelo usuario; / - Operador lógico de divisão; Nesse caso usei a variavel resultado que vai ser int para guardar o resultado da divisão das duas variaveis que foi informado pelo usuario.

        Console.WriteLine($"O resultado da divisão é {resultado}"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console. Nesse caso ele vai mostrar o resultado da divisão.
        break; 
    }
    catch (FormatException) //Catch - Ele servi para mandar o bloco de codigo que está dentro dele caso tenha um erro que foi informado dentro da regra que esta no parametro do catch. FormatException - Aqui seria o erro de formatação, caso tenha um erro de formatação no try ele vai lançar o bloco de codigo abaixo; () - Seria o parametro do catch. Nesse caso eu estou usando o catch para verificar se a informação que esta sendo passada pelo usuario vai da erro de formatação pois dentro do parametro dele tem a regra FormatExcepetion, se der erro de formatação ele vai lançar o bloco de codigo abaixo. 
    {
        Console.WriteLine("Erro: Esse não é um número inteiro!!!"); // Console.WriteLine - Ele manda uma mensagem para o usuario no console. Nesse caso se der erro, pois a informação bate com a regra do parametro do catch acima, ele vai mandar a mensagem acima.
    }
    catch (DivideByZeroException) //catch - Ele serve para colocar qual vai ser o tipo de erro que pode retornar da leitura do try e o bloco de codigo onde ele vai mandar o codigo caso seja o tipo do erro que esta na regra dentro do paramentro do catch; () - Parametro do catch; DivideByZeroException - Seria o tipo de erro que pode retornar na leitura do try. Sendo assim esse catch foi criado com a regra que a divisão não pode ser feita por zero, se for feita por zero ele vai para o codigo que esta dentro do try e vai rodar o seu bloco de codigo.
    {
        Console.WriteLine("Não é possivel fazer a divisão por 0"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuari no console. Nesse caso ele vai informar que a divisão não pode ser feita com 0;
    }
} while (resultado == 0); //While - Ele teria um parametro junto com uma regra, onde vai informar se a informação que foi passada dentro do DO é verdadeira ou falsa se for verdadeira ele vai rodar, se for falso ele para de rodar.
int num2 = 0;
int num3 = 0;
int resultado1 = 0;

do
{
    try
    {
        Console.WriteLine("Me informe um número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe um número: ");
        num3 = int.Parse(Console.ReadLine());

        resultado1 = num2 / num3;

        Console.WriteLine($"O resultado da divisão é {resultado}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Não é um número inteiro!!!");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Erro: A divisão não pode ser feita com o número 0");
    }
} while (resultado1 == 0);*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **3. Validação de Idade**

Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use `try/catch` para evitar entradas inválidas.

**Erros a serem tratados:**

-Usuário digitar um texto ao invés de um número. (`FormatException`)
- Usuário inserir um número muito grande. (`OverflowException`)

int idade = 0; //int - Seria o tipo de dado da variavel; idade - Seria o nome da variavel; Nesse caso ele vai guardar a informação que foi passada pelo usuario, e esta pra fora por que ele não pode ficar dentro do laço de repetição do DO, se estiver la dentro ele vai zerar a variavel toda vez que o bloco de codigo fosse executado.

do //do - Ele seria o laço de repetição, aonde ele vai executar o bloco de codigo até o while der falso, se der verdadeiro ele vai continuar executando o bloco de codigo;
{
    try //try - Ele vai testa todo o bloco de codigo, se gerar um erro no bloco de codigo dentro dele, ele vai lançar um metodo ou uma mensagem.
    {
        Console.WriteLine("Me informe sua idade:"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console, nesse caso ele vai solicitar para o usuario mandar a idade dele.
        idade = int.Parse(Console.ReadLine()); //idade - Seria o nome da variavel; int.Parse - Ele vai informar que não é uma string e sim um int; Console.ReadLine - Aqui ele vai ler a informação passada pelo usuario e vai transformar de string pra int; Sendo assim foi criado um WriteLine para solicitar para o usuario a idade e a informação vai ser guardada na variavel idade a mesma vai ter o tipo de dado int, então usei o int.Parse para avisar que ela vai ser int e finalizer o ReadLine para ler a informação e transformar de string para int.

        if (idade >= 0 && idade < 18) //if - Ele seria o SE for a regra que esta dentro do parametro el vai rodar o bloco de codigo do if; () - Parametro desse if; idade - Seria a variavel que vai guardar a informação do usuario; Sendo assim usou o if para informar que SE a idade for entre o 0 ao 17 vai rodar o bloco de codigo abaixo.
        {
            Console.WriteLine("Você é menor de idade!"); //Console.WriteLine - Seria uma mensagem que é enviada no console. Nesse caso SE for o parametro e regra desse if, ele vai mandar essa mensagem.
        }
        else if (idade >= 18 && idade <= 100) //else if - Ele seria iguao o if, porém como vai ser o segundo if ele tem que ser escrito como else if, por questão de nomenclatura; Nesse caso usei o else if para caso SE a idade for entre 18 ao 100 ele vai lancar o bloco de codigo abaixo.
        {
            Console.WriteLine("Você é maior de idade!"); //Console.WriteLine - Ele manda uma mensagem na tela do console. Nesse caso ele vai mandar que você é maior de idade, caso o usuario informe um numero que esteja dentro do parametro e regra desse else if.
        }
    }
    catch (FormatException) //catch - Ele vai ajudar o try, ele vai verificar se o erro segue a regra dentro do parametro dele, se seguir ele vai mandar o bloco de codigo dele; () - Seria o parametro; FormatException - Seria a opção de erro escolhida para esse catch, que seria erro de formato; Nesse caso foi criado o catch para caso coloque uma letra ele vai lançar um erro que só pode número inteiro.
    {
        Console.WriteLine("Erro: Esse não é um número inteiro!!"); //Console.WriteLine() - Seria uma mensagem que é enviada no console; Nesse caso se o erro estiver dentro da regra que esta no parametro do catch acima, ele vai lançar essa mensagem.
    }
    catch (OverflowException) //catch - Ele vai ajudar o try, ele vai informar um regra dentro do parametro dele e se o erro que o try passou estiver dentro da regra do parametro do catch ele vai lançar o seu bloco de codigo; () - Seria o parametro; OverflowException - Seria o o tipo de erro que foi colocado na regra dentro do parametro desse catch. Nesse caso se o erro for um numero muito grande ele vai usar esse catch pois a regra dentro do parametro do catch teria esse tipo de erro, fazendo com que execute o bloco de codigo abaixo.
    {
        Console.WriteLine("Erro: Não pode digitar essa quantidade de números"); //Console.WriteLine - Seria uma mensagem que aparece no console do usuario; Nesse caso se o erro entrar dentro do parametro desse catch ele vai lançar essa mensagem.
    }
} while (idade > 100 ); //while - Ele ajuda o do a parar o codigo, ele vai verificar se a informação passada vai ser verdadeira ou falso seguindo a regra dentro do parametro dele, se for verdadeiro ele continua executando o bloco de codigo que esta dentro do DO, se for false ele para de executar o bloco de codigo.

int idade1 = 0;

do
{
    try
    {
        Console.WriteLine("Me informe sua idade: ");
        idade1 = int.Parse(Console.ReadLine());

        if (idade1 >= 0 && idade1 < 18)
        {
            Console.WriteLine("Você é menor de idade!!!");
        }
        else if (idade1 >= 18 && idade1 <= 100)
        {
            Console.WriteLine("Você é maior de idade!!!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Só pode números inteiros!!!");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Erro: Não pode digitar essa quantidade números!!!");
    }
} while (idade1 > 100);*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------