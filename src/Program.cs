using System.Linq.Expressions;

Menu();

static void Menu()
{
    Console.WriteLine("****Escolha a unidade********");
    Console.WriteLine("1- Km \n2- hm \n3- dam \n4- m \n5- dm \n6- cm \n7- mm \n0 - Sair");

    Console.Write("Digite a opção correspondente: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o valor: ");
    double valor = Convert.ToDouble(Console.ReadLine());

    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: ; break;
        case 2: ; break;
        case 3: ; break;
        case 4: ; break;
        case 5: ; break;
        case 6: ; break;
        case 7: ; break;
    }
}