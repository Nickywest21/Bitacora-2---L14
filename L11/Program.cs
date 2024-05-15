class Program 
{
    static void Main(string[] args)
    {
        string opcion;

        Personaje personaje = new Personaje(0,0);

        do
        {
        Console.WriteLine("Ejercicio #2:");
        Console.WriteLine(" ");
        Console.WriteLine("Menu de opciones: ");
        Console.WriteLine("a. Sube");
        Console.WriteLine("b. Baja");
        Console.WriteLine("c. Izquierda");
        Console.WriteLine("d. Derecha");
        Console.WriteLine("e. Salir");
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese la opcion: ");
        
        opcion = Console.ReadLine() + "";

        switch(opcion)
        {
            case "a":
                personaje.MoverHaciaArriba(LeerCantidad("Arriba"));
                break;

            case "b":
                personaje.MoverHaciaAbajo(LeerCantidad("Abajo"));
                break;

            case "c":
                personaje.MoverHaciaIzquierda(LeerCantidad("Izquierda"));
                break;

            case "d":
                personaje.MoverHaciaDerecha(LeerCantidad("Derecha"));
                break;

            case "e":
                Console.WriteLine($"Coordenadas finales del personaje: + ({personaje.Getx()} , {personaje.Gety()})");
                break;
        }
        } while (opcion != "e");



        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("EJercicio #1:");

        string opcion2;

        Areas area = new Areas(0, 0, 0, 0);

         do
        {
        Console.WriteLine("Menu de opciones: ");
        Console.WriteLine("A. Calcular Area de Triangulo");
        Console.WriteLine("B. Calcular Area de un cuadrado");
        Console.WriteLine("C. Calcular Area de un Rectangulo");
        Console.WriteLine("D. Calcular Area de un circulo");
        Console.WriteLine("E. Salir");
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese la opcion: ");

        opcion2 = Console.ReadLine() + "";

        switch(opcion2)
        {
            case "A":
                Console.WriteLine($"Area del triangulo: {area.AreaTriangulo(PedirBaseT(""), PedirAlturaT(""))}");
                Console.WriteLine(" ");
                break;

            case "B":
                Console.WriteLine($"Area del triangulo: {area.AreaCuadrado(PedirLado(""))}");
                Console.WriteLine(" ");
                break;

            case "C":
                Console.WriteLine($"Area del triangulo: {area.AreaRectangulo(PedirBaseR(""), PedirAlturaR(""))}");
                Console.WriteLine(" ");
                break;

            case "D":
                Console.WriteLine($"Area del triangulo: {area.AreaCirculo(PedirRadio(""))}");
                Console.WriteLine(" ");
                break;

            case "E":
                Console.WriteLine("Se ha cerrado el programa correctamente.");
                break;
        }

        } while (opcion2 != "E");
    }

    static int LeerCantidad(string direccion)
    {
        Console.WriteLine($"Ingrese la cantidad a moverse hacia {direccion}: ");
        int cantidad = int.Parse(Console.ReadLine());
        return cantidad;
    }

    static double PedirBaseT(string Area)
    {
        Console.WriteLine($"Ingrese la cantidad de la Base del Triangulo {Area}: ");
        double BT = int.Parse(Console.ReadLine());
        return BT;
    }

    static double PedirAlturaT(string Area)
    {
        Console.WriteLine($"Ingrese la cantidad de la Altura del Triangulo {Area}: ");
        double AT = int.Parse(Console.ReadLine());
        return AT;
    }

    static double PedirLado(string Area)
    {
        Console.WriteLine($"Ingrese la cantidad del Lado del Cuadrado {Area}: ");
        double L = int.Parse(Console.ReadLine());
        return L;
    }

    static double PedirBaseR(string Area)
    {
        Console.WriteLine($"Ingrese la cantidad de la Base del Triangulo {Area}: ");
        double BR = int.Parse(Console.ReadLine());
        return BR;
    }

    static double PedirAlturaR(string Area)
    {
        Console.WriteLine($"Ingrese la cantidad de la Altura del Triangulo {Area}: ");
        double AR = int.Parse(Console.ReadLine());
        return AR;
    }

    static double PedirRadio(string Area)
    {
        Console.WriteLine($"Ingrese la cantidad del radio del circulo {Area}: ");
        double R = int.Parse(Console.ReadLine());
        return R;
    }
}
