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


//int[,] linhasColunas = {{3,2,1},{1,2,3}}; //int - informa que esse array multidimenssional vai ter o array multidimenssional;
//[,] - O matriz com virgula diferencia o unidimenssional que só coloca coluna para o multidimenssional que coloca linhas e colunas;
//linhasColunas - Seria o nome dado ao array multidimenssional;
//= - Informa que esse array vai ter um tipo de valor já;
//{{}} - Aqui esta a diferença de linhas e colunas as chaves de fora informa a quantidade de linhas e as chaves de dentro informa a quantidade de colunas e os valores guardados nos espaços dessas colunas;
//Sendo assim foi criado um array multidimenssional com o tipo de dado que será guardado nele int e que vai se chamar linhasColunas, tendo uma quantidade de linhas e colunas e os valores que serão informados. Esse é a forma mais pratica de criar um array multidimenssional, pois ele ja cria linhas, colunas e valores em uma linha só;


//INDICE NO ARRAY MULTIDIMENSSIONAL 

/* O indice tem no array multidimenssional também, començando sempre do 0. Então caso você queira chamar ou inserir um valor a linha tal e na coluna tal, você vai ter que colocar o indice da linha primeiro e indice da coluna depois. Segue exemplos de sintaxes abaixo 
 * 
 * INSERINDO VALOR ARRAY MULTIDIMENSSIONAL COM INDICE */

//linhasColunas[0,0] = 0;//linhasColunas - Você vai chamar o nome do array multidimenssional que ja foi criado que seria linhasColunas;
//[,] - Aqui você esta chamando o matriz e como ele tem a virgula no meio vai ser um multidimenssional;
//0,0 - Aqui esta informando que vai ser trocado o indice da linha 0 e o indice da coluna 0;
//0 - Esse é o valor que vai ser colocado no lugar do indice da linha 0 no indice da coluna 0, que seria o 3 antes e que agora vai ganhar o 0;
//Sendo assim ele fez o seguinte chamou o nome da variavel sem informar que vai ser um int pois ja tinha sido informado que seria um int na criação desse array, aqui você esta chamando ele pois ou vai ser feito uma alteração ou vai ler o que tem guardado, nesse caso esta chamando pra ser alterado, e ja vem com o cochete informando que a vai ser alterado o valor do indice linha 0 e do indice da coluna 0 para o valor 0;

/* LENDO OS VALORES GUARDADOS NA ARRAY MULTIDIMENSSIONAL COM INDICE*/

//int visualizarValorLinhaColuna = linhasColunas[0,0]; //int - Seria o tipo de dado que a variavel vai guardar; v - Seria o nome da variavel; linhasColunas - Seria o nome do array multidimenssional; [,] - Informa que vai ser um array multidimenssional; 0,0 - informa que sera guardado valor do indice da linha 0 do indice da coluna 0; Sendo assim foi criado uma variavel para visualizar o valor que foi guardado em uma linha e coluna especifica onde foi informado que vai ser no indice da lina 0 do indice 0 da coluna;
//Console.WriteLine(visualizarValorLinhaColuna); //Console.WriteLine - Ele mostra uma mensagem para o usuario. Nesse caso ele vai mostrar o valor que foi guardado na variavel visualizarValorLinhaColuna;

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

//int[] matrixUnidimenssional = { 1, 2, 3 }; //int - informa o tipo de dado que vai ser o array;
//[] - Seria o vetor informando sem nenhuma virgula, que seria então unidimenssional;
//matrixUnidimenssional - Seria o nome do array;
//= - resultado do array, valor guardado;
//{} - Informa a dimenssão do array;
//1,2,3 - Seria os valores que vão ser guardados no array.
//Sendo assim no array unidimenssional ele só tem uma dimenssão que seria o {}, então automaticamente tem 1 matrix.Rank;

//ARRAY MULTIDIMENSSIONAL QUE TEM 2 .Rank

//int[,] matrixMultidimenssional = { {1,2,3 },{ 3,2,1} }; //int - Seria o tipo dado do array;
//[,] - Aqui seria dois cochete e que se chama matriz com uma virgula onde informa que vai ser um array multidimenssional; matrixMultidimenssional - nome do array multidimenssional;
//= - Resultado do array, valores guardados;
//{{},{}} - Aqui seria as dimenssões onde seria a dimenssão 0 sendo a de fora {} e as 2 dimenssões de dentro que seria as das colunas {},{};
//Sendo assim no array multidimenssional você viu que tem duas dimenssões uma de dentro e outra de fora isso significa que o matrix.Rank tem 2 dimenssões.


//ARRAY TRIDIMENSSIONAL QUE TEM 3 .Rank

//int[,,] mtrixTridimenssional = new int[1, 2, 3]; //int - Seria o tipo de dado da matriz; [,,] - O cochete com duas virgulas seria o cubo, aqui ele deixa claro que é um array tridimenssional; matrixTridimenssional - Seria o nome do array; = - Seria informando que vai ser o resultado do array ou o valor guardado; new int - Aqui declara que vai ter um array tridimentssional e os valores vão ser colocados manualmente; [,,] - Como será feito manualmente tem que colocar primeiro linhas, colunas e camadas, sendo 3 dimenssões uma fora que seria linha, outra dentro da linha sendo as colunas e outra dentro das colunas que seria as camadas; Então com o matrix.Rank você vai informar que vai ter 3 dimenssões nesse array.

/*
 * Ele é util pra quando você quer saber quantas dimenssões tem aquele array; 
 * 
 * Por exemplo:
 */
//int[,] exemploPratico = {{3,2,1},{1,2,3}}; //int - Tipo

//Console.WriteLine("Tem "+ exemploPratico.Rank + " Dimenssões");

/* 
 * 
 * Agora vamos falar sobre o .GetLength(0) ele pega a quantidade de linhas tem disposnivel no array multimenssional e o tridimenssional, .Get siginfica leitura -> Length -> Seria a contagem de elementos -> (0) informa que vai ser a dimenssão de fora, informando que vai ser a contagem de elementos tem disponivel nas linhas. 
 * 
 * EXEMPLO 
 * 
 * SINTAXE DE LEITURA 
 * 
 */

//int[,] exemploPraticoLinha = { { 1, 2, 3} }; //int - Tipo de dado do array;
//[,] - Aqui seria a matriz, informando que seria o array multidimenssional; exemploPraticoLinha - Seria o nome do array multidimenssional;
//= - Seria o resultado ou o valor que sera guardado;
//{{}} - Aqui informa a separação das dimenssões sendo a de fora de linha e a de dentro as colunas;
//1,2,3 - São os valores que serão guardados nas colunas; Sendo assim quando usar o .GetLength(0) que seria a contagem das linhas ele vai informar que tem somente 1;

//Console.WriteLine("Tem disponivel nesse array "+exemploPraticoLinha.GetLength(0)+" linhas!"); //Console.WriteLine() - Ele manda uma mensagem para o usuario no console, nesse caso ele vai informar quantas linhas tem usando o .GetLength(0);

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

//int[,] protecaoArrayMultidimensional = { {1,2,3,4 }, {4,3,2,1 } }; //int - Seria o tipo de dado do array;
//[,] - Seria uma matriz onde é usado somente no array multidimenssional;
//protecaoArrayMultidimenssional - Nome do array multidimenssional;
//= - Resultado o valor que será guardado;
//{{},{}} - Seria as dimenssões onde a de fora seria a linha e a de dentro seria a coluna;
//1,2,3,4 4,3,2,1 - Seria os valores guarados nas colunas sendo 4 colunas;
//Sendo assim o objetivo foi criar um array multimenssional com o tipo de dado int, onde vai se chamar protecaoArrayMultidimensional e que vai ja guardar 2 linha e 4 colunas.


//for (int i = 0; i < protecaoArrayMultidimensional.GetLength(0); ++i) //for - O for ele é um laço de repetição que tem inicio e fim e vai repetindo o incremento de ++i ou --1 pra chegar no ponto final que foi informado;
//int - Seria o tipo de dado do for;
//i = O primeiro i seria o valor inicial o segundo i seria o valor final;
//< - informa que será menor; protecaoArrayMultidimensional - Nome do array que foi criado e que será protegido pelo for;
//.GetLength(0) - Seria a contagem de linha que será feita;
//++i - Seria o incremento e nesse caso vai fazer repetição de incremento de +1;
//Sendo assim foi criado um for para criar um tabela que seria a matriz tendo a dimenssão que seria as linhas e esse for vai ter um tipo dado int, se chamando i, ele vai iniciar do 0 e vai usar o .GetLength(0) pra parar antes da contagem final das linhas então nesse caso ele vai repitir até o 1 e vai para por que a contagem de todas as linhas seria 2 ficando 0 , 1 e vai usar o incremento de +1 pra fazer a repetição do for;
//{
//for(int j = 0; j < protecaoArrayMultidimensional.GetLength(1); ++j  )//for - Seria um laço de repetição que tem inicio e fim e ele percorre pelo incio e fim incrementando ++j ou --j;
//int - Seria o tipo de dado do for; j - Seria o nome do incio e fim do laço de repetição;
//< - Seria o de operador lógico menor;
//.GetLength(1) - Seria a contagem de quantas colunas tem;
//++j - Ele informa de que forma será feito o incremento desse laço de repetição;
//Sendo assim foi criado uma segunda dimenssão que seria o da coluna, foi criado com o for pra fazer a mesma proteção que foi feita na primeira dimenssão da linha, o for ele vai ter o tipo de dado int onde vai se chamar J pois o I ja esta sendo usado pela linha, vai começar do 0 e vai usar o .GetLength(1) para finalizar 1 antes do total da contagem de colunas, nesse caso vai ser 4 colunas então vai parar no 3, então incremento vai seguir 0,1,2,3, e finalizando com o uso do incremento de +1 que seria o ++j; 
//{
//Console.WriteLine(protecaoArrayMultidimensional[i, j] + "\t"); //Console.WriteLine - Ele mostra uma mensagem na tela, nesse caso ele vai mostrar a quantidade linha e colunas tem nesse array multidimenssional;
//protecaoArrayMultidimensional[] - Seria a sintaxe de leitura do array multidimenssional;
//i, j - que vai mostra na tela todos os j e todos os i;
//Ele será usado para mostrar quantas linhas, colunas e os valores tem guardado nesse array multidimenssional.
//}
//Console.WriteLine(); //Console.WriteLine - Ele manda mensagem na tela do console, nesse caso ele só vai pular a linha mesmo;
//}

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
//int[,] exercicio = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }; //int - Seria o tipo de dado do array;
//[,] - Seria a matriz do array multidimenssional; exercicio - Seria o nome do array multidimenssional;
//{{},{},{}} - Seria a primeira dimenssão e a segunda dimenssão sendo a primeira para linha que seria a chave que fica para fora e segundo que seria para coluna que fica para dentro;
//Números - São os valores guardados nas colunas;
//Aqui esta sendo criado um array que tem o tipo de dado int e uma matriz que informa que vai ser um array multidimenssional, o nome do array multidimenssional vai se chamar exercicio e tera 3 linhas e 4 colunas conforme a divisão das dimenssões;

//3) pegar informações sobre a matriz
//int linha = exercicio.GetLength(0); //int - Seria o tipo de dado da variavel; linha - Seria o nome da Variavel; exercicio - é o nome do array; .GetLength(0) - É valor total da contagem de linhas disponivel; Nesse caso foi criado uma variavel com o tipo de dado int para guardar o total de linhas que tem disponivel no array de exercicio onde usou o .GetLength(0) que fez a contagem total das linhas;
//int coluna = exercicio.GetLength(1); //int - Seria o tipo de dado da variavel; coluna - Seria o nome da variavel; exercecicio - Seria o nome do array que vai ser chamado; . GetLength(1) - Seria a contagem total de colunas; Sendo assim ele vai fazer uma variavel chamada coluna e vai guardar um informação com o tipo de dado int e vai usar o .GetLength(1) para fazer a contagem de colunas disposnivel e o total dessa contagem vai ser o valor guardado;

//4) imprimir a matriz como uma tabela
//for(int i = 0; i < linha; ++i) //for - Ele seria um laço de repetição, tendo inicio e fim e pra chegar no fim ele repeti um incremento de ++1 ou --1 para conseguir chegar no final do for; int - Seria o tipo de dado que esse for vai guardar; i - Seria o nome do inicio e fim do for; < - Seria o operador de menor; linha - Seria a variavel que guardou o valor total da contagem de linhas que tem disponivel no array multidimenssional; ++i - Seria  a repetição do incremento e nesse caso ele vai repetir o +1 até chegar no final do for; Sendo assim foi criado o for para  a primeira dimensão que seria o da linha, ele vai ter o tipo de dado int e vai se chamar i, esse for vai começar no 0 e vai ter o incremento ++i que seria o incremento de +1 para chegar no menos linha que seria a variavel que guarda o valor total da contagem de linhas disponivel, tem 3 linhas então a contagem vai até o 2 sendo 0, 1 ,2;
//{
//for(int j = 0; j < coluna; ++j) //for - Seria um laço de repetição onde ele tem inicio e fim pra chegar no fim ele usa um incremento ++1 ou --1 repitindo ele até chegar no objetivo final;
//int - Seria o tipo de dado do for;
//j - Seria o nome do for; < - Seria o operador lógico menor;
//coluna - Seria o nome da variavel que foi criada para guardar o total da contagem de colunas disponivel no array;
//++i - Seria o incremento que será usado no array sendo o +1;
//Nesse caso ele esta fazendo o for da sengundo dimensão que seria da coluna, esse for vai guardar um tipo de dado int e vai ser chamar j como ja tem disponivel o i para segunda dimensão, o for vai começar pelo 0 e vai finalizar antes da variavel coluna que guarda o total da contagem de colunas diposnivel no array multidimenssional, finalizando no 3 = 0,1,2,3, e usou o incremento de +1 para repetir e chegar no objetivo final;
//{
//Console.WriteLine(exercicio[i , j] + "\t"); //Console.WriteLine - Manda uma mensagem no console do usuario;
//exercicio[,] - Aqui seria a sintaxe de leitura do array multidimenssional;
//i e j - Seria o nome dos for que foi criado para proteger a coluna e linha;
//Nesse caso foi criado um Console.WriteLine para mandar uma mensagem para o usuario no console e informou array que foi utilizado para mostrar os for que foi criado para as linhas e colunas da forma correta;
// }
//Console.WriteLine(); //Console.WriteLine - Ele manda uma mensagem para o usuario no console, nesse caso ele vai pular somente a linha;
//}

//5) somar cada coluna (exemplo de operação)
//for (int j = 0;j < coluna; ++j) //for - Seria um laço de repetição onde ele tem inicio e fim e pra chegar no final do for ele repete o incremento de ++1 ou --1 até chegar no objetivo final;
//int - Seria o tipo de dado que ele vai guardar;
//j - Seria o nome do for; 0 - Seria o valor inicial;
//< - informa o operador menor; coluna - Seria a variavel criada para guardar o valor total da contagem de colunas que tem no array exercicio, que será usado para informar o final do for que vai -1 do total da contagem;
//++j - Aqui seria o incremento que será usado para chegar no final que seria -1;
//Nesse caso foi feito um for para criar uma tabela de colunas, guardado um tipo de dado int e vai se chamar j, tendo o inicio no 0 e vai até um antes do valor guardado pela variavel coluna, e o incremento para repetir e chegar no objetivo final seria o ++j que seria o +1;
//{
//int somaColuna = 0; //int - Seria o tipo de dado da variavel;
//somaColuna - Seria o nome da variavel;
//= - Seria o de atribuição;
//0 - Seria o valor guardado para a variavel somaColuna;
//Nesse caso foi criado uma variavel somaColuna que tem o tipo de dado int e guadou o valor 0, para ser usado dentro do for a seguir, o por que ela não foi criada dentro do for foi pra ela não entrar no laço de repetição.

// for(int i = 0;i < linha; ++i) //for - Seria um laço de repetição onde tem inicio e fim e pra chegar no final ele usa a repetição do incremento de ++1 ou  --1 para chegar no objetivo final;
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

//{
//somaColuna += exercicio[i, j]; //somaColuna - Ela seria a variavel que foi criada la fora para inciar a soma dentro do for;
//+= - Ele pega os valores atribuidos ao array exercicio e soma todos eles e passa o valor total como atribuição para a variavel informada antes do operador +=;
//exercicio[,] - Seria o nome do array multidimenssional criado, e como tem a matriz do lado dele, esta indormando que ele vai fazer a leitura do total das informações que foi passado dentro dela;
//Sendo assim o somaColuna vai ser usado para somar todos os valores atribuidos ao i e o j que seria o valores guardados em todas colunas que tem nas linhas, mostrando o total da soma de um por um das colunas.
//Console.WriteLine($"Coluna {j} " + somaColuna); //Console.WriteLine - Seria uma mensagem enviada para o usuario no console; j - Seria os valores dos indices das colunas criados pelo for;
//somaColuna - Seria a soma de cada coluna que tem nas linhas;
//Nesse caso foi criado um Console.WriteLine para informar os indices das colunas e os valores da soma de cada coluna que tem nas linhas;
//  }

//}

/*
 * MATRIZ JAGGED 
 * 
 * A Matriz Jagged ela seria quase a mesma coisa que a matriz retangular que seria uma matriz perfeita, a matriz jagged ela já é um pouco mais livre em questão de colocar colunas nas linhas. Na matriz retangular ela vem com os dados fixo, como por exemplo matrixRetangular[3,2] aqui a coluna sepre vai ter 2 em cada linha. Ja na matriz jagged ela pode ter valores diversos de colunas. Segue abaixo exemplos de sintaxe
 * 
 * MATRIZ RETANGULAR 
 */

/*int[,] matrizRetangular = { {1,2,3,4 }, {1,2,3,4 }, {1,2,3,4 } }; //Você viu que namatriz retangular, tem que exatamente 4 colunas em cada linham, não pode te 2 3 e 4, se começou com 4 vai terminar com 4. Essa seria a perfeita. Usada para planilha, tabelas, mapas, matriz, coisas que precisam de calculos que batem. 

//MATRIZ JAGGED

int[][] matrizjagged = new int[3][]; //int - Seria o tipo de dado do array; [][] - Informa que será uma matriz jagged; matrizJagged - Seria o nome do arrya multidimenssional; new int - Declara os valores da primeira e da segunda dimensão; [3][]- Informando a quantidade de linhas vai ter disponivel; 

matrizjagged[0] = matrizjagged[1]; //matrizjagged[0] - Esta mostrando o indice da primeira dimensão começando pelo primero indice do matrijagged; = - Simbolo de atribuição; matrizjagged[1] - Aqui esta atribuindo ao indice 0 da primeira dimensão(linha) a coluna, como é um jagged eu poss informar qualquer valor, então eu vou começar com 1;
matrizjagged[1] = matrizjagged[3]; //matrizjagged[1] - Esta mostrando o indice 1 da primeira dimesão(linha); = - Simbolo de atribuição; matrizjagged[4] - Esta informando a quantidade de coluna que vai ter no indice da linha 1, informando que vão ter 4 colunas;
matrizjagged[2] = matrizjagged[2]; //matrizjagged[0] - Esta mostrando o indice 2 da primeira dimensão(linha);= - Simbolo de atribuição; matrizjagged[2] - Aqui esta atribuindo a quantidade de colunas vai ter no indice 2 da linha, sendo 2 ccolunas
*/
//

/*Você percebeu que no jagged as colunas é uma diferente da outra, essa é a diferença entre a normal, você pode atribuir o valor das linhas e futuramente atribuir o valores das colunas que vai em cada coluna, ja no retangular se começou com 3 as colunas vai finalizar com 3. No Jagged ele é usado pois ele guarda menos memoria, ele é mais facil de manuziar, por que os valores não precisa ser extamente igual. 
 * 
 */

/*EXERCICIOS*/

/*1. Criar e imprimir

Crie int[,] m = new int[2, 3];

Preencha com números qualquer e imprima como tabela.*/

/*Pseudocodigo
 * 
 * CRIAR E COLOCAR OS VALORES DO ARRAY MULTIDIMENSSIONAL MATRIZ RETANGULAR
 * 
 * 1 - Vou fazer a criação de um array multidimenssional matriz retangular;
 * 2 - Ele vai ter um tipo de dado int;
 * 3 - Ele vai se chamar exercicio1;
 * 4 - Iremos atribuir ele na primeira dimensão(linha) - 2 e na 2 dimensão(coluna) - 3;
 * 5 - Vamos fazer eles no formato pratico e não manual;
 * 6 - Finalizando da criação do array multidimenssional ;
 * 
 * CRIAR VARIAVEIS PARA FAZER A CONTAGEM DA PRIMEIRA E SEGUNDA DIMENSÃO DA MATRIZ RETANGULAR
 * 1 - Vamos criar um 2 variavel para fazer a contagem das linhas e das colunas;
 * 2 - Criar a primeira variavel, que vai ser para atribuir o valor da linha; 
 * 3 - Ela vai ter o tipo de dado int;
 * 4 - E vai se chamar linha;
 * 5 - Ela vai atribuir o exercicio1.GetLenght(0), que vai informar a contagem das linhas;
 * 6 - Após ter criado a primeira variavel, vamos para a segunda que vai guardar a contagem da segunda dimensão(Colunas);
 * 7 - Ela vai ter o tipo de dado int;
 * 8 - Vai se chamar coluna;
 * 9 - Vai atribuir a ela o exercicio1.GetLength(1), onde vai atribuir a contagem de elementos da coluna;
 * 10 - Finalizamos a criação das variaveis da contagem de linhas e contagem disposnivel na matriz retangular;
 * 
 * CRIAR O FOR QUE VAI CRIAR UMA TABELA PROTEGIDA QUE NÃO DE ERRO
 * 1 - Criar o for que vai chamar a primeira dimensão(linha);
 * 2 - Ele vai ter o tipo de dado int;
 * 3 - Ele vai se chamar i;
 * 4 - Ele vai começar pelo 0;
 * 5 - A finalização dele vai ser 1 a menos que a contagem de elementos da variavel linha, informando o ultimo indice da linha;
 * 6 - Ele vai repetir com incremento de +1 sendo o ++i;
 * 7 - Após ter criado a primeira variavel, vamos criar a segunda para a segunda dimensão da tabela que seria a coluna;
 * 8 - Dentro do for da primeira dimensão, vamos criar o segundo for;
 * 9 - Ele vai ter um tipo de dado int; 
 * 10 - Vai se chamar j;
 * 11 - Vai ter o inicio de 0;
 * 12 - E vai finalizar um número antes da variavel coluna, pois ele vai informar o indice da coluna;
 * 13 - FINALIZAÇÃO DE UM TAELA SEGURA E PROTEGIDA PELO FOR;
 * 
 * IMPRESSÃO DA TABELA
 * 1 - Vamos criar um Console.WriteLine();
 * 2 - Ele vai ficar dentro do for da segunda dimensão que vai ser a coluna; 
 * 3 - Ele vai atribuir o exercicio1[i, j], onde ele vai informar corretamente a tabela criada pelo exercicio1;
 * 4 - Testar se o codigo deu certo;*/
/*

int[,] exercicio1 = { { 1, 2, 3 }, { 3, 2, 1 } }; //int - Seria o tipo de dado do array multimenssionamatriz retangular;
                                                 //[,] - Aqui informa que vai ser uma array multidimenssional matriz retangular; exercicio1 - Esse é o nome da matriz retangular; = - Simbolo de atribuição;
                                                 //{{},{}} - Esse é o formato de atribuição de valores da matriz sendo 2 linhas e 3 colunas com os valores que serão guardados;
                                                 //Sendo assim aqui esta sendo criado um array multidimenssional matriz retangular onde vão ter 2 linhas e 3 colunas com os valores já usando o modo pratico

int linha1 = exercicio1.GetLength(0); // int - Seria o tipo de dado da variavel; linha1 - Seria o nome da variavel;
                                     // = - Simbolo de atribuição;
                                     // exercicio. - Informa que a proxima função vai tirar informações da matrizz retangular exercicio1;
                                     // .GetLength(0) - Aqui seria a função de contagem da primeira dimensão do array que seria linhas;
                                     // Sendo assim esta sendo criado uma variavel para guardar a contagem dos elementos das linhas na matriz retangular;

int coluna1 = exercicio1.GetLength(1); // int - Seria o tipo de dado da variavel;
                                      // coluna1 - Seria o nome da variavel;
                                      // exercicio1. - Esta informando que a função vai pegar as informações da matriz retangular exercicio1;
                                      // GetLength(1) - Esta informando que vai fazer a contagem das colunas disponivel na matriz retangular;
                                      // Sendo assim foi criado uma variavel, que tem o tipo de dado int e que se chama coluna1 vai atribuir a contagem de quantas colunas tem na matriz retangular exercicio1 usando a função GetLength(1).

for(int i=0; i < linha1;++i) // for - Seria um laço de repetição que tem inicio e fim e percorre por eles com um incremento de +1 ou -1 usando o ++i ou --i;
                            // int - Seria o tipo de dado;
                            // i = 0 - Seria o nome que for vai ter e esta atribuindo o incio dele;
                            // i < linha1 - Aqui esta informando que o i vai finalizar em um número menor que a variavel linha1;
                            // ++i - Informa que o incremento que vai percorrer o inicio e fim vai ser o +1;
                            // Sendo assim esta sendo criado o primeiro for pra transformar ele em uma tabela segura, esse for vai ser criado para a primeira dimensão que seria a linha, ele vai ter o tipo dado percorrido int, vai se chamar i e vai inciar a leitura no 0 e vai finalizar em um número menor que o valor que foi atribuido para a variavel linha1, e essa analise do incio ao fim vai ser feita com a repetição do +1 sendo o ++i;
{
   for(int j = 0; j < coluna1; ++j) // for - Ele seria um laço de repetição que tem inicio e fim e ele percorre pelo incio e o fim usando um incremento de +1 ou -1;
                                    // int - Seria o tipo de dado do for;
                                    // j = 0 - Aqui esta informando que o for vai se chamar j e vai inciar do 0;
                                    // j < coluna1 - Aqui informa que o for que se chama j vai finalizar a leitura um número antes da atribuição do valor da variavel coluna1;
                                    // ++i - E aqui é o gran finale ele esta usando o incremento de +1 para percorrer o inicio e o fim dessa lista;
                                    // Sendo assim o for j está sendo criado para criar a segunda dimensão que seria a coluna da tabela, ele vai ser usado para proteger o codigo e não quebrar, vai ter um tipo de dado int, vai se chamar j e vai iniciar do 0 e vai até 1 a menos da variavel coluna 1 e vai usar o incremento de ++j que seria o incremento de +1;
   {
       Console.WriteLine(exercicio1[i, j] + "\t"); //Console.WriteLine() - Ele informa que vai ser enviado uma mensagem no console pro usuario;
                                            //exercicio[i, j] - Informa os valores que foram criados nos for;
                                            //Sendo assim esse Console.WriteLine ele vai informar os valores da matriz retangular da forma correta usando os for que protege e a tabela; 
   }
   Console.WriteLine(" ");
}
*/
/*2. Somar linha

Para int[,] m = { {1,2,3}, {4,5,6} }, calcule a soma de cada linha.

Pseudocodigo

CRIAR O MULTIDIMENSSIONAL MATRIZ RETNAGULAR

1 - Ele vai ter um tipo de dado int;
2 - Vai se chamar exercicio 2;
3 - vai atribuir 2 linhas e 3 colunas;
4 - Finalizando a Criação do array multidimenssional matriz retangular;

CRIAR VARIAVEIS ONDE VAI GUARDAR A CONTAGEM DE ELEMENTOS DAS LINHA E DA COLUNA

1 - Criar a variavel que vai guardar a contagem da primeira dimensão(linha);
2 - Vai ter o tipo de dado int;
3 - Vai se chamar linha2;
4 - E vai atribuir a função .GetLength(0), chamando a matriz exercicio2;
5 - Após ter criado a primeira variavel, vamos criar a segunda que vai pra segunda dimensão da matriz retangular que seria a da coluna;
6 - Ela vai ter o tipo de dado int;
7 - Vai se chamar coluna2;
8 - Ela vai atribuir a função .GetLength(1) que vai chamar o exercicio2;
9 - Finalizando a criação das variaveis.

CRIAR A SOMA DA FORMA CORRETA

1 - Criar novamente 2 for 1 da primeira dimensão(linha) e o outro da segunda dimensão(coluna);
2 - Criando o prieiro for que vai ser linha, por que ela que será calculada;
3 - Ela vai continuar se chamando i;
4 - Vai ter inicio no 0;
5 - Vai finalizar um número antes da variavel linha2;
6 - Após ter criado o for da primeira dimensão, precisamos criar a variavel somaExercicio2, por que ela não pode ir na segunda dimensão pois será la que vai ser feito a conta;
7 - Criando variavel dentro do for da primeira dimensão;
8 - Ela vai se chamar somaExercicio2;
9 - Após ter criado a variavel vamos criar a segunda dimensão que vai ser a coluna;
10 - Criando o segundo for dentro do primeiro e depois da variavel somaExercicio2;
11 - Vai ter o tipo de dado int;
12 - Vai se chamar j;
13 - Vai iniciar do 0; 
14 - Vai finalizar um número antes da variavel coluna2; 
15 - O incremento desse for vai ser o +1; 
16 - Finalizando o for da segunda dimensão, vamos fazer o calculo dentro dela; 
17 - Vamos chamar a variavel somaExercicio2; 
18 - Vamos atribuir a ela +=, por que ele faz a soma completa da variavel, vetor ou matriz que for informado, todo valor que estiver la dentro ele vai somar;
19 - Após escolher o simbolo de atribuição, vamos informar o que será calculado; 
20 - exercicio2[j], onde ele vai calcular o valores de todas as colunas que for informado a linha;
21 - Após ter finalizado o calculo vamos imprimir ele na tela; 
22 - Vamos chamar um console.Writeline podendo atribuir variaveis dentro dele; 
23 - Mandar a seguinte mensagem - Linha {i} + tem um valor total guardado de + somaExercicio2;
24 - Testar esse pseudocodigo na pratica; 
*/

/*
int[,] exercicio2 = { { 5, 5, 5 }, { 5, 5, 5 } }; //int - Tipo de dado do array multidimenssional matriz retangular;
                                                  //[,] - Informa que vai ser uma matriz retangular; exercicio2 - Seria o nome da matriz retangular;
                                                  //= - Seria o sinal de atribuição;
                                                  //{{},{}} - Seria a quantidade da primeira dimensão que seria as linhas, nesse caso tem 2;
                                                  //5,5,5  5,5,5 - Seria a quantidade de colunas que tem disponivel;
                                                  //Nesse caso está sendo criado um array multidimenssional matriz retangular que vai ter o tipo de dado int e vai se chamar exercicio2, ela vai ter 2 linhas que seria a primeira dimensão e 3 colunas que seria a 3 dimenssão;

int linha2 = exercicio2.GetLength(0); //int - Seria o tipo de dado da variavel;
                                      //linha2 - Seria o nome da variavel;
                                      //= - Sinal de atribuição; exercicio2.
                                      //- Seria a matriz que esta sendo chamada;
                                      //GetLength(0) - Seria a primeira dimensão onde faz as contagens das linhas;
                                      //Sendo assim foi criado a contagem de elementos tem na primeira dimenssão que seria as linhas, ela vai ter um tipo de dado int, e vai se chamar linha2 vai ter o resultado exercicio2 e vamos usar o .GetLength(0) para fazer a contagem, assim ele vai guardar dentro dessa variavel a quantidade de elementos tem na primeira dimenssão.
int coluna2 = exercicio2.GetLength(1); //int - Seria o tipo de dado;
                                       //coluna2 - Seria o nome do array multidimenssional matriz retangular;
                                       //= - Sinal de resultado;
                                       //exercicicio2 - Seria o nome do array multidimentssional matriz retangular;
                                       //GetLength(1) - Aqui informa que vai fazer a contagem dos elementos das colunas;
                                       //Sendo assim esta sendo criado uma variavel chamada coluna2, que tem o tipo de dado int, que vai puxar do exercicio2 e vai usar a função GetLength(1) pra fazer a contagem dos indices que tem na segunda dimenssão que seria a coluna.



for (int i = 0; i < linha2; ++i) //for - Seria uma laço de repetição que tem inicio e fim e para percorrer entre o inicio e o fim ele usa o incremento de ++1 ou --1;
                                 //int - Ele vai ter um tipo de dado int;
                                 //i = 0 - Ele vai começar do 0;
                                 //i < linha2 - E vai terminar 1 a menos que do valor que foi guardado na variavel linha2;
                                 //++i - Esse seria o incremento do for, que faz percorrer entre o inicio e o fim, ele seria o +1 até chegar no número final;
                                 //Nesse caso esta sendo criado um for pra criar uma tabela segura, onde não tem a possibilidade de passar o limite da primeira dimenssão dessa tabela;
                             
{
    int somaCalculo2 = 0; // int - Seria o tipo de dado da variavel;
                          // somaCalculo2 - Seria o nome da variavel que foi criada;
                          // = - Seria o operador de atribuição; 0 - Sera o valor inicial dessa variavel;
                          // Nesse caso foi criado uma variavel antes do segundo for que vai ser para segunda dimenssão pra não ter que ficar 0o valor cada vez que ele rodar;
    for (int j = 0; j < coluna2; ++j) //for - Seria um laço de repetição onde tem inicio e fim e ele percorre entre esse inicio e fim usando um incremento de ++1 ou --1;
                                      //int - Esse é o tipo de dado que vai ser o for;
                                      //j = 0 - Seria o nome e o inicio do for;
                                      //j < coluna2 - vai ser onde vai para que vai ser um número antes do total de contagem de quantas colunas tem nessa tabela;
                                      //Nesse caso esta usando o for, pra criar a segunda dimenssão que seria a coluna, esse for vai ter o tipo de dado int, vai iniciar no 0 e vai finalizar um número antes da contagem de elementos tem na coluna, para que não ultrapasse os indices da coluna dessa tabela e vai utilizar o ++j para fazer o incremento de +1 até chegar aonde foi desejado;
    {
        somaCalculo2 += exercicio2[i, j];//somaCalculo2 - Seria a variavel que foi criada fora do for da coluna;
                                         //+= - Ele seria um operador logico onde soma todos os valores que tem guardado no array, por exemplo nesse caso ele vai somar todos os valores que foram guardados na coluna e i esta ali por que? Se ele seria a linha, por que pra chegar no j que seria a coluna ele tem que entrar no i;
    }
    Console.WriteLine($"linha {i} tem o valor total de {somaCalculo2}"); // Console.WriteLine - Seria uma mensagem que é enviada para o usuario no console;
                                                                         // Nesse caso ele vai mandar que na linha tal vai ter o total de tal valor.
}*/

/*3. Diagonal (só para quadrada)

Se você tiver int[,] q = new int[3,3], imprima q[0,0], q[1,1], q[2,2] (diagonal principal) e some esses valores.
*/

/*EXERCICIOS
 * 
 * PSEUDOCÓDIGO
 * 
 * CRIANDO O ARRAY MULTIDIMENSSIONAL MATRIZ RETANGULAR 
 * 
 * 1 - Ele vai ter o tipo de dado int;
 * 2 - Vai se chamar exercicio3;
 * 3 - Vai ter 3 linhas e 3 colunas;
 * 4 - Seguindo os valores no enunciado;
 * 
 * CRIAR VARIAVEIS PARA GUARDAR OS VALORES 
 * 
 * 1 - Vamos começar pela primeira variavel; 
 * 2 - Ela vai ter o tipo de dado int;
 * 3 - Vai se chamar n1, vamos começar por ela, por ser o primeiro valor que será guardado; 
 * 4 - Vai atribuir exercicio3[0,0]; 
 * 5 - Vai criar uma segunda variavel para guardar o segundo valor;
 * 6 - Vai ser tipo dado int;
 * 7 - Vai se chamar n2;
 * 8 - Vai atribuir o valor exercicio3[1, 1];
 * 9 - Vamos agora criar a terceira variavel par aguardar o valor; 
 * 10 - Ela vai ter o tipo de dado int; 
 * 11 - Ela vai se chamar n3;
 * 12 - Vai atribuir o valor exercico3[2, 2];
 * 13 - E vamos criar a variavel que vai guardar o resultado da soma; 
 * 14 - Ela vai ter o tipo de dado int; 
 * 15 - Vai se chamar soma; 
 * 16 - Vai atribuir a soma do n1, n2, n3; 
 * 17 - Vai criar um console.WriteLine;
 * 18 - E vai informar o resultado da soma, usando a variavel;
 * 
 */

/*

int[,] exercicio3 = { {0,1,2}, {0,1,2}, {0,1,2} }; //int[,] - Informa que vai ser criado um array multidimenssional matriz retangular;
                                                   //exercicio3 - Vai se chamar exercicio3;
                                                   //{{,,,},{,,,},{,,,},} - Aqui esta informando que vai ter 3 linhas que é a primeira chave { sendo a primeira dimensão e a quantidade de valores que tem dentro das 3 chaves aberta e fechada vai ser as colunas;
                                                   //Nesse caso esta sendo criado um array multidimenssional matriz retangular, onde vai ter o tipo de dado int, vai se chamar exercicio3 e tem 3 linhas e 3 colunas com o valor que será guardado já informado.

Console.WriteLine(exercicio3[0,0]); //Console.WriteLine - Aqui vai mandar uma mensagem na tela do console. Nesse caso vai informar os valores que estão sendo guardados no indice 0 da linha e no indice 0 da coluna;
Console.WriteLine(exercicio3[1,1]); //Console.WriteLine - Aqui vai ser enviado uma mensagem no console. Nesse caso vai ser enviado o valor que esta sendo guardado no indice 1 da linha e no indice 1 da coluna;
Console.WriteLine(exercicio3[2,2]); //Console.WriteLine - Aqui vai mandar uma mensagem no cosole. Nesse caso vai informa o valor que foi guardado no indice 2 da linha e no indice 2 da coluna;

int n1 = exercicio3[0,0]; // int - Seria o tipo de dado da variavel;
                          // n1 - Seria o nome da variavel;
                          // = - Seria o sinal de atribuição;
                          // exercicio3[0,0] - Seria o valor que vai ser atribuido para a Variavel;
                          // Nesse caso a variavel n1 que tem o tipo de dado int vai atribuir o valor que foi guardado no array multidimenssional matriz onde ele vai pegar o valor do indice 0 da linha e o indice 0 da coluna;
int n2 = exercicio3[1, 1];// int - Seria o tipo de dado da variavel;
                          // n2 - Seria o nome da variavel; = - Seria o sinal de atribuição;
                          // exercicio3[1,1] - Seria o valor que foi guardado no array que vai ser atribuido para essa variavel;
                          // Nesse caso foi criado uma variavel chamada n2 que tem o tipo de dado int, e que vai atribuir o indice 1 da linha e o indice 1 da coluna do array matriz chamado exercicio3 que foi criado antes;
int n3 = exercicio3[2, 2]; //int - Seria o tipo de dado;
                           //n3 - Seria o nome da variavel;
                           //= - Seria o operador de atribuição;
                           //exercicio3[2,2] - Esse seria os indice dos valores do array matriz que vai ser atribuido a esta variavel;
                           //Nesse caso foi criado a variavel n2 que tem o tipo de dado int, ela vai atribuir o valor do indice 2 da linha e o indice 2 da coluna da array matriz retangular exercicio3 que foi criado anteriormente;
int soma = n1 + n2 + n3; //int - Seria o tipo de dado da variavel;
                         //soma - Seria o nome da variavel;
                         //= - Operador de atribuição;
                         //n1 + n2 + n3 - Ele vai pegar os valores dessas variaveis e vai somar tudo para atribuir o resultado para a variavel soma;
                         //Nesse caso foi criado uma variavel chamada soma que tem o tipo de dado int e que esta atribuindo a soma das variaveis n1 n2 n3 pra tornar o valor dessa variavel;

Console.WriteLine($"Resultado da soma é {soma}"); //Console.WriteLine - Aqui vai mandar uma mensagem para o usuario no console; Nesse caso ele vai usar uma interpolação de string onde ele vai usar uma variavel no meio da frase e vai lançar o resultado na tela com uma frase colocada no console.WriteLine;
*/

/*FORMAR COM LOOP*/
/*PSEUDOCÓDIGO
 * 
 * CRIANDO O ARRAY MULTIDIMENSSIONAL MATRIZ RETANGULAR 
 * 
 * 1 - Ele vai ter o tipo de dado int;
 * 2 - Vai se chamar exercicio3L;
 * 3 - Vai ter 3 linhas e 3 colunas;
 * 4 - Seguindo os valores no enunciado;
 * 
 * CRIAR VARIAVEIL PARA CONTAR ELEMENTOS DA LINHA
 * 
 * 1 - Ela vai ter o tipo de dado int;
 * 2 - Vai se chamar linha;
 * 3 - Vai atribuir o array exercicio3L e a função Get.Length(0), para fazer a contagem de quantos elementos tem na linha; 
 * 
 * CRIAR VARIAVEL PARA FAZER A SOMA DENTRO DO LOOP
 * 
 * 1 - Ele vai ter um tipo de dado int; 
 * 2 - Ele vai se chamar soma1;
 * 3 - Ele vai atribuir o valor inicial 0
 * 
 * CRIAR A TABALA PRA FAZER O PRINT SOLICITADO
 * 
 * 1 - Vamos criar o primeiro for, que vai ser da primeira dimenssão que vai ser a linha; 
 * 2 - Ele vai ter o tipo de dado int; 
 * 3 - Vai se chamar l;
 * 4 - Vai começar no 0; 
 * 5 - Vai finalizar um número a menos que o valor atribuido a variavel linha; 
 * 6 - Ele vai ter o incremento de +1;
 * 7 - Dentro do for l, vamos fazer a soma 
 * 8 - Vamos chamar a variavel soma, atribuindo o operador lógico +=; 
 * 9 - E vai chamar os principais valores diagonal da matriz; 
 * 10 - Que vai ser as duas linhas [l, l] -> EXPLICAÇÃO 
 * 
 * Quando você faz somente um for da primeira dimensão e repete ele no console.writeline(exercicio3L[l,l])
 * 
 * saída
 * 
 * linha    Coluna
 * 0        0
 * 1        1
 * 2        2
 * 
 * Mas quando você cria as duas dimensão ele vai sair a tabela completa Console.WriteLine(exercicio3L[i, j])
 * 
 * linha    Coluna 
 * 0        0    
 * 0        0   
 * 0        0
 * 1        1
 * 1        1
 * 1        1
 * 2        2
 * 2        2
 * 2        2
 * 
 * Por isso que tem que fazer no primeiro formato pra pegar o valor correto da diagonal.
 * 
 * Usando esse valor ele 
 */
/*
int[,] exercicio3L = { { 0, 1, 2 }, { 0, 1, 2 }, { 0, 1, 2 } }; //int - Seria o tipo de dado do array matriz retangular; 
                                                                //[,] - Aqui esta informando que sera um array multidimenssional matriz retangular;
                                                                //= - Operador de atribuição;
                                                                //{{,,,},{,,,},{,,,}} - Aqui seria a primeira e a segunda dimensão criada, onde a primeira seria a linha que seria a chave que esta fora {{}{}{}}, ja a coluna seria a segunda dimensão sendo a quantidade de valores que estão dentro das linhas;
                                                                //Nesse caso esta sendo criado uma array multidimenssional matriz retangular que se chama exercicio3L e que tem o tipo de dado int, e tem 3 linhas e 3 colunas com valores já sendo informados;
int soma1 = 0;//int - Seria o tipo de dado da variavel;
              //soma1 - Seria o nome da variavel;
              //= - Seria o valor que sera atribuido a esta variavel;
              //Nesse caso esta informando que será criado uma variavel chamada soma1 e que tem o tipo de dado int e foi atribuido um valor inicial 0, para ser usado futuramente para guardar o resultado da soma;

int linha = exercicio3L.GetLength(0); //int - Seria o tipo de dado da variavel;
                                      //linha - Seria o nome da variavel;
                                      //= - Seria o sinal de atribuição;
                                      //exercicio3L - Esta informando que o array multidimenssional matriz retangular chamado exercicio3L vai ser usado nessa variavel;
                                      //GetLength(0) - Aqui esta sendo informado que vai ser utilizado uma função que faz contagem de elementos que disponivel na linha ou na coluna como o () esta com um 0 como regra ele vai contar a quantidade de elementos que tem na linha;
                                      //Nesse caso foi criado uma variavel que vai se chamar linha e vai ter o tipo de dado int, ela vai atribuir o valor total da contagem de elementos que tem na matriz exercicio3L usando a função GetLength(0);

for(int l = 0;l < linha;l++) //for - Seria um laço de repetição onde ele tem inicio e fim e para percorrer entre o inicio e fim ele usa o incremento de +1 ou -1;
                             //int - Seria o tipo de dado do for;
                             //l - Seria o nome do for; l = 0 - Aqui esta informando que o inicio vai ser no 0;
                             //l < linha - E aqui esta informando que o final vai ser um antes do total de elementos tem na linha;
                             //l++ - Esta informando que vai ter um incremento de +1;
                             //Nesse caso foi criado um for pra criar uma matriz onde tem a primeira e a segunda dimensão, como aqui só vai somar q[0,0], q[1,1], q[2,2], criamos somente a primeira dimensão, para conseguir somar somente os indices repetidos de ambos linha e coluna;

{
    Console.WriteLine(exercicio3L[l,l]); //Console.WriteLine - Seria uma mensagem que sera enviada para o usuario no console;
                                         //Nesse caso vai informar que vai ser indice 0 da linha e o indice 0 da linha porém e ao invés de ser linha vai ser a coluna, por que ela vai tomar o lugar da coluna, fazendo que os dois indices se repitam e consiga finalizar a soma;
    soma1 += exercicio3L[l, l]; //soma1 - Seria a variavel que foi criada anteriormente;
                                //+= - Aqui seria o operador lógico ele soma todos valores que foi atribuido a esta varivel e retorna somente o valor total;
                                //Nesse caso foi criado uma variavel anteriormente antes do for ser criado, para ela não perder os valores que serão salvo nesta variavel toda vez que rodar um incremento de +1, e usou o operador lógico += que vai somar todos os valores que tem dentro do indice l, l (Que seriam indices repetidos tanto em linha quanto coluna) e vai retornar o valor total para guardar na variavel soma1;
}

Console.WriteLine($"Resultadoda soma é {soma1}"); //Console.WriteLine - Ele seria uma mensagem que será enviado no console para o usuario;
                                                  //Nesse caso será usado o $ para informar que será feito uma interpolação na string, vindo uma mensagem o valor que foi guardado na variavel soma1;
*/

/*4. Busca

Peça um valor ao usuário e imprima todas as posições (i,j) onde o valor aparece.*/

/*PSEUDOCÓDIGO
 * 
 * CRIAR O ARRAY 
 * 
 * 1 - Ele vai ser um int; 
 * 2 - Vai se chamar exercicio4
 * 3 - Vai atribuir os valores já na criação do array;
 * 4 - Ele vai ter 3 linhas e 3 colunas;
 * 5 - Valores 1, 2, 3 em todas;
 * 
 * CRIANDO VARIAVEL PARA CONTAGEM DE ELEMENTO LINHA E COLUNA 
 * 
 * 1 - A primeira a ser criada vai ser a linha por ser a primeira dimensão; 
 * 2 - Ela vai ter o tipo de dado int;
 * 3 - Ele vai se chamar linha
 * 4 - Vai atribuir
 * 5 - Vai chamar o array que vai ser usado que é exercicio4;
 * 7 - Vai usar a função GerLength(0) para fazer a contagem de elementos;
 * 8 - A segunda a ser criada vai ser a coluna por ser a segunda dimensão;
 * 9 - Ela vai ter o tipo de dado int;
 * 10 - Vai se chamar coluna;
 * 11 - Vai usar o operador de atribuição;
 * 12 - Vai chamar o array que vai ser utilizado sendo o exercicio4;
 * 13 - Vai usar a função de contagem de elementos de coluna GerLength(1);
 * 
 * CRIANDO A VARIAVEL QUE GUARDA A RESPOSTA DO USUARIO
 * 
 * 1 - Ela vai ter o tipo de dado int; 
 * 2 - Vai se chamar vu - Valor do usuario;
 * 3 - E vai guardar o valor 0, por que ela vai ser usada futuramente;
 * 
 * CRIANDO A PERGUNTA PARA O USUARIO
 * 
 * 1 - Usar o Console.WriteLine();
 * 2 - Dentro vai ter a seguinte mensagem, me informe o valor que você busca na matriz;
 * 3 - Vai guardar na variavel vu;
 * 4 - Como é um int, vai ter que usar o int.Parse(Console.ReadLine()), para avisar que não vai ser string e sim int;
 * 
 * CRIANDO UM BOOL PARA VERIFICAR SE EXISTE OU NÃO O VALOR INFORMADO
 * 
 * 1 - Ele vai ter o tipo de dado bool;
 * 2 - Vai se chamar na;
 * 3 - Ele vai começar como false, para informar se não achar ele vai continuar false, usando ele fora da matriz criada para informar ao usuario que não foi encontrado;
 * 
 * CRIANDO A PRIMEIRA DIMENSÃO DA MATRIZ
 * 
 * 1 - Vai usar o for pra criação da primeira dimensão da matriz que seria a linha;
 * 2 - Ele vai ter o tipo de dado int;
 * 3 - Vai se chamar i;
 * 4 - Vai ter inciar no 0;
 * 5 - Vai finalizar um antes da variavel linha;
 * 6 - Vai usar o incremento de ++i;
 * 
 * CRIANDO A SEGUNDA DIMENSÃO DA MATRIZ 
 * 
 * 1 - Vai usar o for, mas esse for vai ficar dentro do for para a primeira dimesão linha, sendo o segundo for para coluna;
 * 2 - Vai ter um tipo de dado int;
 * 3 - Vai se chamar j;
 * 4 - Vai iniciar no 0;
 * 5 - Vai finalizar um antes da variavel coluna;
 * 6 - Vai usar o incremento de ++j;
 * 
 * CRIANDO O IF DENTRO DA MATRIZ PARA CASO O VALOR EXISTA NA MATRIZ
 * 
 * 1 - Primeiro criar um if;
 * 2 - SE o vu FOR == aos valores exercicio4[i, j];
 * 3 - Ele vai rodar o bloco de código
 * 
 * BLOCO DE CÓDIGO DO IF
 * 
 * 1 - Vai ter um Console.WriteLine();
 * 2 - Dentro do texto vai ter a interpolação para pegar valores guardados de fora $;
 * 3 - O texto vai ficar dessa forma $"Esse valor existe na matriz, sendo a linha {i} e a coluna {j} tendo o resultado {vu}"
 * 4 - Caso esse bloco de codigo rode, o bool na vai se transformar em true, caso aocontrario ele vai continuar false;
 * 
 * CRIANDO UM IF FORA DA MATRIZ PARA CASO O NÚMERO NÃO EXISTA COMO VALOR GUARDADO NA MATRIZ
 * 
 * 1 - Vai criar um IF;
 * 2 - Esse IF vai ser SE o na FOR == FALSE, vai rodar o bloco de código abaixo;
 * 
 * DENTRO DO BLOCO DE CÓDIGO DO IF CASO O NÚMERO NÃO EXISTA COMO VALOR DENTRO DA MATRIZ
 * 
 * 1 - Criar um Console.WriteLine;
 * 2 - Ele vai ter como texto guarda "Esse número não foi encontrado na matriz";
 */
/*
//CRIAR O ARRAY 
int[,] exercicio4 = { { 1, 2, 3 }, {1, 2, 3 }, {1, 2, 3 } }; //int - Seria o tipo de dado do array;
                                                             //[,] - Aqui ele esta informando que vai ser um array multidimenssional matriz retangular;
                                                             //exercicio4 - Vai ser o nome da matriz retangular;
                                                             //= - Sinal de atribuição; {{}{}{}} - Quantidade de linhas que vai ter nessa matriz;
                                                             //1, 2, 3  1, 2, 3  1, 2, 3 - Aqui seria a quantidade de colunas vai ter e os valores guardados;
                                                             //Sendo assim aqui esta sendo criado um array multidimenssional matriz retangular que vai ter um tipo de dado int e vai se chamar exercicio4 vai ter um sinal de atribuição sendo 3 linhas e 3 camadas e os valores já serão guardados;

//CRIANDO VARIAVEL PARA CONTAGEM DE ELEMENTO LINHA E COLUNA 
int linha = exercicio4.GetLength(0); //int - Seria o tipo de dado da variavel;
                                     //linha - Seria o nome da variavel;
                                     //= - Sinal de atribuição;
                                     //exercicio4 - Aqui está chamando a matriz que vai ser usado a função;
                                     //GetLength(0) - Seria a função de contagem de elementos da primeira dimensão sendo a linha;
                                     //Sendo assim aqui esta sendo criado uma variavel que tem o tipo de dado int e que se chamar linha, tem o sinal de atribuição onde vai chamar a matriz exercicio4 e vai usar nela a função GerLength(0) onde faz a contagem de elementos que tem na primeira dimensão que seria a linha, guardando o total dessa contagem;
int coluna = exercicio4.GetLength(1); //int - Seria o tipo de dado da variavel;
                                      //coluna - Seria o nome dela; = - Seria o sinal de atribuição;
                                      //exercicio4 - Aqui está chamando a matriz;
                                      //GerLength(1) - Aqui seria a função que faz a contagem de quantos elementos que tem na segunda dimensão do array exercicio4;
                                      //Sendo assim foi criado uma variavel que tem o tipo de dado int e que se chama coluna, para atribuir a função GetLength(1) que vai chamar o array exercicio4 para fazer a contagem de elementos da segunda dimensão que vai ser a coluna, guardando o total dessa contagem;

//CRIANDO A VARIAVEL QUE GUARDA A RESPOSTA DO USUARIO
int vu = 0;//int - Seria o tipo de dado da variavel;
           //vu - Seria o nome da variavel;
           //= - Seria o sinal de atribuição;
           //0 - Seria o valor que será guardado;
           //Sendo assim aqui esta sendo criado uma variavel que vai guardar o valor que vai ser informado pelo usuario;
//CRIANDO A PERGUNTA PARA O USUARIO
Console.WriteLine("Qual valor você procura?"); // Console.WriteLine() - Seria uma mensagem que é enviada para o usuario no console;
                                               // Sendo assim ele está perguntando qual valor ele procura na matriz, sendo o valor que vai ser guardado na variavel vu para ser usado futuramente;
vu = int.Parse(Console.ReadLine());//vu - Seria o nome da variavel que vai guardar o valor que vai ser informado pelo usuario; int.Parse - Aqui ele está informando que vai ser int e não uma string;
                                   //Console.ReadLine() - Aqui ele vai fazer a leitura da informação que vai ser passada e vai transformar o tipo de dado de string para int;
                                   //Sendo assim aqui esta informando onde vai ser guardado o valor passado pelo usuario e vai transformar o tipo de dado guardado de string para int;

//CRIANDO UM BOOL PARA VERIFICAR SE EXISTE OU NÃO O VALOR INFORMADO
bool na = false; //bool - Seria o tipo de dado da variavel;
                 //na - Seria o nome da variavel; = - Sinal de atribuição;
                 //False - Valor inicial atribuido a variavel;
                 //Nesse caso foi criado uma variavel que tem o tipo de dado bool onde vai ser false ou true, vai ser atribuido o valor false onde vai continuar caso o true não seja acionado;

//CRIANDO A PRIMEIRA DIMENSÃO DA MATRIZ
for (int i = 0; i < linha; ++i) //for - Seria um laço de repetição onde tem inicio e fim e ele percorre essse inicio e fim com incremento de +1 ou -1;
                                //int - Seria o tipo de dado atribuido ao for;
                                //i - Seria o nome do for;
                                //i = 0 - Seria o valor inicial;
                                //i < linha - Seria o valor final sendo um valor antes do valor guardado na variavel linha;
                                //++i - O incremento que será usado vai ser o de +1;
                                //Sendo assim foi criado um for para criar a primeira dimensão que vai ser a linha ele vai ter o tipo de dado int, vai se chamar i e vai iniciar no 0 e vai finalizar um número antes da variavel linha, usando um incremento de +1 para percorrer corretamente esse laço de repetição;
{
    //CRIANDO A SEGUNDA DIMENSÃO DA MATRIZ
    for (int j = 0; j < coluna; ++j) //for - Seria um laço de repetição onde ele tem inicio e fim e ele percorre entre esse inicio e fim usando o incremento de +1 ou -1;
                                     //int - Seria o tipo de dado do for;
                                     //j - Seria o nome do for;
                                     //j = 0 - Seria o valor inicial do for;
                                     //j < coluna - Seria o valor final do for onde ele vai terminar um número antes da variavel coluna;
                                     //j++ - Aqui seria o incremento que vai ser usado no for sendo +1 para chegar no final do laço;
                                     //Sendo assim foi criado o for da segunda dimensão sendo o da coluna, ele tem o tipo de dado int, vai se chamar j por que o i esta sendo usado pelo primeiro for, vai iniciar no 0 e vai finalizar um número antes da variavel coluna, e vai utilizar o incremento de +1;

        //Finalizando a segunda dimensão da matriz está sendo criado a matriz onde vai ter linha e colunas.
    {
            //CRIANDO O IF DENTRO DA MATRIZ PARA CASO O VALOR EXISTA NA MATRIZ
            if (vu == exercicio4[i, j]) //if - Seria o SE, se a informação passada estiver dentro do meus paramentros e regras ele vai rodar o meu bloco de código;
                                        //() - Seria onde fica os parametros e regras;
                                        //vu - Seria o valor informado pelo usuario;
                                        //== - Seria o operador de igualdade;
                                        //exercicio4[i, j] - Aqui esta solicitando que seja passado o for nos valores guardados pela matriz;
                                        //Sendo assim esse IF esta sendo criado para verificar SE o valor informado pelo usuario que foi guardado na variavel VU existe nos valores da matriz exercicio4 por isso ele percorre pelos valores, se existir ele vai rodar o seu bloco de código;
            {
                //BLOCO DE CÓDIGO DO IF
                Console.WriteLine($"Esse valor existe na matriz, sendo a linha {i} e a coluna {j} tendo o resultado {vu}"); //Console.WriteLine - Seria uma função que envia uma mensagem para o usuario;
                //Nesse caso se rodar esse bloco de código, ele vai informar todas posições de linha e coluna que guarda o valor informado;
                na = true; //na - Seria o nome da variavel;
                           //= - Sinal de atribuição;
                           //true - Seria o valor novo que será guardado na variavel;
                           //Nesse caso SE rodar esse bloco de código o na que era false vai se tornar true informando que esse valor existe na matriz;
            }
    }   
}
//CRIANDO UM IF FORA DA MATRIZ PARA CASO O NÚMERO NÃO EXISTA COMO VALOR GUARDADO NA MATRIZ
if (na == false) //if - Seria o SE, se a informação passada seguir regras do meu parametros irei rodar o meu bloco de código;
                 //na - Seria o nome da variavel;
                 //== - Sinal de igualdade;
                 //false - Seria o valor da variavel na;
                 //Nesse caso esta sendo o usado if para informar SE o na for == a false ele vai rodar o bloco de código abaixo, então ele está sendo usado para caso não exista esse valor dentro da matriz;
{
    //DENTRO DO BLOCO DE CÓDIGO DO IF CASO O NÚMERO NÃO EXISTA COMO VALOR DENTRO DA MATRIZ
    Console.WriteLine("Esse número não foi encontrado na matriz"); //Console.WriteLine - Seria uma mensagem que é enviada para o usuario dentro do console;
                                                                   //Nesse caso ele vai informar que o valor informado não existe dentro da matriz;
}
*/
/*5. Transposta (desafio)

Dada int[,] a = { {1,2,3}, {4,5,6} } (2x3), crie int[,] b = new int[3,2] e escreva a transposta (invertendo linhas/colunas).
*/

/*
 * PSEUDOCÓDIGO
 * 
 * CRIAÇÃO DO ARRAY MULTIDIMENSSIONAL - Primeiro
 * 
 * 1 - Ele vai ter um tipo de dado int;
 * 2 - Vai se chamar a;
 * 3 - Vai atribuir os valores da linha e da coluna;
 * 
 * CRIAÇÃO DO ARRAY MULTIDIMENSSIONAL - Segundo
 * 
 * 1 - Ele vai ter o tipo de dado int;
 * 2 - Vai chamar o array multidimenssional [,];
 * 3 - Vai se chamar b;
 * 4 - Como ele vai ser usado para receber as informações do a, ele vai vim no formato manual podendo inserir um valor futuramente;
 * 5 - Ele vai ter 3 linhas e 2 colunas;
 * 
 * CRIANDO VARIAVEL PARA GUARDAR A QUANTIDADE DE LINHA 
 * 
 * 1 - Vai ter o tipo de dado int; 
 * 2 - Vai se chamar linha; 
 * 3 - Vai ter o operador de atribuição; 
 * 4 - Vai chamar a matriz a;
 * 5 - Vai utilizar a o GetLength(0), para vim com o total de linha que tem nessa matriz; 
 * 
 * CRIANDO VARIAVEL PARA GUARDAR A QUANTIDADE DE COLUNA
 * 
 * 1 - Vai ter o tipo de dado int; 
 * 2 - Vai se chamar coluna; 
 * 3 - Vai ter o operador de atribuição; 
 * 4 - Vai chamar a matriz a; 
 * 5 - Vai usar a função GetLength(1), para vim com o total de coluna que tem na matriz a;
 * 
 * CRIANDO A MATRIZ "a" DE FORMA SEGURA 
 * 
 * 1 - Primeiro criar o for da LINHA, que seria a primeira dimensão; 
 * 2 - Esse for vai ter o tipo de dado int; 
 * 3 - Vai se chamar i; 
 * 4 - Vai começar no número 0;
 * 5 - E vai finalizar um número antes da variavel linha; 
 * 6 - Vai usar o inchemento de +1 sendo ++i;
 * 7 - Agora dentro do mesmo for, vamos criar o segundo for que seria a segunda dimensão sendo a coluna;
 * 8 - Ele vai ter o tipo de dado int; 
 * 9 - Vai se chamar j; 
 * 10 - Vai ter inicio no número 0;
 * 11 - Vai finalizar um número antes da variavel coluna; 
 * 12 - O incremento vai ser de ++j;
 * 
 * FAZENDO A TRANPOSTA 
 * 
 * 1 - Vai chamar a matriz b;
 * 2 - Vai informar o que vão ser todas as colunas e linhas, usando a matriz de for que foi criado ficando [j, i];
 * 3 - Como a matriz b, não foi informado o valor ainda, vamos passar todo o valor da a para b; 
 * 4 - Colocando o sinal de atribuição e inserindo a[i, j]
 * 5 - Aqui vai fazer a tranposta de linha e coluna;
 * 
 * ANALISANDO SE REALMENTE FEZ A TRANPOSTA 
 * 
 * 1 - Vai criar novamente um matriz, mas para o b;
 * 2 - Primeiro for sempre para a linha, pois é a primeira dimensão da matriz; 
 * 3 - Ele vai ter o tipo de dado int; 
 * 4 - Vai se chamar i;
 * 5 - Vai iniciar no número 0; 
 * 6 - E vai finalizar um número antes da função GetLength(0);
 * 7 - E o incremento vai ser de ++i;
 * 8 - Sengundo for sempre para coluna, sendo a segundo dimensão; 
 * 9 - Ele vai ter o tipo de dado int; 
 * 10 - Vai se chamar j;
 * 11 - Vai iniciar no número 0;
 * 12 - Vai finalizar um número antes do getLength(1);
 * 13 - E vai usar o incremento de ++j
 * 14 - Dentro do sengundo for, vai usar um console.Write() informando o b[i, j] para mostrar os valores; 
 * 15 - Fora do segundo e depois dele vai criar um console.WriteLine() para pular a linha quando acabar a linha;
 *
 */
//CRIANDO DO ARRAY MULTIDIMENSSIONAL - Primeiro
int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } }; //int - Seria o tipo de dado da matriz;
                                         //[,] - Aqui está chamando a matriz;
                                         //a - Seria o nome da matriz;
                                         //= - Sinal de atribuição;
                                         //{{}{}} - Aqui seria a quantidade de linhas tem na matriz;
                                         //1, 2, 3 4, 5, 6 - Seria a quantidade de colunas e os valores que serão guardados;
                                         //Sendo assim foi criado um array chamado a que tem o tipo de dado int e vai vim no formato matriz, ele vai ter 2 linhas e 3 colunas e os valores já vão ser informados;

//CRIAÇÃO DO ARRAY MULTIDIMENSSIONAL - Segundo
int[,] b = new int[3, 2]; //int - Seria o tipo de dado da matriz;
                          //[,] - Aqui esta chamando a matriz;
                          //b - É o nome da matriz;
                          //= - Sinal de atribuição;
                          //new int - Aqui está informando que vai ser criado manualmente e que futuramente pode vim um valor;
                          //[3, 2] - Só pode guardar 3 linhas e 2 colunas nessa matriz;
                          //Sendo assim foi criado um array multidimenssional matriz chamado b que tem o tipo de dado int, e que vai ser usado para trocar os valores da "a" para a "b", fazendo a transposta, por isso que vai ter 3 linhas e 2 colunas;


//CRIANDO VARIAVEL PARA GUARDAR A QUANTIDADE DE LINHA 
int linha = a.GetLength(0); //int - Seria o tipo de dado;
                            //linha - Seria o nome da variavel;
                            //= - Sinal de atribuição;
                            //a - Seria a matriz que vai ser usada pela função;
                            //GetLength(0) - Seria o total de linhas que tem na matriz;
                            //Sendo assim foi criado uma variavel onde ela tem o tipo de dado int e se chamar linha, ela vai chamar a matriz a para usar a função GetLength(0) guardar o total de linha tem na matriz;

//CRIANDO VARIAVEL PARA GUARDAR A QUANTIDADE DE COLUNA
int coluna = a.GetLength(1); //int - Seria o tipo de dado da variavel;
                             //coluna - Seria o nome da variavel;
                             //= - Seria o sinal de atribuição;
                             //a - Seria a matriz que vai ser informado o valor;
                             //GetLength(1) - Seria a função que pega o total de coluna na matriz;
                             //Sendo assim foi criado uma variavel chamada coluna e tem o tipo de dado int, tem o sinal de atribuição = e vai chamar a matriz a para usar a função GetLength(1) para ver o total de colunas tem na variavel;

//CRIANDO A MATRIZ "a" DE FORMA SEGURA 
for (int i = 0; i < linha; i++) //for - Seria um laço de repetição onde tem inicio e fim e ele percorre esse inicio e fim com o icremento de +1 ou -1;
                                //int - Seria o tipo de dado;
                                //i = 0 - Seria o valor inicial;
                                //i < linha - Seria o valor final, onde vai ser um número antes da varivel linha;
                                //i++ - Vai ser o incremento que seria o +1;
                                //Sendo assim está sendo feito um for onde ele seria a primeira dimensão da matriz, ele vai ter o tipo de dado int e vai se chamar i, ele vai iniciar no 0 e vai finaliza um número antes da variavel linha, o incremento vai ser de +1;
{
    for (int j = 0; j < coluna; j++) //for - Seria um laço de repetição onde ele tem inicio e fim ele percorre entre esse inicio e fim com um incremento de +1;
                                     //int - Seria o tipo de dado;
                                     //j - Seria o nome do for;
                                     //j = 0 - Seria o inicio do for;
                                     //j < coluna - Seria o final do for sendo o um número antes da variavel coluna;
                                     //j++ - Seria o incremento que seria o +1;
                                     //Sendo assim esta sendo criado o segundo for que seria a segunda dimensão sendo o da coluna, onde ele vai ter inicio no 0 e vai finalizar um número antes da variavel coluna e o incremento vai ser de +1;
    {
        //FAZENDO A TRANPOSTA
        b[j, i] = a[i, j]; //b - Seria a matriz que foi criada no inicio da lógica;
                           //[j, i] - Aqui está chamando as colunas e linhas que vão ser usadas da matriz b;
                           //= - Sinal de atribuição;
                           //a - Seria a matriz que foi criado no inicio e que ja foi criado com os valores;
                           //[i, j] - Seria as linhas e colunas que vão ser usadas dessa matriz;
                           //Sendo assim como a matriz b, não tem valor ainda e ela esta [3, 2] 3 linhas e 2 colunas e na a é 2 linhas e 3 colunas, teve que colocar primeiro o j que seria a quantidade certa para pegar o DE - A PARA - B, deixando a linha e coluna do b no jeito certo, vai atribuir os valores da matriz a para fazer a transposta;
    }
}

//ANALISANDO SE REALMENTE FEZ A TRANPOSTA
for(int i = 0; i < b.GetLength(0); i++) //for - Seria um laço de repetição onde tem inicio e fim onde ele percorre esse inicio e fim com um incremento de +1;
                                        //int - Seria o tipo de dado;
                                        //i - Seria o nome do for;
                                        //i = 0 - Seria o inicio;
                                        //i < GetLength(0) - Seria o final do for onde seria um número menor que o total de linhas que tem na matriz;
                                        //i++ - Seria o incremento de +1;
                                        //Sendo assim foi criado a primeira dimensão da matriz que seria a linha, usando um for que tem o tipo de dado int e inicia no 0 e vai até um número antes do total de linhas que tem nessa matriz, e o incremento vai ser de +1 para chegar no final;
{
    for(int j = 0; j < b.GetLength(1); j++) //for - Seria um laço de repetição que tem inicio e fim onde ele percorre esse inicio e fim com um incremento de +1 ou -1;
                                            //int - Seria o tipo de dado do for;
                                            //j - Seria o nome da for;
                                            //j = 0 - Seria o inicio do for;
                                            //j < b.GetLength(1) - Seria a função que é usada para pegar o total de colunas que tem na matriz;
                                            //j++ - Seria o incremento de +1;
                                            //Sendo assim foi criado a sengunda dimensão de uma matriz que seria a coluna da matriz, ela vai ter o tipo de dado int, vai se chamar j e vai iniciar no 0 e finalizar um número antes do total de colunas que tem nessa matriz e vai utilizar o incremento de +1; 
    {
        Console.Write(b[i,j] + " "); //Console.WriteLine - Seria uma função onde manda uma mensagem para o usuario no console; Aqui ele vai mandar os valores que foram colocados na linha e colunas da matriz b;
    }
    Console.WriteLine(); //Console.WriteLine - Seria uma função que é usada para mandar uma mensagem para o usuario no console; Nesse caso ele só vai pular a linha mesmo, para formar uma matriz;
}

