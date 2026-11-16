
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

public class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoModelo;
    public int AnoFabricacao;
    public float ValorVenda;
    public double IPVA;
    public Motor motores = new Motor();

    //public Carro(string fabricante, string modelo, int anoModelo, int anoFabricacao, float valorVenda)
    //{
    //    this.Fabricante = fabricante;
    //    this.Modelo = modelo;
    //    this.AnoModelo = anoModelo;
    //    this.AnoFabricacao = anoModelo;
    //    this.ValorVenda = valorVenda;

    //}

    public void SetFabricante(string fabricante)
    {
        Fabricante = fabricante;
    }
    public void SetModelo(string modelo)
    {
        Modelo = modelo;
    }
    public void SetAnoModelo(int anoModelo)
    {
        if (ValidarAnoModelo(anoModelo))
            AnoModelo = anoModelo;
        else
            AnoModelo = AnoFabricacao;
    }
    private bool ValidarAnoModelo(int anoModelo)
    {
        if (anoModelo == AnoFabricacao || anoModelo == AnoFabricacao + 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SetAnoFabricacao(int anoFabricacao)
    {
        AnoFabricacao = anoFabricacao;
    }
    public void SetValorVenda(float valorVenda)
    {
        ValorVenda = valorVenda;
    }

    public string GetFabricante()
    {
        return this.Fabricante;
    }
    public string GetModelo()
    {
        return this.Modelo;
    }
    public int GetAnoModelo()
    {
        return this.AnoModelo;
    }
    public int GetAnoFabricacao()
    {
        return this.AnoFabricacao;
    }
    public float GetValorVenda()
    {
        return this.ValorVenda;
    }
    public double CalculaIPVA()
    {
        if (!ValidaIPVA())
        {
            return IPVA = 0;
        }
        else
        {
            return IPVA = ValorVenda * 0.04;
        }
    }
    public bool ValidaIPVA()
    {
        int anoAtual = DateOnly.FromDateTime(DateTime.Now).Year;
        if (anoAtual - AnoFabricacao >= 20)
        {
            return false;
        }
        else
            return true;
    }

    public override string ToString()
    {
        return $"Fabricante: {this.Fabricante}\n" +
               $"Modelo: {this.Modelo}\n" +
               $"Ano Modelo: {this.AnoModelo}\n" +
               $"Ano Fabricação: {this.AnoFabricacao}\n" +
               $"Valor Venda: R$ {this.ValorVenda:F2}\n" +
               $"IPVA: R$ {this.IPVA:F2}";
    }
}


