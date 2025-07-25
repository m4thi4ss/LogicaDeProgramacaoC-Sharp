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
/*### **4. Contagem Progressiva Segura**

Peça ao usuário para inserir um número inteiro positivo. O programa deve contar de 1 até esse número. Se a entrada for inválida ou negativa, exiba um erro.

**Erros a serem tratados:**

-Usuário digitar um texto ao invés de um número. (`FormatException`)
- Usuário inserir um número muito grande. (`OverflowException`)
- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)

int numero = 0; //int - Seria um tipo de dado da variavel; numero - Seria nome da variavel; Nesse caso estou criando uma variavel para guardar a informação que vai ser solicitada dentro do DO, só não esta la dentro, por que ele vai apagar a informação toda vez que ela for executada.

do //Seria um laço de repetição, onde ele vai executar o bloco de codigo toda vez que o while der verdadeiro, a hora que der falso ele vai rodar por completo.
{
    try //try - Ele testar o bloco de codigo completo, caso apareça algum erro que esteja dentro das regras dos paramentros dos catch ele vai rodar o bloco de codigo do catch especifico daquele erro que surgiu.
    {
        Console.WriteLine("Me informe um número inteiro positivo:"); //Console.WriteLine - Ele manda uma mensagem para o usuario no console, neese caso ele esta solicitando um numero inteiro positivo.
        numero = int.Parse(Console.ReadLine()); //numero - Seria o nome da variavel; int.Parse - Aqui ele vai avisar que vai ter um tipo de dado int; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transformar de string pra int. Sendo assim ele vai usar a variavel criada fora do DO, para não entrar no laço de repetição, e vai usar para guardar a informação que vai ser passada pelo usuario, o tipo de dado dela vai numero inteiro, usando o int.Parse para informar que vai ser um int, e no console.ReadLine ele vai usar para ler a informação passada e vai trasnformar de string para int.

        if(numero <= 0) //if - Ele é usada para informar SE tal variavel for isso ou não for ele vai lançar o seu bloco de codigo; () - Seria o parametro; Nesse caso ele esta informar que SE a variavel numero for menor ou igual a 0 ele vai lançar o bloco de codigo abaix.
        {
            throw new ArgumentOutOfRangeException(); //throw - Ele lança uma exceção manual, onde ele inseri dentro de um lugar especifico no bloco de codigo dentro do try; new - Aqui ele esta criando um novo objeto de erro;ArgumentOutOfRangeException - Seria o erro especifico que pode dar dentro desse if, que seria fora do permitido; 
        }
        for (int i = 1; i <= numero; i++) // FOR - O for ele serve para fazer um laço de repetição que tem o inicio, o fim e essa leitura funciona com o icremento de +1; int - tipo daddo que vai ser a variavel i; i = 1 - Seria da onde vai começar o laço de repetição; i <= numero - onde vai finalizar o laço; i++ - Seria o icremento onde vai acrescentar +1, até chegar no final. Sendo assim esse for foi criado para mandar uma lista que começa do 1 e vai até a informação que foi guardada na variavel numero que vai ser informada pelo usuario, e pra chegar até o final usou o icremento do +1.
        {
            Console.Write(" " + i); // Console.Write - Ele manda uma mensagem em uma linha só para o usuario. Nesse caso ele vai mostrar a lista do 1 até a variavel numero;
            
        }
    }
    catch (FormatException) //catch - Ele serve para informar qual erro especifico vai rodar o bloco de codigo dele, ele colocar uma regra dentro do parametro dele, e o try vai lançar que tem um erro no bloco de codigo, se esse erro estiver dentro da regra que esta no parametro desse catch ele vai executar o bloco de codigo dele; () - Parametro do catch; FormatException - Esse seria o erro que pode dar no try que é especifico para a formatação da informação que for passada pelo usuario.;
    {
        Console.WriteLine("Erro:O número informado não é um número inteiro!"); //Console.WriteLine - Aqui ele vai mandar uma mensagem para o usuario no console, nesse caso vai ser erro de formatação.
    }
    catch (ArgumentOutOfRangeException) //Catch - Ele serve para pegar o erro que for informado no bloco de codigo do try, se o erro estiver dentro da regra do parametro desse catch ele vai executar o bloco de codigo abaixo; () - Parametro do catch; ArgumentOutOfRangeException - Esse seria é especificação do erro, nesse caso seria se o número for negativo ele vai lnçar esse erro.
    {
        Console.WriteLine("Erro: O número informado é negativo."); //Console.WriteLine - Seria uma mensagem enviada para o usuario no console, nesse caso ele vai enviar que teve um erro o numero é negativo o que foi informado.
    }
} while (numero <= 0); //while - Seria o complemento do DO, ele tem uma regra dentro do parametro dele, e nessa regra se der verdade ele roda o bloco de codigo novamente, se der falso ele para de executar o codigo.

int numero1 = 0;

do
{
    try
    {
        Console.WriteLine("Me informe um número: ");
        numero1 = int.Parse(Console.ReadLine());

        
        if (numero1 <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (numero1 > 100)
        {
            throw new OverflowException();
        }
        for (int i = 1; i <= numero1; i++)
        {
            Console.Write(" " + i);
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Pode informar somente números");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Erro: Não pode inserir essa quantidade de números");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Erro: Não pode inserir número negativo");
    }
}
while (numero1 <= 0 || numero1 > 100);*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **5. Soma de Números**

Crie um programa que peça ao usuário para inserir 5 números e some-os. Use `try/catch` para lidar com entradas inválidas.

**Erros a serem tratados:**

-Usuário digitar um valor não numérico. (`FormatException`)
- Usuário inserir um número negativo. (`ArgumentOutOfRangeException`)

int numero = 0; //int - Seria o tipo de dado da variavel; numero - Seria o nome da variavel; Aqui ele esta pra fora, por que não pode colocar uma variavel dentro do DO, se não ele vai apagar as informações toda vez que for executado.
int resultado = 0; //int - Seria o tipo de dado da variavel; resultado - Seria o nome da variavel; Nesse caso ele esta pra fora, por que dentro do DO toda vez que o bloco de codigo fosse executado as informações guardadas seria apagadas. 

do //Do - Ele seria um laço de repetição onde tudo que estiver dentro dele vai ser executado até o while der falso.
{
try //try - Ele vai testar o bloco de codigo dele, se aparecer algum erro e o catch tiver esse erro dentro da regra dele que fica no parametro daquele catch ele vai rodar o bloco de codigo daquele catch em especifico;
{

    for (int i = 1; i <= 5; i++) //for - Ele seria uma estrutura de repetição que tem o inicio e usa o incremento de 1 pra chegar no final do i; () - Seria o parametro; int - Seria o tipo de dado da variavel que vai dentro do parametro do for; i = 1 - Seria o inicio da estrutura repetição do for; i <= 5 - Seria o final da estrutura de repetição do for; i++ - Seria como ele vai fazer pra chegar do inicio ao fim, incremento +1; Sendo assim o for ele vai utilizado para repetir o console writeLine 5 vezes.
    {
        Console.WriteLine("Me informe um número: "); //Console.WriteLine - Ele serve para mostrar uma mensagem na tela do usuario. Nesse caso ele vai solicitar os numero;
        numero = int.Parse(Console.ReadLine()); // numero - Seria a variavel que esta fora do DO, que vai guardar as informações do usuario; int.Parse - Aqui ele vai avisar que a variavel tem o tipo de dado int; Console.ReadLine - Aqui ele vai ler a informação da variavel numero e vai transformar de string para int;
        if (numero < 0) //if - Ele seria o SE, sendo usado para SE a informação estiver dentro da regra do parametro dele, ele vai rodar o bloco de codigo abaixo;() - Seria o parametro; numero < 0 - Aqui esta informando que SE a variavel numero for menor que 0 ele vai rodar o bloco de codigo abaixo, isso seria a regra do parametro do if;
        {
            throw new ArgumentOutOfRangeException(); //throw - Ele seria uma excessão manual; new - informando que vai ser criado um novo objeto; ArgumentOutOfRangeException() - Seria o nome do erro em especifico, nesse caso se der um erro fora do permitido pelo if.
        }
        resultado = numero + resultado;  //resultado - Seria o nome da variavel; numero - Seria o nome da variavel; Nesse caso estou usando a variavel resultado que tem 0 na informação, para fazer a soma da variavel numero com a do resultado(que seria dela mesmo), ficando de exemplo se o usuario colocasse 5 ficaria 5+0 e o resultado da conta vai ser guradada na variavel resultado, e assim acrescentando outros resultados que forem colocados na variavel numero.
    }

    Console.WriteLine(resultado); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console. Nesse caso ele vai mandar a informação guardada na variavel resultado;


}
catch (ArgumentOutOfRangeException) //catch - Seria um completo do try, aqui ele especifica a exceção na regra dentro do parametros do mesmo; () - Seria o parametro; ArgumentOutOfRangeException - Seria o nome da exceção, esse se der o erro de não estiver dentro do permitido, ele vai passar essa informação. Nesse caso o catch ele vai usar a regra que esta dentro do parametro e ela esta usando o throw que esta dentro do if para informar aonde é o dentro do permitido, por isso fiz manualmente, então a regra basicamente seria primeiro do parametro do if e depois passaria para a regra dentro do parametro desse catch, executando o bloco de codigo abaixo.
{
    Console.WriteLine("Erro: Esse número não é inteiro!!"); //Console.WriteLine - Seria uma mensagem enviada para o usuario no console; Nesse caso ele vai infomar que não pode colocar numero negativo;
}
catch (FormatException) //Catch - Seria um complemento do try, onde ele vai usar a regra dele que fica dentro do parametro para detectar um erro especifico que vai ser informado pelo try; () - parametro do catch; FormatException - Seria o nome do erro especifico, esse basicamente seria erro de formato ele esta vendo que tem um tipo de dado int na variavel numero, se o usuario colocar string que seria letra ele vai informar que esta errado;
{
    Console.WriteLine("Erro: A informação passada não é um número inteiro!!!"); // Console.WriteLine - Aqui vai mandar uma mensagem para o usuario no console. Nesse caso ele vai informar que só pode numero inteiro.
}
} while (numero < 0); //While - Ele vai ajudar com a sua regra que fica no parametro dele o DO, pra identificar se continua a executar o codigo ou para, dentro do parametro tem uma regra, se o codigo executar e essa regra der verdadeira com o resultado de toda a execução do codigo ele vai continuar rodando, se der falasa ele para de rodar o codigo;
int numero1 = 0;
int resultado1 = 0;

do
{
    try
    {
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"Me informe o {i}° número: ");

            numero1 = int.Parse(Console.ReadLine());

            if (numero1 < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            resultado1 = numero1 + resultado1;        
        }
        Console.Write($"Resultado:{resultado1}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Somente números!!! ");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Erro: Somente números inteiros!!!");
    }
}while (numero1 < 0) ;*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **6. Validação de Senha**

Crie um programa que solicite ao usuário uma senha e permita até 3 tentativas. Caso a senha esteja errada, informe quantas tentativas restam.

**Erros a serem tratados:**

-Usuário digitar um valor nulo ou vazio. (`ArgumentNullException`)*/


/*string senha = ""; //string - Seria o tipo de dado da variavel;
                   //senha - Seria o nome da variavel;
                   //Nesse caso esta criando uma variavel fora do dor pra não dar erro, pois se colocar dentro do for, cada vez que fosse solicitado uma nova senha a informação que foi guardada anteriormente se perderia, e ela esta com o tipo de dado string por que a senha vai ter caracteres, números e letras.

string novaSenha = ""; //string - Seria o tipo de dado da variavel;
                       //novaSenha - Seria o nome da variavel;
                       //Nesse caso essa variavel vai ser usada quando o usuario vai criar a senha, para que a variavel senha use essa como base pra verificar se está certa ou errada, ela esta pra fora por que se estiver dentro do while toda vez que for informado pelo usuario a senha o while vai apagar a informação, é string por que vai ser usado números, caracteres e letras.




while (string.IsNullOrWhiteSpace(novaSenha)) //while - Ele seria quase mesma coisa que o DO WHILE, só que o while ~ele não executa o bloco de codigo ele ja vai direto e reto, e o do while ele da pelo menos uma excutada no bloco de codigo, sendo assim se tiver uma informação na variavel novaSenha o while vai considerar ela e ja vai para ou continudar o bloco de codigo, ja o DO WHILE ele vai executar uma vez pelo menos e aquela informação passada nessa uma vez que for executada ele vai considerar essa informação e vai esquecer a informação que ja tinha na variavel novaSenha.
                                             //() - Seria o parametro e o que esta dentro e  regra;
                                             //string.IsNullOrWhiteSpace - Aqui esta usando uma função do tratamento de exceção, essa em especifico ela vai aparecer caso o usuario coloque nada no campo;
                                             //(novaSenha) - E essa variavel que vai ser usada.
                                             //Sendo assim usou o WHILE pra caso tenha uma informação dentro da variavel ele vai usar essa informação e como a informação dentro da variavel novaSenha esta vazia ele vai ser obrigado a executar o codigo, e usamos o string.IsNullOrWhiteSpace para caso o usario não coloque nada no campo que vai passar uma informação para variavel, ele vai rodar o bloco de codigo novamente, até o usuario informar a senha correta.
{
    Console.Write("Nova senha:"); //Console.Write - Seria uma mensagem que é enviada no console, como não o Line ele vai escrever tudo em uma linha só;
                                  //Nesse caso ele vai solicitar a nova senha;

    novaSenha = Console.ReadLine(); //novaSenha - Seria a variavel;
                                    //ConsoleReadLine() - Aqui ele vai ler a informação e vai transformar em string;
                                    //Nesse caso criou um Console.Write para solicitar a nova senha, e essa informação vai ser guardada na varivel novaSenha essa variavel vai ser um tipo de dado string por que vai usar numero, letra e caracteres usando o console ReadLine só pra confirmar que vai ser string o tipo de dado. 

    if (string.IsNullOrWhiteSpace(novaSenha))//if - Ele seria o SE, SE a informação passada da variavel que esta na regra e dentro do parametro dele seguindo os procedimentos que ele informou na regra, ele vai rodar o bloco de codigo abaixo, caso ao contrario ele vai continuar rodando o bloco de codigo fora do if. () -parametro e o que esta dentro e a regra; string.IsNullOrWhiteSpace - Esta informando que tipo de tratamento de exceção vai ser e nesse caos vai ser o de campo vazio; (novaSenha) - Seria a variavel que vai ser usada para o tratamento de exceção por isso que esta dentro do paramentro do tratamento de exceção.
    {
        Console.WriteLine("Erro: Não pode ser vazia."); //Console.WriteLine - Ele manda uma mensagem para o usuario no console, nesse caso ele vai informar que o campo não pode ser vazio.

    }
}

    Console.WriteLine("Senha cadastrada com sucesso!"); //Console.WriteLine - Aqui seria uma mensagem que é enviada para o usuario na tela, nesse caso se o bloco rodar corretamente e o while de falso ele vai informar que a senha foi cadastrada.


int tentativas = 3; //int - Seria o tipo de dado da variavel; tentativas - Seria o nome da variavel. Nesse caso seria uma variavel chamada tentativas que tem o tipo de dado int, ela esta pra fora do bloco de codigo onde vai ser usada, por que a informação que vai vim dentro dela não pode ser apagada pelo for, e ja vem com 3 por que só podem ser 3 tentativas.

    for (int i = 1; i <= 3; i++) //for - Ele é um laço de repetição onde tem o inicio e fim e caso seja necessario ler entre o inicio e fim da regra dele ele usa o icremento que seria o i++; int - Seria o tipo de dado da variavel que vai no for; i = 1 - Seria o inicio; i <= 3 - Seria o fim; i++ - Seria o icremento de +1; Nesse caso usou o for que tem o parametro e dentro dele tem a regra informando que o bloco de comando vai ser excecutado do 1 ao 3, e pra percorrer entre o inicio e o fim usou o i++ que seria o icremento de +1.
    {
        try //try - Ele seria um tratamento de exceção, onde ele vai testar todo bloco de codigo e se aparecer um erro que se indentifica com as regras dos catch dele, ao inves dele continuar executando o codigo, ele vai parar e vai excutar o bloco de codigo daquele cactch que a regra se indetifica com o erro informado pelo try;
        {
            Console.Write("Me informe a senha:"); //Console.Write - Seria uma mensagem na mesma linha que é enviada para o usuario no console. Nesse caso ele está solicitando a senha;
            senha = Console.ReadLine(); //senha - Seria o nome da variavel; Console.ReadLine - Aqui ele vai confirmar que é uma string; Nesse caso foi criado uma variavel para guardar a informação que for passada pelo usuario da pergunta do WriteLine e essa variavel vai se senha e tem o tipo de dado string, a criação dela esta la fora pra não perder o valor dela, como o tipo de dado é uma string usou somente o ReadLine pra confirmar.

            if (string.IsNullOrWhiteSpace(senha)) //if - Ele seria o SE, SE a variavel que esta na regra dele seguir os mesmo procedimentos da regra ele executa o bloco de codigo dele; string.IsNullOrWhiteSpace - Aqui seria o nome do tratamento de exeção, nesse caso se o campo informado na variavel dentro do parametro for vazio ele vai executar o bloco de cacth do catch do try que esta em especifico na sua regra essa exceção;() - parametro e dentro seria a regra; senha - variavel;
            {
                throw new ArgumentNullException(); //throw - Ele seria um tratamento de exceção manual; new - Esta informando que vai ser criado um novo objeto; ArgumentNullException - Seria o tipo de tratamento de exceção em especifico; Nesse caso esta sendo criado um tratamento de exceção manualmente por isso do throw onde ele vai criar um novo objeto que seria o tipo de exceção, onde SE o if for acionado ele vai lançar essa exceção.
            }

            else if (senha == novaSenha) //if - Seria o SE, SE a variavel que esta dentro da regra do mesmo e seguindo os mesmo parametros ele vai lançar o seu bloco de codigo; () - Parametro e dentro dele é a regra; senha e novaSenha - Seria as variaveis; == - operador de comparação de igual.
            {
                    Console.WriteLine("Senha correta!!!"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario. Nesse caso ele vai informa que a senha está correta;
                    break; //break - Seria para parar o codigo e não continuar mandando senha correta toda hora.
            }
             else //else - ele seria igual o if, porém ele pega os parametros e as regras que sobraram e se for o parametro e a regra dele ele excuta o bloco de codigo;
                {
                    tentativas--; //tentativas - Seria variavel; -- = Seria o operador lógica de incremento; Nesse caso ele vai pegar a variavel que tentativas que foi criada fora do for e usou o incremento negativo que seria o -1 para fazer uma contagem regressiva do 3 ao 1.
                    if (tentativas > 0) //if - Seria o SE, SE a variavel que esta dentro do seu parametro na sua regra e a informação guardada seguindo as regras informadas pelo if, ele vai executar o bloco de codigo abaixo;
                                        //()- Parametro e dentro dele seria a regra;
                                        //tentativas - Seria a variavel;
                                        //> - Seria o operador lógico de maior;
                                        //Nesse caso ele vai usar o if para informar que SE a variavel tentativa estiver maior que 0 ela vai continuar rodando o bloco de codigo dela.
                    {
                        Console.WriteLine($"A senha está incorreta! Restam {tentativas} tentativas.");//Console.WriteLine - Seria uma mensagem que é enviada no console.
                                                                                                      //Nesse caso ele vai mandar uma mensagem para o usuario informando quantas tentativas resta; 
                    }
                    else //else - Seria igual o if, mas o parametro e a regra dele seria o resto dos parametros e das regras que ja foram criadas pelos if e os else if;
                         //Nesse caso se o numero for igual a 0, ele vai mandar o bloco de codigo abaixo.
                    {
                        Console.WriteLine("Acabou as tentativas!!!");//Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console.
                                                                     //Nesse caso ele vai mandar uma mensagem informando que a acabou as tentativas;
                    }
                }
        }
        catch (ArgumentNullException)//Catch - Esse seria o catch, ele auxilia o try pra especificar o erro especifico;
                                     //() - argumento e dentro dele seria a regra;
                                     //ArgumentNullException - Seria o tratamento de exceção especifico;
                                     //Nesse caso foi criado um tratamento de exceção para fora do permitido, ele pega o throw manual que foi criado no if;
    {
            Console.WriteLine("Erro: O campo não pode estar vazio!"); //Console.WriteLine - ELe manda uma mensagem para o usuario no console.
                                                                      //Nesse caso ele vai informar que o campo vazio não pode ser colocado na senha;
        }
    }
//(teste no bloco de notas abaixo)
string senha1 = "";
string novaSenha1 = "";

while (string.IsNullOrWhiteSpace(novaSenha1))
{
    Console.Write("Me informe a senha: ");
    novaSenha1 = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(novaSenha1))
    {
        Console.WriteLine("O campo nova senha não pode ser vazio!!!");
    }
}

Console.WriteLine("Senha cadastrada com sucesso!!!");

int tentativa1 = 3;

for (int i = 1; i <= 3; i++)
{
    try
    {
        Console.Write("Me informe a senha:");
        senha1 = Console.ReadLine();

        
        if (senha1 == novaSenha1)
        {
            Console.WriteLine("Senha correta!!!");
            break;
        }
        else
        {
            tentativa1--;
            if (string.IsNullOrWhiteSpace(senha1) && tentativa1 > 0)
            {
                throw new ArgumentNullException();
            }
            else if (tentativa1 > 0)
            {
                Console.WriteLine($"Senha incorreta. Restam {tentativa1} tentativas!!!");
            }
            else
            {
                Console.WriteLine("Acabou as tentativas!!!");
            }
        }
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine($"O campo não pode ser vazio! Restam {tentativa1} tentativas");
    }
}
*/
//------------------------------------------------------------------------------------------------------------------------------------------------------

/*9.Menu de Opções com Tratamento de Erros
Crie um programa que exiba um menu com opções:
1 - Somar dois números
2 - Subtrair dois números
3 - Multiplicar dois números
4 - Sair
**Erros a serem tratados:**

- Usuário digitar um valor não numérico. (`FormatException`)
- Usuário escolher uma opção inválida. (`ArgumentException`)

int num = 0; //int - O int seria o tipo de dado da variavel;
             //num - Seria o nome da variavel;
             //= 0 - É o valor da variavel;
             //sendo atribuido para a variavel. Sendo assim a variavel foi criada para fazer com que o Do funcionasse corretamente, por esse motivo ele foi criado aqui fora, se fosse la dentro ele iria ficar apagando a cada vez que o laço de repetição se concluisse.
int num1 = 0;// int - Seria um tipo de dado da variavel;
             // num1 - Seria o nome da variavel;
             // = 0 - Seria o valor atribuido para aquela variavel;
             // Sendo atribuido para a variavel. Sendo assim a variavel foi criada para fazer com que o Do funcionasse corretamente, por esse motivo ele foi criado aqui fora, se fosse la dentro ele iria ficar apagando a cada vez que o laço de repetição se concluisse.
int num2 = 0;// int - Seria o tipo de dado da variavel;
             // num2 - Seria o nome da variavel;
             // = 0 - Seria o valor que esta sendo atribuido para a variavel.
             // Sendo assim a variavel foi criada para fazer com que o Do funcionasse corretamente, por esse motivo ele foi criado aqui fora, se fosse la dentro ele iria ficar apagando a cada vez que o laço de repetição se concluisse.
int resultado = 0;//int - Seria o tipo de dado da variavel;
                  //resultado - Seria o nome da variavel; = 0 - Seria o valor atribuido para a variavel;
                  //Sendo assim ela esta fora do laço de repetição do DO, para não perder as informações que forem gravadas nela, e será usada, para obter os resultados das contas.


do //O DO seria um laço de repetição, onde ele executa pelo menos uma vez, caso tenha um valor atribuido para uma variavel, ele não vai considerar esse valor, ele vai derrubar ele e vai colocar o valor novo que foi informado na execução do laço. Sendo assim ele seria um laço de reptição que precisa do While para informar os parametros e regras dele e que executa pelo menos uma vez, mesmo com valor atribuido para as variaveis.
{
    try //TRY - Seria um tratamento de exceção, onde ele vai rodar o bloco de codigo abaixo, se ele ve que tem um erro que esta na regra do parametro do catch ele vai para o bloco de codigo na hora e vai rodar o bloco de codigo do catch que tem aquela regra no parametro dele. 
    {
        Console.WriteLine($"Menu de Opções: \n1 - Somar dois números\n2 - Subtratir dois númeors\n3 - Mutiplicar dois números\n4 - Sair");  //Console.WriteLine - Ele manda uma mensagem para o console, nesse caso ele pula uma    linha por conta do line.
                                //Aqui ele esta sendo usado para informar um menu para o usuario ve no console.
        num = int.Parse(Console.ReadLine()); //num - Seria a variavel que foi criada antes do DO;
                                             //int.Parse - Aqui ele esta sendo usado para informar que será usado um int e não uma string;
                                             //Console.ReadLine() - Aqui ele vai ser usado para ler a informação que vai ser atribuida para a variavel e vai transformar de string para int.
                                             //Sendo assim essa variavel foi criada para guardar a informação que o usuario passar sobre o menu, usando um tipo de dado int e como foi usado esse tipo de dado vou usar o int.Parse para avisar que vai ser um int e não uma string, e finalizando com o ReadLine onde ele vai ler a informação que vai ser passada e vai transformar em int ao invés de string.

        if (num == 1) // if - Ele é usado para SE, exemplo: SE a informação for essa roda meu bloco de codigo. E a ~regra dele fica dentro do parametro, onde ele informa SE for tal coisa;
                      // () - Parametro e o que esta dentro dele seria a regra;
                      // num == 1 - Aqui esta informa num tem que ser == igual a 1;
                      // Sendo assim SE num for igual a 1 o IF vai rodar o bloco de cosigo atribuido a ele.
        {
            Console.Write("Me informe o primeiro numero:"); //Console.Write - Ele mostra uma mensagem para o usuario no console, como só tem o write ele vai fazer tudo em uma linha só.
                                                            //Nesse caso ele perguntou o primeiro numero para o usuario.
            num1 = int.Parse(Console.ReadLine()); //num1 - Seria a varivel que foi feita antes do DO;
                                                  //int.Parse - Aqui esta informando que vai ser um int e não uma string;
                                                  //Console.ReadLine() - Nesse caso ele vai ler a informação e vai transformar a mesma de string para int.
                                                  //Sendo assim aqui vai ser utilizado um variavel que foi criada antes do DO pra não perder a informação na execução do laço de repetição, e como foi informado lá que o tipo de dado dela vai ser int,usei o int.Parse para avisar e usei o ReadLine para ler a informação e transformar de string para int, assim ele vai guardar o primeiro número informado pelo usuario corretamente.

            Console.Write("Me informe o segundo número:"); //Console.Write - Aqui ele vai ser usado para mandar uma mensagem para o usuario no console, como não o Line ele vai fazer tudo na mesma linha.
                                                           //Nesse caso ele está solicitando o segundo número.
            num2 = int.Parse(Console.ReadLine()); //num2 - Seria o nome da variavel que foi criada antes do DO;
                                                  //int.Parse - Ele vai ser utilizado para informar que vai ser um tipo de dado int e não uma string.
                                                  //Console.ReadLine - Aqui ele está usando para ler a informação que vai ser passada e transformar de string para int.
                                                  //Sendo assim ele está usando uma variavel fora do laço de reptição do DO, para não perder a informação que foi passada, como o tipo de dado informado vai ser int, teve que usar o int.Parse para informar que não vai ser string e sim int, e usei o ReadLine para ler a informação que for passada e vai trasnformar a mesma de string para int, fazendo com que guarde a informação do usuario corretamente.

            resultado = num1 + num2; //resultado - Seria a variavel que foi criada fora do laço de repetição;
                                     //num 1 e num2 - Seria a variavel que foi criada fora do laço e que tem explicação completa acima;
                                     //= - Seria resultado;
                                     //+ - operador lógico de soma; Sendo assim foi criado uma variavel chamada resultado fora do laço de repetição para que quando ela fosse executada não perdesse a informação da variavel, ela vai ser usada para guardar o resultado da soma da variavel num1 e num2.

            Console.WriteLine($"Segue resultado da conta {resultado}"); //Console.WriteLine - Seria uma mensagem que vai ser envaida para o usuario no console, como tem o Line ele vai pular a linha.
                                                                        //Nesse caso ele vai mostrar o valor que foi atribuido a variavel resultado.
        }
        else if (num == 2) //Else if - Ele seria a mesma coisa que o IF, mas por questão de nomenclatura ele vira o Else if.
                           //Nesse caso esta informando que SE o num for igual == ao 2 ele vai rodar o bloco de codigo que foi atribuido a ele.
        {
            Console.Write("Me informe o primeiro numero:"); //Console.Write - É uma mensagem que é enviada para o usuario no console, como não tem o line ele vai ser na mesma linha.
                                                            //Nesse caso ele vai solicitar o primeiro número.
            num1 = int.Parse(Console.ReadLine()); //num1 - Seria a variavel que foi criada fora do laço do DO;
                                                  //int.Parse - Aqui ele vai informar que vai ser um int e não uma string;
                                                  //Console.ReadLine - Aqui ele vai ler a informação e vai transformar de string para int;
                                                  //Nesse caso utilizou a variavel num1 que foi criada fora do laço de repetição pra não perder a informação a cada vez que o laço fosse repetido, como o tipo de dado vai ser int, teve que usar o int.Parse para informar que vai ser int e não string e finalizou com o ReadLine para ler a informação e transformar de string para int, fazendo com que guardasse a informação corretamente para não ter problema.

            Console.Write("Me informe o segundo número:"); //Console.write - Aqui ele vai mandar uma informação para o usuario no console, como não tem o Line ele vai fazer tudo em uma linha só.
                                                           //Nesse caso ele vai solicitar o segundo número.
            num2 = int.Parse(Console.ReadLine()); //num2 - Seria o nome da variavel que foi criada fora do laço de reptição;
                                                  //int.Parse - Aqui ele vai informar que o tipo de dado vai ser int e não string;
                                                  //Console.ReadLine - Aqui ele vai ler a informação e vai transformar de string para int;
                                                  //Nesse caso vai ser utilizado o num2 que esta fora do laço de repetição DO pra não perder as informações que vão ser guardadas na variavel, como o tipo de dado vai ser int vai ser utilizado o int.Parse para avisar que vai ser int e não string e na finalização usei o Console.ReadLine para ler a informação que foi passado e transformar de string para int. 

            resultado = num1 - num2; //resultado - Seria a variavel que foi criada fora do laço de repetição DO;
                                     //num1 e num2 - Seria a variavel que vai ser guardada a informação do usuario que foi explicado mais detalhado acima;
                                     //= - Aqui esta informando resultado;
                                     //- - Operador lógico de subtração;
                                     //Sendo assim foi criado o resultado fora do laço de repetição DO, pra não perder a informação que vai ser guardada, e o valor dela vai ser a conta das variaveis num1 e num2.
            Console.WriteLine($"Segue resultado da conta {resultado}"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console, como tem o Line ele vai pular sempre uma linha;
                                                                        //Nesse caso ele vai mostrar o valor que foi atribuido para a variavel resultado.
        }
        else if (num == 3) //else if - Seria a mesma coisa que o if, mas por questão de nomenclatura ele tem que esta como else if por que ja tem um if;
                           //() - Parametro; num == 3 - regra do parametro;
                           //Nesse caso seria o else if esta sendo usado para informar SE o num for igual == ao 3 ele vai rodar o bloco de codigo que foi atribuido a mim.
        {
            Console.Write("Me informe o primeiro numero:"); //Console.Write - Seria o uma mensagem que é enviada no console, como não tem o Line vai ser feito tudo na mesma linha;
                                                            //Nesse caso ele esta solicitando o primeiro numero.
            num1 = int.Parse(Console.ReadLine()); //num1 - Seria a variavel que foi criada fora do laço de repetição DO;
                                                  //int.Parse - Ele avisa que vai ser um int e não uma string;
                                                  //Console.ReadLine - Aqui ele vai ler a informação que foi passada pelo usuario e vai transformar de string para int.
                                                  //Nesse caso utilizou a variavel num1 que está fora do laço de repetição pra não perder a informação em cada execução que for feita pelo DO, como a variavel foi colocado que vai ter o tipo de dado int, usei o int.Parse para avisar e o ReadLine para ler a informação e transformar de string para int, pra guardar a informação corretamente.

            Console.Write("Me informe o segundo número:"); //Console.Write - Aqui ele vai mandar uma mensagem para o usuario no console, como não tem o Line ele vai mandar as informações tudo em uma linha só;
                                                           //Nesse caso ele esta solicitando o segundo número.
            num2 = int.Parse(Console.ReadLine()); //num2 - Ele seria a variavel que foi criada fora do laço de repetição;
                                                  //int.Parse - Aqui ele vai informar que o tipo de dado vai ser um int e não uma string;
                                                  //Console.ReadLine - Aqui ele vai ler a informação e vai transformar a mesma de string para int;
                                                  //Nesse caso vai ser usado a variavel num2 que esta fora do laço de repetição do DO para não perder as informações que forem colocados no mesmo, como o tipo de dado vai ser int, usei o int.Parse para a avisar e o Console.ReadLine para ler a informação e transformar de string para int.

            resultado = num1 / num2; //resultado - Seria uma variavel que foi criada for do laço de repetição DO;
                                     //num1 e num2 - Seria a variavel que guarda a informação que o usuario passou;
                                     //= - Simbolodo de resultado; / - operador lógico de divisão;
                                     //Sendo assim foi pego a variavel resultado fora do laço de reptição DO pois em cada excecução que for feito pelo DO no bloco de codigo, a variavel não vai perder a informação que foi guardada, nesse caso o valor da varivel resultado que vai guardar vai se a divisão entre as variaveis num1 e num2.
            Console.WriteLine($"Segue resultado da conta {resultado}"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console, como tem o line ele não vai ser feito tudo em uma linha só;
                                                                        //Nesse caso ele vai passar o valor que foi atribuido para a variavel resultado.
        }
        else if (num == 4) //else if - Ele seria a mesma coisa que o if, mais por questão de nomenclatura ele vira o else if por que ja tem um if;
                           //() - Parametro e dentro dele seria a regra;
                           //num == 4 - Aqui SE o num for igual a 4;
                           //Nesse caso seria se o SE o num for == igual a 4 ele vai rodar o bloco de código que foi atribuido a ele.
        {
            Console.WriteLine("Obrigado!"); //Console.WriteLine - Ele seria uma mensagem que é enviada para o usuario no console, como tem o Line ele vai passar a informação pulando linha;
                                            //Nesse caso ele vai agradecer ao usuario.
        }
        else if (num > 4 || num < 1) // else if - Seria a mesma coisa que o if, mas por questão de nomenclatura ele precisa ser o else if pois ja tem um if; () - parametro e dentro dele seria a regra; num > 4 - Aqui seria num maior que 4; || - ou; num < 1 - num menor que um; Nesse caso o else esta informando que SE num for maior que 4 ou num menor que 1, ele vai gerar o erro abaixo, usando o bloco de codigo do catch que vai ser avisado pelo try;
        {
            throw new ArgumentException();//throw - Aqui ele esta informando que vai ser criado um erro manualmente; new - Esta informando que esta sendo criado um novo tratamento de exceção; ArgumetException - Seria o tratamento de exceção, nesse caso se for diferente dos números do menu ele vai lançar; Sendo assim ele esta sendo usado para informar que vai utilizar o bloco de codigo do catch que esta com o parametro que informa o tratamento de exceção;
        }
        else //else - Ele pega todas os parametros e regras e verifica o que sobrou, assim que ele pega a regra que sobrou ele fica pra ele, não precisando informar o parametro e nem a regra dele;
        {
            throw new FormatException(); //throw - Aqui esta informando que sera feito um tratamento de exceção manualmente; new - Esta informando que vai ser um novo tratamento de exceção; FormatExceprion - Aqui esta informando o tratamento que vai ser usado que vai ser o formato do tipo de dado; Nesse caso esta informando manualmente que sera usado um catch nesse else e que se o try pegar ele vai parar o codigo e vai rodar o catch que tem o parametro de exceção que foi informado no parametro;
        }
    }
    catch (FormatException) //catch - Seria um auxilio ao try, onde ele tem um parametro e dentro dele tem o tratamento de exceção especifico;
                            //() - Parametro;
                            //FormatException - Tratamento de exceção especifico;
    {
        Console.WriteLine("Erro: Só pode inserir os números inteiros do menu!!!"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario, como tem o Line ele vai quebrar linhas;
                                                                                   //Nesse caso ele vai informar que o Erro que só pode ser números inteiros;
    }
    catch (ArgumentException) //Catch - Seria o aucxiliar do try onde ele tem um parametro e dentro do parametro ele tem um tratamento de exceção especifico, onde ele vai informar olha tem um erro, pode rodar meu bloco de codigo;
    {
        Console.WriteLine("Erro: Esse número não existe no menu!!!"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console, como vai ser Line ele vai pular linha; Nesse caso vai informar que não pode colocar letras para o usuario;
    }
} while (num > 4 || num < 1); //while - Aqui ele esta auxiliando o DO, criando um parametro onde se o num for maior que 4 ou mnor que 1 ele vai rodar o codigo novamente.

//Solução no bloco de notas

using System;

int num = 0;
int num1 = 0;
int num2 = 0;
int resultado = 0;

do
{
    try
    {
        Console.WriteLine("Menu \n1 - Somar dois números\n2 - Subtratir dois números\n3 - Multiplicar dois números\n4 - Sair ");
        num = int.Parse(Console.ReadLine());

        if (num == 1)
        {
            Console.Write("Me informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Me informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine($"Segue resultado da conta: {resultado}");

        }
        else if (num == 2)
        {
            Console.Write("Me informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Me informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 - num2;

            Console.WriteLine($"Segue resultado da conta: {resultado}");
        }
        else if (num == 3)
        {
            Console.Write("Me informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Me informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 / num2;
        }
        else if (num == 4)
        {
            Console.Write("Muito obrigado!");
        }
        else if (num < 1 || num > 4)
        {
            throw new ArgumentException();
        }
        else
        {
            throw new FormatException();
        }

    }
    catch (ArgumentException)
    {
        Console.WriteLine("Erro: Esse número não está no menu!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: A informação passada não corresponde a um número inteiro!");
    }
} while (num < 1 || num > 4);*/
//--------------------------------------------------------------------------------------------------------------------------
/*
7.Fatorial com Validação
Solicite ao usuário um número inteiro positivo e calcule o fatorial desse número usando um loop for.
Erros a serem tratados:
Usuário digitar um valor não numérico. (FormatException)
Usuário inserir um número muito grande. (OverflowException)
Exemplo de Entrada:
Digite um número: -3

​
Exemplo de Saída:
Erro: O número deve ser positivo.
*/
 



