using System.ComponentModel.Design;

string titulo, autor;
int numeroPaginas;

Console.WriteLine("Digite o NUMERO de livros que deseja cadastrar:");
int numeroLivros = int.Parse(Console.ReadLine());
Console.Clear();

Livro[] livros = new Livro[numeroLivros];

Livro CadastraLivros()
{

        Console.WriteLine($"Digite o titulo do livro:");
        titulo = Console.ReadLine();
        Console.WriteLine($"Digite o autor do livro :");
        autor = Console.ReadLine();
    do
    {
        
        Console.WriteLine($"Digite quantas páginas o livro possui:");
        numeroPaginas = int.Parse(Console.ReadLine());
        if (numeroPaginas <= 0)
        {
            Console.WriteLine($"Não existem livros com qunatidade de páginas igual a {numeroPaginas}. Aperte enter para continuar");
            Console.ReadKey();
        }
        Console.Clear();
    } while (numeroPaginas <=0 );

    Livro l = new(titulo, autor, numeroPaginas);
    return l;
}
void PopulaLivros()
{
    for (int i = 0; i < livros.Length; i++)
    {
        livros[i] = CadastraLivros();
    }
}
void ImprimeCarros()
{
    for (int i = 0; i < livros.Length; i++)
    {
        Console.WriteLine($"========================");
        Console.WriteLine($" LIVRO {i}");
        Console.WriteLine($"========================");
        Console.WriteLine($"{livros[i].ToString()}");
    }

}
void ImprimeGet()
{
    int menu=1;
    int i = 0;
    do
    {
        Console.WriteLine("\nDigite 0 para sair e 1 para continuar");
        menu = int.Parse(Console.ReadLine());
        Console.Clear();
        if (menu == 0)
        {
            break;
        }
        else
        { 
        Console.WriteLine("Digite o numero do livro que deseja verificar os dados :");
        Console.Write("->");
         i = int.Parse(Console.ReadLine());
        }
        if (i <= livros.Length && i >= 0)
        {
            Console.WriteLine("Titulo:");
            Console.Write($"{livros[i].GetTitulo()}");
            Console.WriteLine("Autor:");
            Console.WriteLine($"{livros[i].GetAutor()}");
            Console.WriteLine("Numero de páginas:");
            Console.WriteLine($"{livros[i].GetNumeroPaginas()}");
        }
        else
            Console.WriteLine("Não existe um livro com esse numero");
    } while (menu != 0);


}
PopulaLivros();
ImprimeCarros();
ImprimeGet();
