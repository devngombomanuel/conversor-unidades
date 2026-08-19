
//Chamando a struct
ConversorUnidades c1 = new ConversorUnidades();


Console.WriteLine("****Bem-vindo****");
Console.Write("Digite o valor [metros]: ");
double valor = Convert.ToDouble(Console.ReadLine());
c1.ValorMetro = valor;
Console.WriteLine("\n\n****Escolha a unidade****" +
    "\n1- Km \n2- hm \n3- dam " +
    "\n4- dm \n5- cm \n6- mm " +
    "\n0 - Sair");
Console.Write("Digite a opção correspondente: ");
int opcao = Convert.ToInt32(Console.ReadLine());

Console.Clear();
switch (opcao)
{
    case 0: System.Environment.Exit(0); break;
    case 1: Console.WriteLine($"{valor} m corresponde a {c1.valorKilometro} Km"); break;
    case 2: Console.WriteLine($"{valor} m corresponde a {c1.valorHectometro} hm"); break;
    case 3: Console.WriteLine($"{valor} m corresponde a {c1.valorDacametro} dam"); break;
    case 4: Console.WriteLine($"{valor} m corresponde a {c1.valorDecimetro} dm"); break;
    case 5: Console.WriteLine($"{valor} m corresponde a {c1.valorCentimetro} cm"); break;
    case 6:Console.WriteLine($"{valor} m corresponde a {c1.valorMilimetro} mm"); break;
    default:
        Console.WriteLine("Escolha as opções corretamente, " +
        "digite o valor que deseja converter.");
        Thread.Sleep(1500);
        break;
}


//Implementação da struct
struct ConversorUnidades
{
    public double ValorMetro { get; set; }

    public ConversorUnidades(double valorMetro) => ValorMetro = valorMetro;

    public double valorKilometro => ValorMetro / 1000D;
    public double valorHectometro => ValorMetro / 100D;
    public double valorDacametro => ValorMetro / 10D;
    public double valorDecimetro => ValorMetro * 10D;
    public double valorCentimetro => ValorMetro * 100D;
    public double valorMilimetro => ValorMetro * 1000D;
}

