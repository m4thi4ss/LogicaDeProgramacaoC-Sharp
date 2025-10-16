/*ARRAY - O array ele seria um guarda roupa de valores, sendo uma variavel composta que guarda diversos valores. Ele é diferente da variavel simples que guarda somente um valor;
 * 
 * Segue exemplo: 
 */

int[] listaNumeros = {1,2,3,4}; //int - Seria o tipo de dado do array.
                                //[] - O cochete ele seria um vetor onde ele informa que não vai ser uma variavel simples e sim um array uma variavel composta;
                                //{} - A chaves seria onde vai ser armazenado esse valores do array;

/*
 * Sendo assim o exemplo acima mostra que vai ser uma array com o tipo de dado int com o nome listaNumeros e tendo os valores 1,2,3,4 guardados nele.
 * 
 * Mas roda o codigo e não mostra nada, como faz pra mostrar na tela?
 * Nesse caso você vai aprender sobre o indice. O indice ele seria o posicionamento que esta um certo valor guardado na array. O indice ele sempre começa pelo 0, seguindo o exemplo acima, vou te mostrar a tabela de indices do array 0(1), 1(2), 2(3), 3(4). Sendo sempre -1 do elemento, que vamos aprender la na frente. Segue abaixo um exemplo pratico de como buscar um valor com o indice no array:
*/

Console.WriteLine(listaNumeros[0]); //Console.WriteLine - Seria uma mensagem que vai ser enviada para o usuario no console;
                                    //listaNumeros - Seria o nome do array que vai ser usado;
                                    //[] - O cochete seria um vetor e ele informa que não vai ser uma variavel simples e sim um array uma variavel composta.

/* O que ele fez aqui, ele buscou dentro da lista o valor "1" que estava no indice 0 do array.
 * Sendo assim os indices seria as posições que esta sendo guardado aqueles valores que foram guardados na ARRAY. 
 * 
 * Mas como que eu sei quantos valores tem no array?
 * Nesse caso entra o .length ele é usado pra contar quantos valores foram guardados na array, mas ele não chama essa contagem de elementos, por que ele não faz a soma dos valores em si e sim faz a contagem de quantos valores foram armazenados no array, ele é diferente do indice o indice fala sobre o posicionamento começando pelo 0 ja o .length ele faz a contagem começando pelo 1, então diferente do indice o .lenght usando o primeiro exemplo vai informa que foi guardado 4 e não igual indice que vai informar que terminou em 3. Segue abaixo um exemplo pratico sobre o uso do .length:
 * */

Console.Write(listaNumeros.Length); //Console.WriteLine - Sria uma mensagem que é enviada para o usario no console;
                                    //() - Onde vai ser informado a mensagem;
                                    //listaNumeros - Esta informando que vai ser buscado algo no array chamando o nome dele;
                                    //.length - Ele vai entrar no array informado e vai fazer a contagem de elementos que tem no mesmo e vai retornar o valor total;

/* Sendo assim o .length ele faz a contagem de elementos que tem no array e não a soma dos valores, trazendo um resultado total da soma de todos os elementos disponiveis no array. Ele é diferente do indice que fala o posicionamento começando pelo zero e sendo sempre -1 do .lenght(elemento)
 *
 *E se eu digitar o indice errado, pode quebrar o codigo? Sim, a melhor forma de criar um array é sempre fazer um bloco de codigo com uma condicional onde informa:
 *SE - Se o número informado pelo usuario for MAIOR OU IGUAL a 0 &&(E) Se o numero informado pelo usuario for menor que o ultimo número do elemento que seria o Length ele vai rodar o bloco de codigo normalmente e vai mostrar o valor guardado da posição que foi informada. Mas o length puxa por elemento começando pelo 1, ele vai puxar o numero 4 e no exemplo acima não tem esse indice, mas tem que entender que vai ser menor que o .length que vai puxar a soma de elementos do exemplo acima sendo o 4, então ele não vai terminar a leitura no 4 e sim vai terminar antes dele sendo número 3.
 *SE NÃO - Caso o número seja maior ou igual a quantidade de elementos informados ou menor que o indice 0, ele vai gerar um erro. Vamos fazer um exemplo seguindo o array que ja tem guardado alguns valores que seria o listaNumeros 
 **/

int num = 0;// int - Seria o tipo de dado da variavel, sendo o int de números inteiros;
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

int[] numeros = {50, 40, 30, 20, 10}; //int - Seria o tipo de dado do array;
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
}
