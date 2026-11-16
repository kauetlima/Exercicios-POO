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
        NumeroPaginas = numeroPaginas;
    }
    public string GetTitulo()
    {
        return Titulo;
    }

    public string GetAutor()
    {
        return Autor;
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

