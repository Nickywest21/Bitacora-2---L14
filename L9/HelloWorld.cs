class HelloWorld
{
    string saludo = "Hola";
    string nombre = "Luis";

    public HelloWorld(string nuevoSaludo)
    {
        saludo = nuevoSaludo;
    }

    public string ObtenerSaludo()
    {
        return saludo;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }
    
    public void Saludar()
    {
        Console.WriteLine(saludo);
    }

    public void DefinirNombre(string pNombre)
    {
        nombre = pNombre;
    }
}