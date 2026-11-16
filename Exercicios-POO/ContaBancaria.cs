internal class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public void SetSaldo(double saldo)
    {
        Saldo = saldo;
    }
    public void SetTitular(string titular)
    {
        Titular = titular;
    }
    public double GetSaldo()
    {
        return Saldo;
    }
    public string GetTitular()
    {
        return Titular;
    }



    public void DepositaDinheiro(double saldo, double valorDeposito)
    {
       valorDeposito = double.Parse(Console.ReadLine());
        Saldo += valorDeposito;
    }
    public void SacarDinheiro(double saldo, double valorSaque)
    {
        valorSaque = double.Parse(Console.ReadLine());
        if (ValidaSaque(saldo, valorSaque))
        {
            Saldo -= valorSaque;
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente, seu saldo atual é de : R$ {Saldo}");
            Console.ReadKey();
        }
    }
    public void ExibirSaldo(double saldo)
    {
        Console.WriteLine($"Seu saldo atual");
        Console.WriteLine($"R$: {Saldo}");
    }
    public bool ValidaSaque(double saldo, double valorSaque)
    {
        if (valorSaque > Saldo)
        {
            return false;
        }
        else
            return true;
    }

    public override string ToString()
    {
        return $"\n=======================================\n" +
               $"           CONTA BANCÁRIA\n" +
               $"=======================================\n" +
               $"TITULAR: {Titular}\n" +
               $"SALDO DISPONÍVEL: R$ {Saldo:F2}\n" +
               $"=======================================";
    }
}
