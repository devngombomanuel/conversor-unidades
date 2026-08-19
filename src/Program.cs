
readonly struct ConversorUnidades
{
    public double valorMetro{ get; }

    public ConversorUnidades(double valoremmetro) => valorMetro = valoremmetro;
    public double  valorKilometro => valorKilometro / 1000D;
    public double  valorHectometro => valorHectometro / 100D;
    public double  valorDecametro => valorDecametro / 10D;
    public double  valorDecimetro => valorDecimetro * 10D;
    public double  valorCentimetro => valorCentimetro * 100D;
    public double  valorMilimetro => valorMilimetro / 1000D;

}
