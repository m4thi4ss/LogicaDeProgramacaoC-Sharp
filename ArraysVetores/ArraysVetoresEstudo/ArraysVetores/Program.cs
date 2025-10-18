/*ARRAY UNIDIMENSSIONAL
 * 
 * O array ele seria um guarda roupa de valores, sendo uma variavel composta que guarda diversos valores. Ele é diferente da variavel simples que guarda somente um valor;
 * 
 * Segue exemplo: 
 */

/*int[] listaNumeros = {1,2,3,4}; //int - Seria o tipo de dado do array.
                                //[] - O cochete ele seria um vetor onde ele informa que não vai ser uma variavel simples e sim um array uma variavel composta;
                                //{} - A chaves seria onde vai ser armazenado esse valores do array;

/*
 * Sendo assim o exemplo acima mostra que vai ser uma array com o tipo de dado int com o nome listaNumeros e tendo os valores 1,2,3,4 guardados nele.
 * 
 * Mas roda o codigo e não mostra nada, como faz pra mostrar na tela?
 * Nesse caso você vai aprender sobre o indice. O indice ele seria o posicionamento que esta um certo valor guardado na array. O indice ele sempre começa pelo 0, seguindo o exemplo acima, vou te mostrar a tabela de indices do array 0(1), 1(2), 2(3), 3(4). Sendo sempre -1 do elemento, que vamos aprender la na frente. Segue abaixo um exemplo pratico de como buscar um valor com o indice no array:
*/

/*Console.WriteLine(listaNumeros[0]); //Console.WriteLine - Seria uma mensagem que vai ser enviada para o usuario no console;
                                    //listaNumeros - Seria o nome do array que vai ser usado;
                                    //[] - O cochete seria um vetor e ele informa que não vai ser uma variavel simples e sim um array uma variavel composta.

/* O que ele fez aqui, ele buscou dentro da lista o valor "1" que estava no indice 0 do array.
 * Sendo assim os indices seria as posições que esta sendo guardado aqueles valores que foram guardados na ARRAY. 
 * 
 * Mas como que eu sei quantos valores tem no array?
 * Nesse caso entra o .length ele é usado pra contar quantos valores foram guardados na array, mas ele não chama essa contagem de elementos, por que ele não faz a soma dos valores em si e sim faz a contagem de quantos valores foram armazenados no array, ele é diferente do indice o indice fala sobre o posicionamento começando pelo 0 ja o .length ele faz a contagem começando pelo 1, então diferente do indice o .lenght usando o primeiro exemplo vai informa que foi guardado 4 e não igual indice que vai informar que terminou em 3. Segue abaixo um exemplo pratico sobre o uso do .length:
 * */

/*Console.Write(listaNumeros.Length); //Console.WriteLine - Sria uma mensagem que é enviada para o usario no console;
                                    //() - Onde vai ser informado a mensagem;
                                    //listaNumeros - Esta informando que vai ser buscado algo no array chamando o nome dele;
                                    //.length - Ele vai entrar no array informado e vai fazer a contagem de elementos que tem no mesmo e vai retornar o valor total;

/* Sendo assim o .length ele faz a contagem de elementos que tem no array e não a soma dos valores, trazendo um resultado total da soma de todos os elementos disponiveis no array. Ele é diferente do indice que fala o posicionamento começando pelo zero e sendo sempre -1 do .lenght(elemento)
 *
 *E se eu digitar o indice errado, pode quebrar o codigo? Sim, a melhor forma de criar um array é sempre fazer um bloco de codigo com uma condicional onde informa:
 *SE - Se o número informado pelo usuario for MAIOR OU IGUAL a 0 &&(E) Se o numero informado pelo usuario for menor que o ultimo número do elemento que seria o Length ele vai rodar o bloco de codigo normalmente e vai mostrar o valor guardado da posição que foi informada. Mas o length puxa por elemento começando pelo 1, ele vai puxar o numero 4 e no exemplo acima não tem esse indice, mas tem que entender que vai ser menor que o .length que vai puxar a soma de elementos do exemplo acima sendo o 4, então ele não vai terminar a leitura no 4 e sim vai terminar antes dele sendo número 3.
 *SE NÃO - Caso o número seja maior ou igual a quantidade de elementos informados ou menor que o indice 0, ele vai gerar um erro. Vamos fazer um exemplo seguindo o array que ja tem guardado alguns valores que seria o listaNumeros 
 **/

/*int num = 0;// int - Seria o tipo de dado da variavel, sendo o int de números inteiros;
            // num - Seria o nome da variavel simples;
            // = - Seria de resultado;
            // 0 - Ele seria o valor que esta sendo guardado antes de ter um retorno do IF/ELSE.

Console.WriteLine("Me informe o indice que você quer ver o valor que foi guardado no array: "); //Console.WriteLine - Seria uma mensagem que é enviada para o console do usuario. Nesse caso vai solicitar um indice pra buscar o valor no array do indice indicado pelo usuario.

num = int.Parse(Console.ReadLine()); //num - Seria o nome da variavel simples;
                                     //int.Parse - Aqui ele vai informar que não vai ser uma string que vai ser informado pelo usuario e sim um tipo de dado int;
                                     //Console.ReadLine - Aqui ele vai fazer a leitura da informação que vai ser passada pelo usuario e vai transforma o tipo de dado de string para int. 

if (num >= 0 && num < listaNumeros.Length) // if - Seria o SE, Se a informação passada bater com a regra do parametro desse if ele vai rodar o bloco de codigo que ele informou abaixo;
                                           // () - Seria o parametro e o que esta dentro seria a regra do parametro; num - Seria a variavel simples que foi guardada acima;
                                           // >= - Seria operação de comparação maior ou igual;
                                           // 0 - Seria o valor que esta sendo comparado;
                                           // && - Seria o "E";
                                           // listaNumeros - Seria o array que guardou os valores;
                                           // .Length - Ele faz a contagem dos elementos, sempre começando pelo 1; Sendo assim, esta informando que SE a VARIAVEL simples NUM for MAIOR ou IGUAL a 0 E NUM for MENOR que os elementos da array ele vai retornar o bloco de codigo desse IF. Sendo o valor do indice. 
{
    Console.WriteLine(listaNumeros[num]); //Console.WriteLine - Aqui seria uma mensagem que vai ser enviada no console para o usuario. Nesse caso ele vai mandar o valor do indice daquele array.
}
else //ELSE - Ele seria o resto do if, o caso ao contrario do if. Nesse caso a informação não siga a regra do if que seria um número de 0 ao 3, ele vai rodar no bloco de codigo abaixo.
{
    Console.WriteLine("O número informado, não tem indice"); //Console.WriteLine - Ele manda uma mensagem para o usuario no console. Nesse caso ele vai informar que não existe um indice com o número que foi informado pelo usuario.
}
/*OBS: Esse codigo ele é usado para ajudar o array a não quebrar, deixando ele mais seguro. Caso a pessoa peça para retornar um indice que não exista ele vai retornar um erro, caso informe um indice que exista ele vai retornar o valor que esta sendo guardado naquele indice.*/
//-----
/*Exercicio pra verificar se aprendeu
 * 
 * 1 - Vai ser guardado em uma array 5 .length, sendo o tipo de dado int sendo número inteiros.
2 - Vai mostrar no console a quantidade de elementos tem no array.
3 - Vai fazer um laço de repetição que vai mostrar o índice e o valor guardado naquele índice.
4 - Tendo que ter o resultado abaixo:

O array tem 5 elementos.

Posição 0 tem o valor 10
Posição 1 tem o valor 20
Posição 2 tem o valor 30
Posição 3 tem o valor 40
Posição 4 tem o valor 50
*/

/*int[] numeros = {50, 40, 30, 20, 10}; //int - Seria o tipo de dado do array;
                                      //[] - O cochete seria um vetor e quando tem um vetor ele informa que não vai ser uma variavel simples e sim um array uma variavel composta;
                                      //= - Seria o resultado, o que sera guardado no array;
                                      //{} - As chaves é usada para guaradar os números do array;
                                      //Sendo assim esta informando que foi criado um array com o tipo de dado  int chamando o array de numeros e os números guardados esta dentro das chaves que são os 50, 40, 30, 20 e 10;

Console.WriteLine("O array tem " + numeros.Length + " elementos"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console; Nesse caso ele vai mostrar o total dos elementos que tem dentro do array usando o .length;

for(int i = 0; i < numeros.Length; i++) //for - seria uma laço de reptição que segue as regras dos parametros que tem começo e fim e e faz a leitura incrementando sempre +1 ou -1;
                                        //() - Seria o parametro do for e dentro dele seria a regra desse parametro; i - Seria a informação do inicio e fim desse laço;
                                        //< - Ele informa o operador menor;
                                        //numeros - Seria o nome do array que vai ser pego a informação pele .length;
                                        //.length - Ele vai fazer a soma do dos elementos que tem no array informado e retornar o total;
                                        //i++ - informa como esse laço de repetição vai percorrer entre o inicio e fim do for, sendo sempre acrescentando +1;
                                        //Nesse caso ele esta informando que vai ser feito um laço de repetição for que tem o tipo de dado int e vai começar pelo número 0 e vai finalizar no número que vai ser retornado pelo .length, e as informações serão percorridas sempre acrescentando +1, pra mostrar indice por indice;
{
    Console.WriteLine("Posição " + i + " tem o valor " + numeros[i]); //Console.WriteLine - Ele vai enviar uma mensagem no console para o usuario. Nesse caso ele vai mandar para o usuario o indice que esta cada valor guardado no array e os valores que estão em cada indice informado;
}*/
//------------------------------------------------------------------------------------------------------------------------------

//ARRAY MULTIDIMENSSIONAL

/* O array multimenssional ele seria uma tabela de excel contendo linhas e colunas, onde tem cada celula guardado um item. A linha basicamente seria a escada do hotel e as colunas seria os quartos. 
 * 
 * Mas como vou diferenciar um array unidimenssional para o array multidimenssional? 
 * 
 * Da seguinte forma, no array multidimenssional seria o seguinte, você vai colocar os cochetes que no multidimenssional se chama matriz [,] no multidimenssional ele tem uma virgula pra informar que esse array vai ter linhas e colunas. Segue um exemplo abaixo sobre a sintaxe do Array multidimenssional*/

//FORMA MANUAL DE COLOCAR VALOR 1 A 1 NAS COLUNAS 

/*int[,] linhasColunas = new int[2, 3]; //int - Seria o tipo de dado do array multidimenssional, sendo o tipo de dado inteiro;
                                      //[,] - Aqui esta criando uma matriz e com a virgula esta dizaendo que vai ser multidimenssional e não um unidimenssional;
                                      //linhasColunas - Seria o nome do Array Multidimenssional;
                                      //= - Seria o resultado desse array multidimenssional;
                                      //new - Esta informando que sera criado um novo array multidimenssional e os valores serão colocados manualmente ;
                                      //int - esta informando que as linhas e colunas serão tipo de dado int;
                                      //[2, 3] - Aqui esta informando que serão 2 linhas e 3 colunas e cada linha
Inserindo os valores manualmente abaixo
                                      

linhasColunas[0,0] = 3; //linhasColunas - Nome da Array multidimenssional;
                        //[,] - informando que vai ser um array de multidimenssional;
                        //0,0 - O primeiro 0 esta informando que sera o indice da linha 0 que seria a primeira linha e o segundo 0 esta informando que sera o indice 0 da coluna que seria a primeira coluna 
linhasColunas[0,1] = 2;//linhasColunas - Nome da Array Multidimenssional;
                       //[,] - Aqui seria o matriz com virgula informando que vai ser um array multidimenssional;
                       //0,0 - O primeiro 0 seria o indice 0 da linha que seria a primeira linha e o segundo número que seria 1 seria o indice 1 da coluna sendo a segunda coluna da primeira linha;
linhasColunas[0,2] = 1;//linhasColunas - Nome da array multidimenssional;
                       //[,] - Informa que vai ser um array multidimenssional;
                       //0,2 - O indice 0 seria a o numero da linha e o indice 2 seria o numero da coluna;
linhasColunas[1,0] = 1;//linhasColunas - Nome da array multidimenssional;
                       //[,] - Aqui seria o matriz com virgula informando que vai ser um array multidimenssional;
                       //1,0 - indice 1 seria a posição da linha e o indice 0 seria a posição da coluna;
linhasColunas[1,1] = 2; //linhasColunas - Nome da array multidimenssional;
                        //[,] - Seria o matriz com virgula informando que vai ser um array multidimenssional;
                        //1,1 - O indice 1 seria a posição da linha e o segundo indice 1 seria a posição da coluna; 
linhasColunas[1,2] = 3; //linhasColunas - Seria o nome do array multidimenssional;
                        //[,] - Seria o matriz com virgula informando que vai ser um array multidimenssional;
                        //1,2 - O indice 1 seria a posição da linha e o indice 2 seria a posição da coluna;
                        //= - Seria o resultado;
                        //3 - Seria o valor que vai ser atribuida para a linha e coluna informada;


//Sendo assim esse é o jeito mais cansativo de declarar um array multidimenssional, que seria o jeito manual

*/

//FORMA MAIS PRATICA DE DECLARAR UM ARRAY MULTIDIMENSSIONAL


int[,] linhasColunas = {{3,2,1},{1,2,3}}; //int - informa que esse array multidimenssional vai ter o array multidimenssional;
                                           //[,] - O matriz com virgula diferencia o unidimenssional que só coloca coluna para o multidimenssional que coloca linhas e colunas;
                                           //linhasColunas - Seria o nome dado ao array multidimenssional;
                                           //= - Informa que esse array vai ter um tipo de valor já;
                                           //{{}} - Aqui esta a diferença de linhas e colunas as chaves de fora informa a quantidade de linhas e as chaves de dentro informa a quantidade de colunas e os valores guardados nos espaços dessas colunas;
                                           //Sendo assim foi criado um array multidimenssional com o tipo de dado que será guardado nele int e que vai se chamar linhasColunas, tendo uma quantidade de linhas e colunas e os valores que serão informados. Esse é a forma mais pratica de criar um array multidimenssional, pois ele ja cria linhas, colunas e valores em uma linha só;


//INDICE NO ARRAY MULTIDIMENSSIONAL 

/* O indice tem no array multidimenssional também, començando sempre do 0. Então caso você queira chamar ou inserir um valor a linha tal e na coluna tal, você vai ter que colocar o indice da linha primeiro e indice da coluna depois. Segue exemplos de sintaxes abaixo 
 * 
 * INSERINDO VALOR ARRAY MULTIDIMENSSIONAL COM INDICE */

linhasColunas[0,0] = 0;//linhasColunas - Você vai chamar o nome do array multidimenssional que ja foi criado que seria linhasColunas;
                       //[,] - Aqui você esta chamando o matriz e como ele tem a virgula no meio vai ser um multidimenssional;
                       //0,0 - Aqui esta informando que vai ser trocado o indice da linha 0 e o indice da coluna 0;
                       //0 - Esse é o valor que vai ser colocado no lugar do indice da linha 0 no indice da coluna 0, que seria o 3 antes e que agora vai ganhar o 0;
                       //Sendo assim ele fez o seguinte chamou o nome da variavel sem informar que vai ser um int pois ja tinha sido informado que seria um int na criação desse array, aqui você esta chamando ele pois ou vai ser feito uma alteração ou vai ler o que tem guardado, nesse caso esta chamando pra ser alterado, e ja vem com o cochete informando que a vai ser alterado o valor do indice linha 0 e do indice da coluna 0 para o valor 0;

/* LENDO OS VALORES GUARDADOS NA ARRAY MULTIDIMENSSIONAL COM INDICE*/

int visualizarValorLinhaColuna = linhasColunas[0,0]; //int - Seria o tipo de dado que a variavel vai guardar; v - Seria o nome da variavel; linhasColunas - Seria o nome do array multidimenssional; [,] - Informa que vai ser um array multidimenssional; 0,0 - informa que sera guardado valor do indice da linha 0 do indice da coluna 0; Sendo assim foi criado uma variavel para visualizar o valor que foi guardado em uma linha e coluna especifica onde foi informado que vai ser no indice da lina 0 do indice 0 da coluna;
Console.WriteLine(visualizarValorLinhaColuna); //Console.WriteLine - Ele mostra uma mensagem para o usuario. Nesse caso ele vai mostrar o valor que foi guardado na variavel visualizarValorLinhaColuna;

//--------------------PAREI 4) Propriedades úteis — como perguntar o tamanho da matriz -----------------------------------

/* TAMANHOS DISPONIVEIS NO ARRAY MULTIMENSSIONAL
 * 
 * Nos tamanhos multimenssionais tem o .Rank, .Getlength(0), .GetLength(1) e o .length. 
 * 
 * .Rank
 * Vamos começar a explicar pelo .Rank no matrix.Rank ele informa a quantidade de separação vai ter o array como por exemplo o array unidimenssional vai ser matrix.Rank, o multidimenssional vai ter 2 divisões e tridimenssional vai ter 3 divisões.
 * 
 * EXEMPLOS DE SINTAXE
 * 
 * ARRAY UNIDIMENSSIONAL QUE SÓ TEM 1 .Rank
 * 
 */

int[] matrixUnidimenssional = { 1, 2, 3 }; //int - informa o tipo de dado que vai ser o array;
                                           //[] - Seria o vetor informando sem nenhuma virgula, que seria então unidimenssional;
                                           //matrixUnidimenssional - Seria o nome do array;
                                           //= - resultado do array, valor guardado;
                                           //{} - Informa a dimenssão do array;
                                           //1,2,3 - Seria os valores que vão ser guardados no array.
                                           //Sendo assim no array unidimenssional ele só tem uma dimenssão que seria o {}, então automaticamente tem 1 matrix.Rank;

//ARRAY MULTIDIMENSSIONAL QUE TEM 2 .Rank

int[,] matrixMultidimenssional = { {1,2,3 },{ 3,2,1} }; //int - Seria o tipo dado do array;
                                                        //[,] - Aqui seria dois cochete e que se chama matriz com uma virgula onde informa que vai ser um array multidimenssional; matrixMultidimenssional - nome do array multidimenssional;
                                                        //= - Resultado do array, valores guardados;
                                                        //{{},{}} - Aqui seria as dimenssões onde seria a dimenssão 0 sendo a de fora {} e as 2 dimenssões de dentro que seria as das colunas {},{};
                                                        //Sendo assim no array multidimenssional você viu que tem duas dimenssões uma de dentro e outra de fora isso significa que o matrix.Rank tem 2 dimenssões.


//ARRAY TRIDIMENSSIONAL QUE TEM 3 .Rank

int[,,] mtrixTridimenssional = new int[1, 2, 3]; //int - Seria o tipo de dado da matriz; [,,] - O cochete com duas virgulas seria o cubo, aqui ele deixa claro que é um array tridimenssional; matrixTridimenssional - Seria o nome do array; = - Seria informando que vai ser o resultado do array ou o valor guardado; new int - Aqui declara que vai ter um array tridimentssional e os valores vão ser colocados manualmente; [,,] - Como será feito manualmente tem que colocar primeiro linhas, colunas e camadas, sendo 3 dimenssões uma fora que seria linha, outra dentro da linha sendo as colunas e outra dentro das colunas que seria as camadas; Então com o matrix.Rank você vai informar que vai ter 3 dimenssões nesse array.

/*
 * Ele é util pra quando você quer saber quantas dimenssões tem aquele array; 
 * 
 * Por exemplo:
 */
int[,] exemploPratico = {{3,2,1},{1,2,3}}; //int - Tipo

Console.WriteLine("Tem "+ exemploPratico.Rank + " Dimenssões");

/* 
 * 
 * Agora vamos falar sobre o .GetLength(0) ele pega a quantidade de linhas tem disposnivel no array multimenssional e o tridimenssional, .Get siginfica leitura -> Length -> Seria a contagem de elementos -> (0) informa que vai ser a dimenssão de fora, informando que vai ser a contagem de elementos tem disponivel nas linhas. 
 * 
 * EXEMPLO 
 * 
 * SINTAXE DE LEITURA 
 * 
 */

int[,] exemploPraticoLinha = { { 1, 2, 3} }; //int - Tipo de dado do array;
                                             //[,] - Aqui seria a matriz, informando que seria o array multidimenssional; exemploPraticoLinha - Seria o nome do array multidimenssional;
                                             //= - Seria o resultado ou o valor que sera guardado;
                                             //{{}} - Aqui informa a separação das dimenssões sendo a de fora de linha e a de dentro as colunas;
                                             //1,2,3 - São os valores que serão guardados nas colunas; Sendo assim quando usar o .GetLength(0) que seria a contagem das linhas ele vai informar que tem somente 1;

Console.WriteLine("Tem disponivel nesse array "+exemploPraticoLinha.GetLength(0)+" linhas!"); //Console.WriteLine() - Ele manda uma mensagem para o usuario no console, nesse caso ele vai informar quantas linhas tem usando o .GetLength(0);

/* .GetLength(1)
 * 
 * Ele tem o mesmo objetivo que o .GetLength(0) Só que ao invés dele fazer leitura das linhas ele vai fazer as leituras das colunas.
 */

/*.Length 
 * 
 * Nós ja sabemos.
 */

/* COMO PROTEGER UM ARRAY MULTIDIMENSSIONAL 
 * 
 * O Array Multimenssional ele precisa ser protegido pra caso a pessoa não coloque a quantidade de linha correta ou a quantidade de coluna correta. 
 * 
 * Passo a passo de como proteger um Array Multimenssional
 * 
 * 1 - Criar um array multidimenssional
 * 2 - O Array tera o tipo dado int 
 * 3 - Se chamara protecaoArrayMultimenssional 
 * 4 - Vai ter 2 linhas e 4 colunas;
 * 5 - E vai ser montado na forma pratica e não manual;
 * 6 - Criar um for pra proteger o array;
 * 7 - Colocar o tipo de dado int, pois nesse exemplo vão ser usados números inteiros
 * 8 - O número inicial será 0
 * 9 - E o número que irá parar sera o menor que o .GetLingth(0), pois ele vai para no número menor da linha, como vão ser 2 linhas ele vai percorrer 0 e 1 e parar; 
 * 10 - E ele vai percorrer esses números com um incremento de ++i;
 * 11 - Após ser fechado o primeiro for pra linha, vamos criar o segundo for dentro do primeiro, fazendo 1 dimensão dentro da outra
 * 12 - O sengundo for ele também vai ter um tipo de dado int
 * 13 - A letra pra dar inicio e fima ao percurso não vai ser I e sim um J;
 * 14 - O inicio vai começar também no 0 e finalizar no .GetLength(1);
 * 15 - Isirir um Console.WriteLine onde vai informar quantas linhas tem e quantas colunas tem;
 * 16 - colocando um console.WriteLine antes de fechar o for da linha para pular;
 * 
 * MONTAGEM DO CODIGO SEGUINDO O PASSO A PASSO 
*/

int[,] protecaoArrayMultidimensional = { {1,2,3,4 }, {4,3,2,1 } }; //int - Seria o tipo de dado do array;
                                                                   //[,] - Seria uma matriz onde é usado somente no array multidimenssional;
                                                                   //protecaoArrayMultidimenssional - Nome do array multidimenssional;
                                                                   //= - Resultado o valor que será guardado;
                                                                   //{{},{}} - Seria as dimenssões onde a de fora seria a linha e a de dentro seria a coluna;
                                                                   //1,2,3,4 4,3,2,1 - Seria os valores guarados nas colunas sendo 4 colunas;
                                                                   //Sendo assim o objetivo foi criar um array multimenssional com o tipo de dado int, onde vai se chamar protecaoArrayMultidimensional e que vai ja guardar 2 linha e 4 colunas.


for (int i = 0; i < protecaoArrayMultidimensional.GetLength(0); ++i) //for - O for ele é um laço de repetição que tem inicio e fim e vai repetindo o incremento de ++i ou --1 pra chegar no ponto final que foi informado;
                                                                     //int - Seria o tipo de dado do for;
                                                                     //i = O primeiro i seria o valor inicial o segundo i seria o valor final;
                                                                     //< - informa que será menor; protecaoArrayMultidimensional - Nome do array que foi criado e que será protegido pelo for;
                                                                     //.GetLength(0) - Seria a contagem de linha que será feita;
                                                                     //++i - Seria o incremento e nesse caso vai fazer repetição de incremento de +1;
                                                                     //Sendo assim foi criado um for pra proteger a primeiro dimenssão que seria as linhas e esse for vai ter um tipo dado int, se chamando i, ele vai iniciar do 0 e vai usar o .GetLength(0) pra parar antes da contagem final das linhas então nesse caso ele vai repitir até o 1 e vai para por que a contagem de todas as linhas seria 2 ficando 0 , 1 e vai usar o incremento de +1 pra fazer a repetição do for;
{
    for(int j = 0; j < protecaoArrayMultidimensional.GetLength(1); ++j  )//for - Seria um laço de repetição que tem inicio e fim e ele percorre pelo incio e fim incrementando ++j ou --j;
                                                                         //int - Seria o tipo de dado do for; j - Seria o nome do incio e fim do laço de repetição;
                                                                         //< - Seria o de operador lógico menor;
                                                                         //.GetLength(1) - Seria a contagem de quantas colunas tem;
                                                                         //++j - Ele informa de que forma será feito o incremento desse laço de repetição;
                                                                         //Sendo assim foi criado uma segunda dimenssão que seria o da coluna, foi criado com o for pra fazer a mesma proteção que foi feita na primeira dimenssão da linha, o for ele vai ter o tipo de dado int onde vai se chamar J pois o I ja esta sendo usado pela linha, vai começar do 0 e vai usar o .GetLength(1) para finalizar 1 antes do total da contagem de colunas, nesse caso vai ser 4 colunas então vai parar no 3, então incremento vai seguir 0,1,2,3, e finalizando com o uso do incremento de +1 que seria o ++j; 
    {
        Console.WriteLine(protecaoArrayMultidimensional[i, j] + "\t"); //Console.WriteLine - Ele mostra uma mensagem na tela, nesse caso ele vai mostrar a quantidade linha e colunas tem nesse array multidimenssional;
                                                                       //protecaoArrayMultidimensional[] - Seria a sintaxe de leitura do array multidimenssional;
                                                                       //i, j - que vai mostra na tela todos os j e todos os i;
                                                                       //Ele será usado para mostrar quantas linhas, colunas e os valores tem guardado nesse array multidimenssional.
    }
    Console.WriteLine(); //Console.WriteLine - Ele manda mensagem na tela do console, nesse caso ele só vai pular a linha mesmo;
}

/* EXERCIOCIO ARRAY MULTIDIMENSSIONAL
 * 
1) cria uma matriz com 3 linhas e 4 colunas (3x4)
- Informar qual tipo de dado ela vai carregar; 
- Após ter informado, vou fazer a matriz para dizer que vai ser um array multidimenssional;
- Vou dar o nome do array multimenssional de exercicio;
- Após isso foi dar atribuir duas dimenssões pra ela;
- vou informar que ela tem 3 linhas e 4 colunas {{1234}{1234}{1234}}
- Após ter criado o array multidimenssional que seria a matriz;

2) preencher a matriz manualmente (exemplo)
- Aqui optei por um array mais partico pra não ter que colocar manualmente;

3) pegar informações sobre a matriz (As informações seria a quatidade de linhas e colunas tem disponivel, e ela precisa ser guardada então tem que utilizar uma variavel simples pra guardar)
- Criar a primeira variavel pra linha 
- Ela vai ter um tipo de dado int 
- E vai se chamar linha, pois ela é a primeira simenção;
- Vai atribuir pra ela o exercicio.GetLength(0) para informar o total da contagem de linhas tem disponivel;
- Criar a segunda varaivel, que seria pra segunda dimenssão que é para colunas;
- dar o tipo de dado pra ela int;
- Vai se chamar coluna;
- Vai atribuir a ela o exercicio.GetLength(1) que seria o valor total da contagem de colunas disponivel;
- CRIOU AS DUAS VARIAVEIS DE CONTAGEM DE LINHA E COLUNA PRA USAR FUTURAMENTE VAMOS PRO PROXIMO

4) imprimir a matriz como uma tabela (Pra imprimir a tabela da forma correta criaremos um for pra primeira dimesão e segundo for pra segunda dimensão qeu seria linha e coluna)
- Criar o primeiro for para primeira dimensão que seria a linha
- Ele vai ter um tipo de dado int 
- O incio e fim desse for vai se chamar i;
- O i vai começar no 0;
- E o i vai finalizar em 1 número menor que a variavel linha;
- E a repetição do incremento desse for vai ser o ++i, onde ele vai ter um incremento de +1;
- E dentro do primeiro for, vamos criar o segundo for que seria da primeira dimensão sendo o da coluna;
- Ele vai ter um tipo de dado int;
- Vai se chamar j;
- O inicio do j vai ser no 0;
- O final do j vai ser 1 a menos que a variavel coluna;
- E a repetição do incremento nesse for vai ser um ++i que seria a repetição do incremento +1;
- Após criar o i que é a primeira dimenssão (linha) e o j que é a segunda dimenssão(coluna);
- Vamos imprimir na tela;
- Criar um Console.WriteLine;
- Colorcar a sintaxe de leitura do array multidimenssional(matriz) que seria (exercicio[i, j]);
- Após finalizado a impressão da forma correta de uma tabela, vamos para o proximo passo;


5) somar cada coluna (exemplo de operação) (Para fazer a soma das colunas, precisaremos criar uma tabela por onde vai percorrer por todas as linhas e colunas que pertecem a elas;

- Então vamos começar criando a parte da tabela que seria a coluna que vai ser calculado o valor;
- Criar o for da segunda dimenssão (coluna);
- Ele vai ter o tipo de dado int; 
- Vai continuar se chamando j igual na impressão dos array acima;
- O inicio do j vai ser no 0;
- E o j vai finalizar em um número antes da vaiavel coluna;
- E a repetição do incremento vai ser ++i que seria a repetição do +1;

- Vamos criar a variavel que vai guardar o resultado da soma de cada coluna;
- Ela vai ter um tipo de dado int;
- E vai se chamar somaColuna;
- E vai atribuir um valor incial pra ela 0;
- Ela tem que ser criada antes do for da primeira dimensão, por que ela não pode se repetir toda vez que passar nas colunas da linha 0;

- Após ter criado a variavel incial da soma, vamos criar o for da primeira dimensão(linha), vamos criar a primeira dimensão da tabela dentro do for da segunda dimensão. POR QUE NÃO TEM COMO VER OS VALORES DOS QUARTOS SEM SUBIR AS ESCADAS;
- Criar um for para a primeira dimenssão que seria a linha, dentro do for j que seria o que vai ser somado que seria as colunas, ;
- Ele vai ter um tipo dado int;
- E vai se chamar i;
- O i vai inciar no 0;
- E o i vai finalizar um a menos da variavel linha;
- Ele vai repetir o incremento de ++i que seria o +1;

- E após a finalização da tabela que precisara ser percorrida, vamos inciar a soma, dentro do for i que é o da primeira dimenssão;
- Vamos chamar a variavel de incializção da soma;
- vamos usar o operador lógico de += que vai entrar em cada linha e vai somar todos os valores que tem nas colunas, para fazer a atribuição de valor para a variavel; 
- E depois do += vamos usar o exercicio[j, i], para percorrer todas colunas dessas tabelas pegando a soma total de cada uma;
- Então ele vai percorrer da seguinte forma [0, 0] = {1, 2, 3, 4} += vai atribuir o valor 10, então a coluna 0 da linha 0 vai ter o valor guardado pela variavel somaColuna = 10 e assim vai percorrendo pelo restante da tabela criando uma "lista" dos valores totais;

- Após ter criado a variavel soma precisaremos criar a impressão dos valores de cada coluna;
- Vamos criar o Console.WriteLine;
- Que vai ter o valor da seguinte formar primeiro vai informar qual coluna vai ter o valor total informador "Coluna {j}"
- Após isso vamos CONCATENAR com a variavel somaColuna, para informar os valores 

FIM DO PSEUDOCÓDIGO DESSE EXERCICIO

BORA COLOCAR EM PRATICA
*/

//1) cria uma matriz com 3 linhas e 4 colunas (3x4)
int[,] exercicio = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }; //int - Seria o tipo de dado do array;
                                                                          //[,] - Seria a matriz do array multidimenssional; exercicio - Seria o nome do array multidimenssional;
                                                                          //{{},{},{}} - Seria a primeira dimenssão e a segunda dimenssão sendo a primeira para linha que seria a chave que fica para fora e segundo que seria para coluna que fica para dentro;
                                                                          //Números - São os valores guardados nas colunas;
                                                                          //Aqui esta sendo criado um array que tem o tipo de dado int e uma matriz que informa que vai ser um array multidimenssional, o nome do array multidimenssional vai se chamar exercicio e tera 3 linhas e 4 colunas conforme a divisão das dimenssões;

//3) pegar informações sobre a matriz
int linha = exercicio.GetLength(0); //int - Seria o tipo de dado da variavel; linha - Seria o nome da Variavel; exercicio - é o nome do array; .GetLength(0) - É valor total da contagem de linhas disponivel; Nesse caso foi criado uma variavel com o tipo de dado int para guardar o total de linhas que tem disponivel no array de exercicio onde usou o .GetLength(0) que fez a contagem total das linhas;
int coluna = exercicio.GetLength(1); //int - Seria o tipo de dado da variavel; coluna - Seria o nome da variavel; exercecicio - Seria o nome do array que vai ser chamado; . GetLength(1) - Seria a contagem total de colunas; Sendo assim ele vai fazer uma variavel chamada coluna e vai guardar um informação com o tipo de dado int e vai usar o .GetLength(1) para fazer a contagem de colunas disposnivel e o total dessa contagem vai ser o valor guardado;

//4) imprimir a matriz como uma tabela
for(int i = 0; i < linha; ++i) //for - Ele seria um laço de repetição, tendo inicio e fim e pra chegar no fim ele repeti um incremento de ++1 ou --1 para conseguir chegar no final do for; int - Seria o tipo de dado que esse for vai guardar; i - Seria o nome do inicio e fim do for; < - Seria o operador de menor; linha - Seria a variavel que guardou o valor total da contagem de linhas que tem disponivel no array multidimenssional; ++i - Seria  a repetição do incremento e nesse caso ele vai repetir o +1 até chegar no final do for; Sendo assim foi criado o for para  a primeira dimensão que seria o da linha, ele vai ter o tipo de dado int e vai se chamar i, esse for vai começar no 0 e vai ter o incremento ++i que seria o incremento de +1 para chegar no menos linha que seria a variavel que guarda o valor total da contagem de linhas disponivel, tem 3 linhas então a contagem vai até o 2 sendo 0, 1 ,2;
{
    for(int j = 0; j < coluna; ++j) //for - Seria um laço de repetição onde ele tem inicio e fim pra chegar no fim ele usa um incremento ++1 ou --1 repitindo ele até chegar no objetivo final;
                                    //int - Seria o tipo de dado do for;
                                    //j - Seria o nome do for; < - Seria o operador lógico menor;
                                    //coluna - Seria o nome da variavel que foi criada para guardar o total da contagem de colunas disponivel no array;
                                    //++i - Seria o incremento que será usado no array sendo o +1;
                                    //Nesse caso ele esta fazendo o for da sengundo dimensão que seria da coluna, esse for vai guardar um tipo de dado int e vai ser chamar j como ja tem disponivel o i para segunda dimensão, o for vai começar pelo 0 e vai finalizar antes da variavel coluna que guarda o total da contagem de colunas diposnivel no array multidimenssional, finalizando no 3 = 0,1,2,3, e usou o incremento de +1 para repetir e chegar no objetivo final;
    {
        Console.WriteLine(exercicio[i , j] + "\t"); //Console.WriteLine - Manda uma mensagem no console do usuario;
                                                    //exercicio[,] - Aqui seria a sintaxe de leitura do array multidimenssional;
                                                    //i e j - Seria o nome dos for que foi criado para proteger a coluna e linha;
                                                    //Nesse caso foi criado um Console.WriteLine para mandar uma mensagem para o usuario no console e informou array que foi utilizado para mostrar os for que foi criado para as linhas e colunas da forma correta;
    }
    Console.WriteLine(); //Console.WriteLine - Ele manda uma mensagem para o usuario no console, nesse caso ele vai pular somente a linha;
}

//5) somar cada coluna (exemplo de operação)
for (int j = 0;j < coluna; ++j) //for - Seria um laço de repetição onde ele tem inicio e fim e pra chegar no final do for ele repete o incremento de ++1 ou --1 até chegar no objetivo final;
                                //int - Seria o tipo de dado que ele vai guardar;
                                //j - Seria o nome do for; 0 - Seria o valor inicial;
                                //< - informa o operador menor; coluna - Seria a variavel criada para guardar o valor total da contagem de colunas que tem no array exercicio, que será usado para informar o final do for que vai -1 do total da contagem;
                                //++j - Aqui seria o incremento que será usado para chegar no final que seria -1;
                                //Nesse caso foi feito um for para criar uma tabela de colunas, guardado um tipo de dado int e vai se chamar j, tendo o inicio no 0 e vai até um antes do valor guardado pela variavel coluna, e o incremento para repetir e chegar no objetivo final seria o ++j que seria o +1;
{
    int somaColuna = 0; //int - Seria o tipo de dado da variavel;
                        //somaColuna - Seria o nome da variavel;
                        //= - Seria o de atribuição;
                        //0 - Seria o valor guardado para a variavel somaColuna;
                        //Nesse caso foi criado uma variavel somaColuna que tem o tipo de dado int e guadou o valor 0, para ser usado dentro do for a seguir, o por que ela não foi criada dentro do for foi pra ela não entrar no laço de repetição.

    for(int i = 0;i < linha; ++i) //for - Seria um laço de repetição onde tem inicio e fim e pra chegar no final ele usa a repetição do incremento de ++1 ou  --1 para chegar no objetivo final;
                                  //int - Seria o tipo de dado que erá guardado nesse for;
                                  //i = Seria o nome do for; 0 - Seria o valor incial;
                                  //< - Seria o operador menor; linha - Seria a variavel que tem o total da contagem de quantas linhas tem no array; ++i - Seria o incremento do for onde vai ser um incremento de +1;
                                  //Nesse caso vai ser criado uma for para linha, por que pra entrar em todas as colunas ele precisa descer para analisar todas as colunas, igual uma escada e quartos sendo escadas para linhas e quartos para colunas, pra eu analisar todas colunas de todas as escadas, vou precisar passar passar andar por andar usando a escada pra subir e as colunas par ver os valores

        /*                           ___    -> Colunas
         *                          /
         *                         /        -> Linhas 
         *                        ___  
         *                       /
         *                      /
         */
        
    {
        somaColuna += exercicio[i, j]; //somaColuna - Ela seria a variavel que foi criada la fora para inciar a soma dentro do for;
                                       //+= - Ele pega os valores atribuidos ao array exercicio e soma todos eles e passa o valor total como atribuição para a variavel informada antes do operador +=;
                                       //exercicio[,] - Seria o nome do array multidimenssional criado, e como tem a matriz do lado dele, esta indormando que ele vai fazer a leitura do total das informações que foi passado dentro dela;
                                       //Sendo assim o somaColuna vai ser usado para somar todos os valores atribuidos ao i e o j que seria o valores guardados em todas colunas que tem nas linhas, mostrando o total da soma de um por um das colunas.
        Console.WriteLine($"Coluna {j} " + somaColuna); //Console.WriteLine - Seria uma mensagem enviada para o usuario no console; j - Seria os valores dos indices das colunas criados pelo for;
                                                        //somaColuna - Seria a soma de cada coluna que tem nas linhas;
                                                        //Nesse caso foi criado um Console.WriteLine para informar os indices das colunas e os valores da soma de cada coluna que tem nas linhas;
    }
    
}
//--------------------CORRIGIR OS FOR QUE ELES SÃO CRIADOS PARA CRIAR UMA TABELA E NÃO PARA PROTEGER A COLUNA E AS LINHAS--------------------------------------------------------------------- PAREI NO 6) Exemplo comentado passo a passo-------
