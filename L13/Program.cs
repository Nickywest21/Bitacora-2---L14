using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        OperacionesMatrices operacionesMatrices = new OperacionesMatrices();
        char opcion = 'a';

        operacionesMatrices.CrearMatriz();
        operacionesMatrices.IngresarDatosMatriz();

        while (opcion != 'e')
        {
            Console.WriteLine("Menú opciones");
            Console.WriteLine(" a) Ver matriz original");
            Console.WriteLine(" b) Multiplicación");
            Console.WriteLine(" c) Conteo de los números menores al ingresado");
            Console.WriteLine(" d) Números pares dentro de su matriz");
            Console.WriteLine(" e) Salir ");
            opcion = Console.ReadLine()[0];

            switch (opcion)
            {
                case 'a':
                    operacionesMatrices.ImprimirMatriz();
                    break;

                case 'b':
                    Console.WriteLine("Ingrese un escalar");
                    int escalar = Int32.Parse(Console.ReadLine());
                    int [,] matrizMultiplicada = operacionesMatrices.MultiplicaciónMatrizEscalar(escalar);
                    operacionesMatrices.ImprimirMatrizpatodo(matrizMultiplicada);
                    break;

                case 'c':
                    Console.WriteLine("Ingrese el valor del número que desea buscar");
                    int numerobuscado = Int32.Parse(Console.ReadLine());
                    int [,] conteo = operacionesMatrices.ConteoEnFilas(numerobuscado);
                    operacionesMatrices.ImprimirMatrizpatodo(conteo);
                    break;

                case 'd':
                    int [,] pares = operacionesMatrices.Vector();
                    operacionesMatrices.ImprimirMatrizpatodo(pares);
                    break;

            }
        }
    }
}