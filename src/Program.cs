using System.Linq.Expressions;

Menu();

static void Menu()
{
    Console.WriteLine("****Bem-vindo****");
    Console.Write("Digite o valor [metro]: ");
    double valor = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n\n****Escolha a unidade****" +
        "\n1- Km \n2- hm \n3- dam " +
        "\n4- m \n5- dm \n6- cm " +
        "\n7- mm \n0 - Sair");
    Console.Write("Digite a opção correspondente: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    Console.BackgroundColor= ConsoleColor.Blue;
    Console.ForegroundColor= ConsoleColor.White;
    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Console.WriteLine($"{valor} m corresponde a  {Kilometro(valor)} Km"); break;
    }
}

static double Kilometro(double valor)
{
    return (valor/1000);
}
static double Hectometro(double valor)
{
    return (valor / 100);
}

Console.ResetColor();

