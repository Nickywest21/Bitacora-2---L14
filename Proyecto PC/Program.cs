class Program
{
    static void Main(string[] args) 
    {
        // Se elegio un nombre para la emperesa y se le solicito la informacion al cliente
        string NIT;
        string NombreNIT;
        string Nombre;
        Console.WriteLine("Bienvendido a TheRightMix!");
        Console.WriteLine("Fecha: " + DateTime.Now);
        Console.WriteLine(" ");
        Console.WriteLine("Por favor escribir toda respuesta con mayuscula al principio.");
        Console.WriteLine("Ingrese su nombre por favor: ");
        Nombre = Console.ReadLine() + "";
        Console.WriteLine(" ");
        Console.WriteLine("Desea agregar NIT?:");
        NIT = Console.ReadLine() + "";

        if(NIT == "Si")
        {
            Console.WriteLine("Por favor, ingrese su NIT:");
            NombreNIT = Console.ReadLine() + "";
        }
        else
        {
            NombreNIT = "C/F";
            Console.WriteLine("Se usara C/F");
        }
       
        string opcion;


        // Se habilito la clase Batido, se creo el batido predeteminado y el menu de opciones interactivo.
        Batido pedido = new Batido();

        string pregunta;
        Console.WriteLine(" ");
        Console.WriteLine("Desea pedir el batido de la casa?:");
        pregunta = Console.ReadLine() + "";
        if(pregunta == "Si")
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Pedido final de {Nombre} contendria: ");
            Console.WriteLine("Leche deslactosada: Q.7");
            Console.WriteLine("Tamaño Normal: Q. 13");
            Console.WriteLine("Costo Final: Q.20");
            Console.WriteLine($"Su pedido fue realizado "+ DateTime.Now);
            
        }
        else
        {

        do
        {
        Console.WriteLine("Menu");
        Console.WriteLine("a. Eligir Azucar");
        Console.WriteLine("b. Eligir Leche");
        Console.WriteLine("c. Elegir Tamaño");
        Console.WriteLine("d. Mostrar pedido actual");
        Console.WriteLine("e. Finalizar Compra");
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese la opcion: ");
        
        opcion = Console.ReadLine() + "";

        // Se llamaron a los objetos utilizados dentro de la clase Batido para cada opcion del menu.
        switch(opcion)
        {
            case "a":
                pedido.agregarazucar();
                Console.WriteLine(" ");
                break;

            case "b":
                pedido.agregarleche();
                Console.WriteLine(" ");
                break;

            case "c":
                pedido.Agrandar();
                Console.WriteLine(" ");
                break;

            case "d":
                pedido.Info();
                Console.WriteLine(" ");
                break;

            case "e":
                Console.WriteLine($"Cliente {Nombre}, su factura se identificara con: {NombreNIT}");
                pedido.Precio();
                Console.WriteLine($"Gracias por su visita! Espero vuelva pronto y gaste mas.");
                break;
        }
        } while (opcion != "e");
        }
    }
}