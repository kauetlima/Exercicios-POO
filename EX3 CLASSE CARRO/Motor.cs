
public class Motor
{
    public string Combustivel;
    public int Cilindrada;
    public int Potencia;



    public void SetCombustivel(string combustivel)
    {
        this.Combustivel = combustivel;
    }
    public void SetCilindrada(int cilindrada)
    {
        Cilindrada = cilindrada;
    }
    public void SetPotencia(int potencia)
    {
        Potencia = potencia;
    }
    public string GetCombustivel()
    {
        return this.Combustivel; ;

    }
    public int GetCilindrada()
    {
        return this.Cilindrada;
    }
    public int GetPotencia()
    {
        return this.Potencia;
    }
}


