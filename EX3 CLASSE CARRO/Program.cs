Carro CadastrarCarro()
{
    Console.WriteLine("Informe o FABRICANTE:");
    string fabricante = Console.ReadLine();
    Console.WriteLine("Informe o MODELO:");
    string modelo = Console.ReadLine();
    Console.WriteLine("Informe o ANO DE FABRICACAO:");
    int anoFabricacao = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o ANO DO MODELO:");
    int anoModelo = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o PREÇO DE VENDA:");
    float preco = float.Parse(Console.ReadLine());

    Carro c = new();

    c.SetFabricante(fabricante);
    c.SetModelo(modelo);
    c.SetAnoFabricacao(anoFabricacao);
    c.SetAnoModelo(anoModelo);
    c.SetValorVenda(preco);
    c.CalculaIPVA();
    return c;
}

Carro[] carros = new Carro[2];

//Carro carro = CadastrarCarro();
//carros[0] = carro;
//carro = CadastrarCarro();
//carros[1] = carro;
//carro = CadastrarCarro();
//carros[2] = carro;
//carro = CadastrarCarro();
//carros[3] = carro;

void populaCarro()
{
    for (int i = 0; i < carros.Length; i++)
    {
        carros[i] = CadastrarCarro();

    }
}

void mostrarCarros()
{
    for (int i = 0; i < carros.Length; i++)
    {
        Console.WriteLine($"====================");
        Console.WriteLine($"     CARRO {i}");
        Console.WriteLine($"====================");
        Console.WriteLine($"{carros[i].ToString()}\n");
    }
}

populaCarro();
mostrarCarros();

