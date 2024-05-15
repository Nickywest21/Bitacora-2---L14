using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //Objeto 1
        HelloWorld objetoHelloW = new HelloWorld("Hola desde el menú");

        Console.WriteLine(objetoHelloW.ObtenerSaludo());
        objetoHelloW.Saludar();

        objetoHelloW.DefinirNombre("Luis");
        Console.WriteLine(objetoHelloW.ObtenerSaludo() + objetoHelloW.ObtenerNombre());


        //Objeto 2
        HelloWorld helloWorld2 = new HelloWorld("Hola 2");
        Console.WriteLine(helloWorld2.ObtenerSaludo());

        //Objeto 3
        Calculadora objetoCalculadora = new Calculadora(1, 2);
        Console.WriteLine(objetoCalculadora.suma());

        // Objeto 4
        Automovil objAutomovil = new Automovil();

        Console.WriteLine("Ingrese el modelo: ");
        int modelo = Convert.ToInt32(Console.ReadLine());
        objAutomovil.DefinirModelo(modelo);

        double precio;
        Console.WriteLine("Ingrese el precio ");
        precio = Convert.ToInt32(Console.ReadLine());
        objAutomovil.DefinirPrecio(precio);

        Console.WriteLine("Ingrese la marca: ");
        string marca = Console.ReadLine();
        objAutomovil.DefinirMarca(marca);

        Console.WriteLine("Tipo de cambio: ");
        double tipoCambioDolar = Convert.ToDouble(Console.ReadLine());
        objAutomovil.DefinirTipoCambio(tipoCambioDolar);

        string condicion;
        Console.WriteLine("Desea cambiar la disponibilidad de: " + objAutomovil.MostrarDisponibilidad() + " Si o No?");
        condicion = Console.ReadLine();
        if (condicion == "Si")
        {
            objAutomovil.CambiarDisponibilidad();
            Console.WriteLine("La nueva disponibilidad es: " + objAutomovil.MostrarDisponibilidad());

        }

        Console.WriteLine("Ingrese la cantidad que se le aplicará como descuento: ");
        double descuento = Convert.ToDouble(Console.ReadLine());
        objAutomovil.AplicarDescunto(descuento);

        Console.WriteLine("La información de su autnomóvil es: " + objAutomovil.MostrarInformacion());

    }
}