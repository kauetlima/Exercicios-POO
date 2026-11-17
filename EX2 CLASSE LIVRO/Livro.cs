internal class Livro
{
    string Titulo;
    string Autor;
    int NumeroPaginas;
    
    public Livro (string titulo, string autor, int numeroPaginas)
    {
        this.Titulo = titulo;
        this.Autor = autor;
        this.NumeroPaginas = numeroPaginas;

    }

    public void SetTitulo(string titulo)
    {
        Titulo = titulo; 
    }
    public void SetAutor(string autor)
    {
        Autor = autor;
    }
    public void SetNumeroPaginas(int numeroPaginas)
    {
        if (ValidaPaginas(numeroPaginas))
        {
            NumeroPaginas = numeroPaginas;
        }
        else
        { 
            Console.WriteLine("Não existem livros com essa numeração de página.");
            Console.ReadKey();

        }
    }

    public string GetTitulo()
    {
        return Titulo;
    }
    public string GetAutor()
    {
        return Autor;
    }

    public bool ValidaPaginas(int numeroPaginas)
    {
        if (NumeroPaginas <= 0)
        {
            return false;
        }
        else
            return true;
    }
    public int GetNumeroPaginas()
    {
        return NumeroPaginas;
    }
    public override string ToString()
    {
        return $"Nome do Livro: {Titulo}\nAutor: {Autor}\nNumero De Páginas:{NumeroPaginas}";
    }
}

