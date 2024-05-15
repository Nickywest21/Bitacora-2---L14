public class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine($"Ingrese la cantidad del radio: ");
        double radio = int.Parse(Console.ReadLine());

        double Perimetro = new double();
        double Area = new double();
        double Volumen = new double();
        Circulo objetoRadio = new Circulo(radio);


        objetoRadio.CalcularGeometria(ref Perimetro, ref Area, ref Volumen);

        Console.WriteLine($"EL Perimetro es de: {Perimetro}");
        Console.WriteLine($"El Area es de: {Area}");
        Console.WriteLine($"El volumen es de: {Volumen}");
    }
}
