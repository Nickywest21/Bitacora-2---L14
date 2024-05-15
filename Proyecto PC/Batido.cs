class Batido
{
    // Se inicializaron y se definieron las variables que se utilizaron en el codigo.
    string Azucar;
    string Bebida;
    string Leche;
    double blanca = 0.60;
    double morena = 0.40;
    double suplemento = 0.90;
    double azucar;
    double leche;
    double bebida;
    double PBatido = 20;
    bool n; 
    int nsi;
    
    // Se crearon los metodos para cada condicion necesitada para el batido.
    public void agregarazucar()
    {
        Console.WriteLine("Cuantas cucharadas desea agregra? Se puede hasta un maximo de tres cucharadas");
        n = int.TryParse(Console.ReadLine(), out nsi);

        Console.WriteLine("Que azucar desea? Blanca, Morena, Suplemento");
        Azucar = Console.ReadLine() + "";

        switch (Azucar)
        {
            case "Blanca":
                azucar = blanca * nsi;
                break;
            
            case "Morena":
                azucar = morena * nsi;
                break;
            
            case "Suplemento":
                azucar = suplemento * nsi;
                break;
        }
    }

    public void agregarleche()
    {

        Console.WriteLine("Que tipo leche desea? Sin leche, Leche Enetera, Leche de Soya, Leche Deslactosada");
        Leche = Console.ReadLine() + "";

        switch (Leche)
        {
            case "Sin leche":
                leche = -3;
                break;
            
            case "Leche Entera":
                leche = 0;
                break;
            
            case "Leche de Soya":
                leche = +2;
                break;
            
            case "Leche Deslactosada":
                leche = 0;
                break;
        }
    }

    public void Agrandar()
    {
        Console.WriteLine("Desea agrandar su bebida?");
        Bebida = Console.ReadLine() + "";

        if(Bebida == "Si")
        {
            Console.WriteLine("Bebida grande :)");
            bebida = 0.07;
        }
        else
        {
            Console.WriteLine("Bebida regular :(");
            bebida = 0;
        }
    }

    // Se recolecto cada varaible y se imprimio para qe el cliente confirmara su contenido.
    public void Info()
    {
        Console.WriteLine($"Su pedido actual es: Tipo de azucar: {Azucar}, Tipo de Leche: {Leche}, Se agrando el tamaño: {Bebida}");
    }

    // Se establecio la formula requerida para obtener el precio final y se le mostro al cliente su compra finalizada.
    public void Precio()
    {
        PBatido = PBatido + azucar + leche + (bebida * PBatido);
        Console.WriteLine($"Su pedido final seria: Tipo de azucar: {Azucar}, Tipo de Leche: {Leche}, Se agrando el tamaño: {Bebida}");
        Console.WriteLine($"El precio final de su batido es de: Q.{PBatido}");
        Console.WriteLine("Fecha: " + DateTime.Now);
    }
}