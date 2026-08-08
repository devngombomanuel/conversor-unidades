using System.Linq.Expressions;

Menu();

static void Menu()
{
    Console.WriteLine("****Bem-vindo****");
    Console.Write("Digite o valor [metro]: ");
    double valor = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n\n****Escolha a unidade****" +
        "\n1- Km \n2- hm \n3- dam " +
        "\n4- dm \n5- cm \n6- mm " +
        "\n0 - Sair");
    Console.Write("Digite a opção correspondente: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    Console.BackgroundColor= ConsoleColor.Blue;
    Console.ForegroundColor= ConsoleColor.White;
    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Console.WriteLine($"{valor} m corresponde a  {Kilometro(valor)} Km"); break;
        case 2: Console.WriteLine($"{valor} m corresponde a  {Hectometro(valor)} hm"); break;
        case 3: Console.WriteLine($"{valor} m corresponde a  {Dacametro(valor)} dam"); break;
        case 4: Console.WriteLine($"{valor} m corresponde a  {Decimetro(valor)} dm"); break;
        case 5: Console.WriteLine($"{valor} m corresponde a  {Centimetro(valor)} cm"); break;
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
static double Dacametro(double valor)
{
    return (valor / 10);
}
static double Decimetro(double valor)
{
    return (valor * 10);
}
static double Centimetro(double valor)
{
    return (valor * 100);
}



Console.ResetColor();

