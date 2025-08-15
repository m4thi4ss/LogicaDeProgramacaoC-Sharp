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

internal class BigInterger
{
}