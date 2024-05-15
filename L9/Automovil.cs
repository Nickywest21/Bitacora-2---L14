class Automovil
{
int modelo = 2019;
double precio = 10000.00;
string marca = "";
bool disponible = false;
double tipoCambioDolar = 7.50;
double descuentoAplicado = 0.00;

public void DefinirModelo(int unModelo)
{
    modelo = unModelo;

}
public void DefinirPrecio(double unPrecio)
{
    precio = unPrecio;
}

public void DefinirMarca(string unaMarca)
{
    marca = unaMarca;
}

public void DefinirTipoCambio(double unTipoCambio)
{
    tipoCambioDolar = unTipoCambio;
}

public void CambiarDisponibilidad()
{
    disponible = !disponible;
}

public String MostrarDisponibilidad()
{
    return $"{disponible}";
}

public string MostrarInformacion()
{
    double precioDolares = precio*tipoCambioDolar;
    return $"Marca: '{marca}'. Modelo: '{modelo}'. Precio de venta: Q.'{precio}'. Precio en dólares: $'{precioDolares}'";
}

public void AplicarDescunto(double miDescuento)
{
    descuentoAplicado = miDescuento;
    precio -= descuentoAplicado;
    DefinirPrecio(precio);
}
}