public class Circulo
{
    double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    private double ObtenerPerimetro()
    {
        return 2 * 3.14159265359 * radio;
    }

    private double ObtenerArea()
    {
        return 3.14159265359 * radio * radio;
    }

    private double ObtenerVolumen()
    {
        return (4* 3.14159265359 * radio * radio * radio)/3;
    }

    public void CalcularGeometria(ref double Perimetro, ref double Area, ref double Volumen)
    {
       Perimetro = ObtenerPerimetro();
       Area = ObtenerArea();
       Volumen = ObtenerVolumen();
    }
}
