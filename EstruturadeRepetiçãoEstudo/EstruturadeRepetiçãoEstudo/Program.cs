/*## **Básicos**

### **1. Contagem de 1 a 20**

Crie um programa que exiba os números de 1 a 20 na tela.

### **Solução:** 

for(int i = 1; i < 21; i++) //FOR - Ele basicamente le as informações da lista, se uma das informações citadas no parametro estiver ele vai retornar um metodo, imprimir uma frase ou uma lista mesmo. int - seria o tipo de dado da variavel; i = 1 - Aqui esta informando que seria o começo do laço de repetição, começando pelo 1; i < 21 - Aqui esta informando o final do laço de reptição; i++ - Aqui esta informando que o i vale 1, então o laço de repetição vai 1 + 1 = 2 com +1 vai pra 3 e assim por diante. Sendo assim vai ser usado o for para criar um laço de repetição do 1 ao 20, tendo a regra que vai ter somente numero inteiro que seria o tipo de dado int, onde vai começar pelo i = 1 e vai finalizar no i < 21 resumindo vai ser criado uma lista de 1 até o 20, como é umn laço de repetição tem que informar onde começa e onde vai finalizar, e vamos concluir com i++ ele que vai fazer o laço de repetição funcionar do jetio certo, fazendo com que o o i tem o valor de 1 e incrementando +1 até chegar no 20.
{
    Console.WriteLine(i); //Aqui ele vai retornar o que foi informado na regra, retornando um laço de repetição do 1 ao 20;
}
*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **2. Validação de senha**

Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

int senha; //int - Seria o tipo de dado da variavel; senha - Seria o nome da variavel; Basicamente criou uma variavel chamada senha e com o tipo de dado int.
do //do - O do ele seria uma estrutura de repetição (um laço), onde ele vai executar o que está dentro do bloco de codigo que seria o que está dentro da {} e vai verificar se o while esta informando se é verdadeiro ou falso. Se for verdadeiro ele vai repetir esse laço, se não for ele vai finalizar o codigo.
{
    Console.WriteLine("Informe a senha: "); //Console.WriteLine - Ele seria uma mensagem que vai ser enviada no console, nesse caso ele esta solicitando a senha para o usuario.
    senha = int.Parse(Console.ReadLine()); //senha - Seria a variavel, sendo a informação que vai ser passada pelo usuario e guardada na variavel; int.Parse - Como o tipo de dado vai ser um int, tive que usar o int.Parse, para avisar que vai ser enviado um int e não uma string; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transformar de string para int. 
}while(senha != 1234); //While - Ele vai verificar para o do se a informação que ele executou no bloco de codigo é verdadeira ou falsa, se for falsa ele finaliza o codigo se for verdadeira ele repete o WriteLine. Sendo assim foi criado uma variavel primeiro chamada senha com o tipo de dado int e com a informação vazia, para que o do fosse criado e fizemos o bloco de codigo, dentro do bloco de codigo eles vão solicitar para o usuario a senha com o WriteLine, o usuario informando a senha ja vai ser utilizado a variavel vazia que é a senha, para guardar a informação passada pelo usuario, e como o tipo de dado vai ser int usei o int.Parse para avisar que vai vim um int e não uma string e usei o Console.ReadLine para finalizar lendo a informação passada pelo usuario e transformando de string para int, depois disso veio o while onde ele vai esperar o DO executar o bloco de codigo pelo menos uma vez, pra verificar se a informação é verdadeira ou falsa seguindo a confirguração que foi feita na regra dele, se for verdadeira ele vai voltar a perguntar se for falsa ele vai finalizar a conversa.

int senha1;

do
{
    Console.WriteLine("Me informe a senha: ");
    senha1 = int.Parse(Console.ReadLine());
} while (senha1 != 1234);*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **3. Tabuada de um número**

Peça ao usuário um número e exiba a tabuada dele de 1 a 10.

Console.WriteLine("Me informe um numero: "); //Console.WriteLine - Aqui ele vai mandar uma mensagem no console para o usuario, nesse caso ele ta solicitando um numero.
int n = int.Parse(Console.ReadLine()); //int - Seria o tipo de dado da variavel; n - Seria o nome da variavel; int.Parse - Aqui ele vai informar que vai ser um int e não um string; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transformar de string para int; Sendo assim ele o WriteLine para informar o usuario a digitar o numero, essa informação vai ser guardada na variavel n que tem o tipo de dado int e como vai ser int usou o int.Parse para avisar que não é uma string e sim um int e pra finalizar usou o console.ReadLine para ler a informação e transformar em int;

for (int i = 0; i <= 10; i++) //for - O for ele vai ler a lista que esta dentro da regra entre o parentes e vai entregar em forma de mensagem ou metodo. int - Seria o tipo de dado da variavel; i - Aqui seria o começo do laço de repetição, sendo o "0", o nome pode ser qualquer um, mas pela nomenclatura o essencial é colocar i; i <= 10 - Aqui seria o fim do laço de repetição; i++ - Aqui esta informando que o laço de repetição vai funcionar com o incremento de +1; Sendo assim o for foi criado para criar uma lista com o tipo de dado int e vai começar i = 0 e vai terminar no i <= 10, usando o i++ para incrementar +1 até chegar no 10.
{
    Console.WriteLine($"{n} * {i} = {n * i}");//Primeiro - Aqui seria o bloco de comando, onde vai mandar o resultado da regra do for; Console.WriteLine - Esse seria uma mensagem que é enviado para o usuario no console; () - Seria a regra no WriteLine; $ - Ele informa que pode colocar variaveis na mensagem; "" - Ele informa que será um texto que vai ser digitado; n - Seria a variavel que vai ser informada pelo usuario; i - Seria o nome do laço, onde ele vai informar o começo e o fim do laço. Basicamente esse algoritmo foi ciado para informar que o n, o numero informado pelo usuario, vai fazer multi´plicação com o laço do for, sendo n * de 0 a 10 do laço informado como foi colocado {n} {i} ele vai mostrar a lista completa, por exemplo se for 1, vai ficar 1 * 0 e vai mostrar na tela até finalizar o laço e o resultado vai ser a mesma logica porém foi criado com uma {} pra mostrar todos os resultados da list, finalizando com uma tabuada completa com os dados que o usuario informar.
}

Console.WriteLine("Me informe um número: ");
int n1 = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{n1} * {i} = {n * i}");
}*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **4. Contagem regressiva**

Peça um número ao usuário e faça uma contagem regressiva até 0.

### **Solução:** 

Console.WriteLine("Me informe um número: ");//Console.WriteLine - Ele manda uma mensagem no console para o usuario, nesse caso ele esta solicitando um numero.
int n = int.Parse(Console.ReadLine());//int - Seria o tipo de dado da variavel; n - Seria o nome da variavel. int.Parse - Seria um aviso que vai ser um int e não uma string; Console.ReadLine - Esta informando que vai ser lido o que o usuario mandar e tranformado em de string para o int. Sendo assim foi criado uma variavel para guardar a informação do usuario, chamado de n e tendo um tipo de dado em int, e como vai ser um int, usou o int.Parse para informar que é um int e não uma string usando o Console.ReadLine para ler a informação passada pelo usuario e transformar de string pra int.

for (int i = n; i >= 0; i--) //for - O for ele vai ler a lista que esta sendo informada na regra e vai retornar um metodo ou uma mensagem; int - seria o tipo de dado do laço; i = n - A informação inicial da lista, podendo ter outro nome; i >= 0 - Seria o final da lista; i-- - Ele esta informando que vai ter um incremento de -1 no laço para chegar no objetivo. Foi criado o for para fazer uma regra de lista on vai ser tipo de dado int, e vai começar pelo numero que o usuario informou, por que se o usuario informar 10 ele vai mandar uma lista de contagem regressiva do 10 até o 0, sendo assim o i <= 0 vai ser o final da lista chegou nele o laço para, e na parte do incremento como vai retirar numero para ser uma contagem regressiva foi colocado o icremento de -1 pra chegar no resultado esperado. 
{
    Console.WriteLine(i); //WriteLine - Ele seria uma mensagem que vai aparecer na tela para o usuario, nesse caso vai aparecer a lista de contagem regressiva.
}

Console.WriteLine("Me informe um número: ");
int n1 = int.Parse(Console.ReadLine());

for (int i = n1; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **5. Média de notas**

Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.

int nota; // int - Seria o tipo de dado da variavel; nota - Seria o nome da variavel;
int somaNotas = 0;// int - Seria o tipo de dado da variavel; somaNotas - Seria o nome da variavel
int qtdNotas = 0;// int - Tipo de dado da variavel; qtdNotas - Seria o nome da variavel;

do // Seria uma estrutura de repetição(Laço), onde ele vai ter um bloco de comando que fica dentro do {}, e o while vai verificar se esse bloco de comando é verdadeiro ou falso, se for verdadeiro ele vai repetir esse laço e se for falso ele vai finalizar o comando.
{ 
    Console.WriteLine("Informe uma nota: ");// Console.WrtieLine - Aqui ele vai mandar uma mensagem no console para o usuario, nesse caso ele esta solicitando para o usuario que informe uma nota.
    nota = int.Parse(Console.ReadLine()); // nota - Seria a variavel que sera informada pelo usuario; int.Parse - Aqui ele esta informando que o tipo de dado vai ser um int e não uma string; Console.ReadLine - Ele vai ler a informação e vai transformar de string para int. Nesse caso ele vai solicitar para  o usuario a nota, e essa informação que sera passada, vai ser guardada na variavel nota, vai ser um tipo de dado int e como sera int usei o int.Parse para informar que sera um int e não uma string. Finalizando com o Console.ReadLine que vai ler a informação passada pelo usuario e vai transformar essa informação de string para int.

    if (nota >= 0 && nota <= 10) //if - O if ele serve para ler um parametrô informado por ele, e dentro desse parametro avera uma regra, Se a informação que o usuario passar seguir as regras do parametro do if, ele vai usar o bloco de comando que esta vinculado aquele if; () - Seria o parametro; nota - Seria a informação que sera passada pelo usuario; && - Seria o "E"; Sendo assim ele esta usando o if, para criar um parametro com uma regra informando que se a NOTA for um numero inteiro de 0 a 10 ele vai usar o bloco de comando abaixo;
    {
        somaNotas = nota + somaNotas; // somaNotas - Aqui seria uma variavel que vai guardar o resultado do if; Nota - Seria a variavel informada pelo usuario; Sendo assim o que vai acontecer, no somaNotas ele não tem valor nenhum certo, então toda vez que o usuario informar um valor no nota ele vai jogar esse valor no somaNotas, acrescentando toda vez que for passado um numero Nota. Ex: nota = 1, nota = 2, nota = 1 o somaNotas vai ficar o resultado da soma de todas as notas informada ficando 1+2+1 = somaNotas.
        qtdNotas++; //Aqui ele vai incrementar toda vez que for informado uma nota, ele não ligar pro valor e sim pra quantidade que foi informadoo valor na nota dentro da regra do parametro do if, ex: nota = 1, nota = 2, nota = 1 a contagem vai ficar nota + nota + nota = 3 que seria a quantidade de vezes que foi colocado a nota.
    }
} while (nota >= 0 && nota <= 10); //Aqui ele esta informando se a informando que se a informação do usuario for menor que 0 ou maior que 10 ele vai para o laço de repetição e vai mandar o resultado do bloco de comando.

int media = somaNotas / qtdNotas; //int - Seria o tipo dado da variavel media; media - Seria o nome da variavel; somaNotas - Seria a soma total dos numeros informados pelo nota; qtdNotas - Seria a quantidade de vezes que a nota guardou um numero informado pelo usuario. Sendo assim eles vão criar uma variavel onde vai fazer a soma dos valores somados pela variavel somaNotas e vão dividir pela variavel que soma a quantidade de notas que foi insirido, buscando a media da nota que o usuario busca saber. 
Console.WriteLine(media);//Esse seria o Console.WirteLine onde ele vai mostrar uma mensagem no console, na tela do usuario, nesse caso ele vai mostrar a informação da variavel media. 



int nota1;
int somaNota1 = 0;
int qtdNota1 = 0;

do
{
    Console.WriteLine("Me informe a nota: ");
    nota1 = int.Parse(Console.ReadLine());

    if (nota1 >= 0 && nota1 <= 10)
    {
        somaNota1 = nota1 + somaNota1;
        qtdNota1++;
    }
    ;
} while (nota1 >= 0 && nota1 <= 10);

int media1 = somaNota1 / qtdNota1;

Console.WriteLine(media1);*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **6. Somatório de números positivos**

Escreva um programa que peça números ao usuário e some-os, parando quando o usuário inserir um número negativo.

int num; //int - Seria um tipo de dado de uma variavel; num - seria o nome da variavel. Ele esta fora do DO por que ele precisa ser existir pra que consiga fazer a estrutura de repetição.
int soma = 0; //int - Seria o tipo de dado da variavel; soma - Seria o nome da variavel, nesse caso tem que colocar 0, por que vai ser acrescentado valores dentro dessa variavel, para que no final do laço ela informe quanto foi adicionado.

do // do - Seria uma estrtura de repetição(laço), onde ela vai ter um bloco de comando, tendo o while se vai verificar se é verdadeiro ou falso, se for verdadeiro ele vai continuar executando o bloco de comando se não for ele vai para de executar e vai finalizar.
{
    Console.WriteLine("Me informe um numero: "); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console, nesse caso está sendo usado para solicitar um numero para o usuario.
    num = int.Parse(Console.ReadLine()); //num - Seria a variavel criada fora da estrutura de repetição. int.Parse - Aqui ele esta informando que o tipo de dado vai ser um int e não uma string; Console.ReadLine() - Aqui ele vai ler a informação que vai ser passada pelo usuario e vai transformar de string para int. Nesse caso vai ser informado agora que int.Parse e o Console.ReadLine pois foi informado dentro do DO que vai ter um Console.WriteLine, então tem que informar que a informação do writeLine vai ser guardada na variavel num e essa variavel tem que ser transformada de string para int.


    if(num >= 0) // if - Ele serve para informar SE a informação passada pelo usuario estiver dentro do parametro informado, ele roda o bloco de comando, caso ao contrario, ele não vai executar aquele bloco de comando.
    {
        soma = num + soma; //soma - é a variavel que vai somar os numeros informados; num - variavel criada para guardar as informações do usuario; Sendo assim ele vai fazer a soma de todos os números que for informado pelo usuario e que for guardado no num.
    }
}while(num >= 0); //O while ele serve para verificar se aquela informação passada pelo usuario é verdadeiro ou falso, nesse caso se o número for positivoele vai continuar rodando o bloco de comando, caso ao contrario ele vai para de rodar o bloco de comando.

Console.WriteLine(soma); //Console.WriteLine - Aqui seria uma mensagem que vai ser enviado no console para o usuario, nesse caso ele vai mostrar a informação da variavel soma.

int num1;
int soma1 = 0;

do
{

    Console.WriteLine("Me informe um número");
    num1 = int.Parse(Console.ReadLine());

    if (num1 >= 0)
    {
        soma1 = num1 + soma1;
    }
    ;

} while (num1 >= 0);

Console.WriteLine(soma1);*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **7. Número primo**

Peça ao usuário um número e determine se ele é primo.

using System.Runtime.InteropServices;
int resultado; //int - Seria o tipo de dado da variavel; resultado - Seria o nome da variavel; Basicamente ela foi criada para receber o valor dentro do for.


Console.WriteLine("Me informe um número: "); //Console.WriteLine - Seria uma mensagem que vai ser enviada para o usuario no console, nesse caso ele vai solicitar um numero.
int num = int.Parse(Console.ReadLine()); //int - Seria um tipo de dado; num - Seria o nome da variavel; int.Parse - Aqui ele vai informar que não vai ser uma string e sim um int; Console.ReadLine - Aqui ele vai ler a informação da variavel num e vai trasnformar em int. Sendo assim ele criou uma variavel chamada num com o tipo de dado int para guardar a informação que vai ser passada pelo usuario, como o tipo de dado vai ser um int eu usei o int.Parse para avisar e o Console.ReadLine ele vai ler a informação e vai de trasnformar de string pra int, pois toda WriteLine transforma a informação passada pelo usuario em string.

for(int i = 2; i < num; i++) // for - O FOR ele serve para verificar a informação que foi passado, se a informação for verdadeira ele continua rodando, so para quando a informação for falsa; () - Seria o parametro do for; i = 2 - Seria o inicio da estrutura de repetição; i < num - Seria o fim da estrutura de repetição. i++ - Seria o incremento onde ele vai adicionar 1 até chegar no falso. Nesse caso ele vai analisar as informações que vão começar pelo numero 2 e vai até o num, quando passar do num, o laço de repetição para, usando o i++ para incrementar 1 numero até chegar a zero.
{
    resultado = num % i; //resultado - Ele seria a variavel que vai ser usada para fazer a lista dos resultados do resto da divisão da lista criada pelo for. num - Seria a variavel que vai guardar a informação do usuario; i - Vai ser a informação o laço de repetição criado pelo for. Sendo assim aqui foi criado para fazer a divisão do num / i e essa divisão vai dar o resto, transformando o resultado em uma lista de resto de divisão.

    if(resultado == 0 ) // IF - Seria um e SE, nesse caso se a lista do resultado ter um 0 ele vai retornar o bloco de codigo.
    {
        Console.WriteLine("Não é primo"); //Console.WriteLine - Seria uma mensagem que vai ser enviada para o usuario no console, nesse caso se if for verdadeiro ele vai retornar uma mensagem para cada 0 na lista que não é um primo.
        break; //Break - Ele força a parada do laço de repetição, basicamente ele viu que tem 0 na lista do resultado, ele não vai mandar um por um, ele vai mandar de uma vez só, que não é primo.
    }
    else //Else - Seria o SE NÃO, se o if der falso ele vai usar o bloco de codigo do else, seguindo as informações do parametro acima.
    {
        Console.WriteLine("É primo"); //Console.WriteLine - Seria uma mensagem que vai ser enviada para o usuario no console, nesse caso ele vai informar que não é primo.
        break; //Break - Ele serve para forçar a para do laço de repetição, nesse caso se aparecer algum 1 ele vai retornar de uma vez e em uma unica vez o bloco de codigo, sem mandar um por um, criando uma nova lista.
    }
}

int resultado1;

Console.WriteLine("Me informe um numero: ");
int num1 = int.Parse(Console.ReadLine());

for (int i1 = 2; i1 < num1; i1++)
{
    resultado1 = num1 % i1;

    if (resultado1 == 0)
    {
        Console.WriteLine("Não é numero primo");
        break;
    }
    else
    {
        Console.WriteLine("Numero é primo");
        break;
    }
}*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*### **8. Sequência de Fibonacci**

Peça um número N ao usuário e exiba os N primeiros termos da sequência de Fibonacci.

using System.Reflection;

Console.WriteLine("Me informe até onde a lista de Fibonaci vai: "); //Console.WriteLine - Aqui ele vai mandar uma mensagem para o usuari, nesse caso ele vai solicitar até onde a lista da fibanacci vai ir.
int num = int.Parse(Console.ReadLine()); //int - Aqui seria o tipo de dado da variavel; num - Seria o nome da variavel; int.Parse - Aqui ele vai informar que o tipo de dado vai ser um int e não uma string; Console.ReadLine - Ele serve para ler a informação passada pelo usuario e transformar de string para int. Sendo assim criou um WriteLine para mandar uma mensagem para o usuario solicitando até onde vai a lista Fibonacci, e criou uma variavel para guardar a informação que vai ser passada pelo usuario, a variavel vai ter um tipo de dado int, como vai ser um int avisei com o int.Parse e coloquei o ReadLine para ler a informação passada e transformar de string para int.
int primeiro = 0; //int - Seria o tipo de dado da variavel; primeiro - Seria o nome da variavel. Nesse caso essa variavel esta sendo usada para mostrar na tela a lista fibonacci.
int segundo = 1; //int - Seria o tipo de dado da variavel; segundo - Seria o nome da variavel. Essa variavel vai ser usada para auxiliar no resultado da primeira, por isso vai começar com o 1, para ajudar no calculo.

for (int i = 0; i < num ; i++) //for - Seria um laço de repetição; int - Seria o tipo de dado da variavel "i"; i = 0 - Seria o inicio do loop; i < num - Seria o final do loop; i++ - Seria o icremento para que o loop chegue até o final do loop. Sendo assim criei um for para informar que vai ter um paramentro com regra que vai ter um tipo de dado int, onde vai começar com 0 e vai terminar na informação que a variavel "num" guardou para o usuario, tendo o incremento para rodar até chegar na variavel.
{
    // Calcula o próximo número da sequência
    int proximo = primeiro + segundo; // int - Seria o tipo de dado da variavel; proximo - Seria o nome da variavel; primeiro - Seria o nome da variavel; segundo - Seria o nome da variavel; Sendo assim foi criado uma variavel onde ele vai guardar o resultado da soma das variaveis primeiro(0) e segundo(1)

    // Atualiza os valores para o próximo passo
    primeiro = segundo; //Aqui ele vai pegar a informação da variavel segundo que veio antes de ele pegar o resultado do calculo, por ex ele vai pegar a informação que esta va variavel segundo, que foi usada no calculo e não a do resultado, por isso essa varivel esta recebendo o resultado da variavel segundo, primeiro que quando a variavel segundo recebe a informação do proximo.
    segundo = proximo; Sendo assim ele vai usar o console.Write para mostrar na mesma linha o resultado, então ele vai mostrar a primeira variavel, fazendo o primeiro lopping:
        mostrar = 0 
        
        proximo = primeiro(0) + segundo (1)
        proximo = 1 (O proximo vai ficar 1 por conta do primeiro + segundo e vai dar o restultado)
        segundo = 1 (O segundo vai continuar sendo 1 por conta que ele vai pegar a informação que a variavel proximo guardou, por que ele vai ficar com essa informação por causa que ele informou que segundo = proximo, sendo assim toda rodada que for feito a soma do primeiro + segundo o proximo vai guardar o resultado e passar para o segundo na proxima rodada)
        primeiro = 1 (Por que ele vira 1, por que o segundo ele ja vem com o 1, então automaticamente o primeiro vai para o 1, e por isso que no proximo ele vai ser 1 também por que o segundo vai continuar sendo 1, por que vai 0 + 1 = 1 dando o resultado da variavel proximo.

       segundo lopping
        mostrar = 1 (Por que na segunda rodada vai mostrar "1" por que o primeiro ficou com o 1 do segundo  )

        proximo = primeiro (1) + segundo (1)
        proximo = 2 (O proximo vai herdar o resultado do calculo do primeiro + segundo)
        segundo = 2 (E o segundo vai herdar a informação que foi guardada com o proximo)
        primeiro = 1 (E o primeiro vai guardar a iformação que veio com o segundo)

    

    Console.Write("N" + primeiro + " " ); // Mostra o número atual
    
    
};
Console.WriteLine(" ");

Console.WriteLine("Me informe até onde vai a lista Fibonnaci: ");
int num1 = int.Parse(Console.ReadLine());

int primeiro1 = 0;
int segundo1 = 1;

for (int i = 0; i < num1; i++)
{
    int proximo1 = primeiro1 + segundo1;

    primeiro1 = segundo1;
    segundo1 = proximo1;

    Console.Write("N" + primeiro1 + " ");
}*/
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
/*### **9. Adivinhe o número**

O programa escolhe um número aleatório entre 1 e 100. O usuário tenta adivinhar e o programa dá dicas.*/

int escolhido; //int - Esse seria o tipo de dado; escolhido - Seria o nome da variavel; Ele vai usar essa variavel dentro do DO para colocar um numero aleatorio.
int num = 0; //int - Esse seria o tipo de dado; num - Seria o nome da variavel; Ele vai ser usado para guardar a informação passada pelo usuario;
do //O do ele seria um laço de repetição, onde ele vai rodar o bloco de codigo até o while verificar que é verdadeiro a informação passada pelo usuario pra ele para o codigo.
{
    Random random = new Random(); //Random - Seria uma classe criada pelo .Net; random - Seria a variavel que vai guardar essa classe Radom; new Random() - Aqui ele vai instaciar o objeto com o construtor para fazer com que de a vida a essa classe que foi guardada no random. Sendo assim aqui ele vai criar uma variavel random para usar o metodo Next que fica dentro da classe Random, e o new random literalmente vai dar vida a variavel random, onde ele vai instanciar a classe para objeto com o contrutor onde ele vai da a vida para aquela variavel, para usar o metodo .Next que tem dentro da classe Random.
    
 
    escolhido = random.Next(0, 101); //escolhido - Seria o nome da variavel; random - vai ser a variavel que guarda a classe random; .Next - Seria o metodo da classe Random onde ele vai gerar um numero aleatorio seguindo a regra do paramentro; (0, 101) - Seria a regra do parametro do .Next.

        Console.WriteLine("Adivinhe o numero que o programa escolheu:"); //Console.WriteLine - Seria uma mensagem enviada para o usuario no console, nesse caso ele vai solicitar para o usuario para adivinhar qual numero o program escolheu.
        num = int.Parse(Console.ReadLine()); //num - Seria o nome da variavel; int.Parse - Aqui ele está informando que o tipo de dado vai ser um int e não uma string; Console.ReadLine - Ele vai ler a informação passada pelo usuario e vai transformar de string para int; Sendo assim 

        if (num == escolhido)
        {
            Console.WriteLine("Você acertou!");
        }
        else if (num < escolhido)
        {
            Console.WriteLine("Esse numero é menor!!!");
        }
        else
        {
            Console.WriteLine("Esse numero é maior!!!");
        }
    
} while(num != escolhido);

