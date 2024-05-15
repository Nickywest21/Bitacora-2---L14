class Areas
{
    double Base = 0;
    double Altura = 0;
    double Lado = 0;
    double Radio = 0;

    public Areas(double Base, double Altura, double Lado, double Radio)
    {
        this.Base = Base;
        this.Altura = Altura;
        this.Lado = Lado;
        this.Radio = Radio;
    }


    public double AreaTriangulo(double BT, double AT)
    {
        return (BT * AT)/2;
    }

    public double AreaCuadrado(double L)
    {
        return L * L;
    }

    public double AreaRectangulo(double BR, double AR)
    {
        return BR * AR;
    }

    public double AreaCirculo(double R)
    {
        return 3.14159265359 * (R * R);
    }
}