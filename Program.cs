
using Aula40Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        Usuario a, b; // Cria 2 variaveis do tipo Usuario
        a = new Usuario();//cria o objeto a da classe Usuario
        b = new Usuario();//cria o objeto b da classe Usuario

        Console.WriteLine("Dados da primeira pessoa : "); //Inicia a leitura dos dados da primeira pessoa
        Console.Write("Nome : ");                         //Pede para que a pessoa digite o nome 
        a.Nome = Console.ReadLine();                      //Le o nome e armazena no compo Nome da variavel a
        Console.Write("Idade : ");                        //Pede para que a pessoa digite a idade
        a.Idade = int.Parse(Console.ReadLine());          //Le o nome e armazena no campo idade da variavel a

        Console.WriteLine("Dados da Segunda pessoa : ");  //Inicia a leitura dos dados da segunda pessoa
        Console.Write("Nome : ");                         //Pede para que a pessoa digite o nome
        b.Nome = Console.ReadLine();                      //Le o nome e armazena no campo Nome da variavel b
        Console.Write("Idade : ");                        //Pede para que a pessoa digite a idade
        b.Idade = int.Parse(Console.ReadLine());          //Le a idade e armazena no campo idade da variavel b

        if (a.Idade > b.Idade)                            //Faz a comparação entre a idade dos objetos a e b
        {
            Console.WriteLine("A Pessoa mais velha : " + a.Nome);  // se a idade da primeira pessoa for maior imprime o nome da primeira pessoa
        }
        else
        { 
            Console.WriteLine("A Pessoa mais velha : " +  b.Nome); // se a idade da segunda pessoa for maior imprime o nome da segunda pessoa
        }
    }
}