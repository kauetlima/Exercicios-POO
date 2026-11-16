ContaBancaria conta1 = new ContaBancaria();

double saldo = 0;
double valorDeposito = 0;
double valorSaque = 0;


Console.WriteLine("Digite o nome do titular da conta:");
conta1.Titular = Console.ReadLine();

Console.WriteLine("Digite o saldo atual da conta:");
conta1.Saldo = double.Parse(Console.ReadLine());

void Menu()
{

    int menu;
    bool sair = false;

    do
    {
        Console.WriteLine("\n========== MENU BANCÁRIO ==========");
        Console.WriteLine("O QUE VOCÊ DESEJA FAZER?\n");
        Console.WriteLine("1 - DEPOSITAR DINHEIRO");
        Console.WriteLine("2 - SACAR DINHEIRO");
        Console.WriteLine("3 - VERIFICAR SALDO ATUAL");
        Console.WriteLine("4 - SAIR");
        Console.WriteLine("===================================");
        Console.Write("\nESCOLHA UMA OPÇÃO -> ");

        menu = int.Parse(Console.ReadLine());

        switch (menu)
        {
            case 1:
                Console.Write("Digite o valor que deseja DEPOSITAR:");
                conta1.DepositaDinheiro(saldo, valorDeposito);
                Console.Clear();
                break;

            case 2:
                Console.Write("Digite o valor que deseja SACAR:");
                conta1.SacarDinheiro(saldo, valorSaque);
                Console.Clear();
                break;

            case 3:
                Console.WriteLine(conta1.ToString());
                Console.ReadKey();
                Console.Clear();
                break;

            case 4:
                sair = true;
                Console.WriteLine("Encerrando o programa...");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                Console.Clear();
                break;
        }

    } while (sair == false);

}

Menu();