using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;
using System.Threading.Tasks.Sources;
using Microsoft.VisualBasic;

class OperacionesMatrices
{

    public int[,] matriz = new int[0,0];

    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {
        int cantidadFilas = 0;
        int cantidadCols = 0;

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine());

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine());
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public void BuscarNum()
    {
        int buscaNum = 0;
        Console.WriteLine("Ingrese el número que desea buscar dentro de su matriz: ");
        buscaNum = Int32.Parse(Console.ReadLine());


    }

    public void ImprimirMatriz()
    {
        Console.WriteLine("La matriz que ingresó es: ");
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
                for(int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila,columna] + "\t");
                }
            Console.WriteLine(); 
        }

    }

    public void ImprimirMatrizpatodo(int[,] matriz)
    {
        Console.WriteLine("La matriz es: ");
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
                for(int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila,columna] + "\t");
                }
            Console.WriteLine(); 
        }

    }

    public int[,] ConteoEnFilas (int numerobuscado)
    {
        int f1 = matriz.GetLength(0);
        int[,] conteo = new int[f1,2];

        for (int fila = 0; fila < f1; fila++)
        {
            int contador = 0;
            for(int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                if(matriz[fila,columna] < numerobuscado)
                {
                    contador++;
                }
            }
            
             conteo[fila,0] = fila;
             conteo[fila,1] = contador;
        }
        return conteo;
    }

    public int[,] Vector ()
    {
        int cantidadpares = 0;
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
        
            for(int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                if (matriz[fila, columna] %2 == 0 )
                {
                    cantidadpares++;
                }

            }
        }

        int[,] vectorespares = new int[1,cantidadpares];
        int pares = 0;
    
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
        
            for(int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                if (matriz[fila, columna] %2 == 0 )
                {
                    vectorespares[0, pares] = matriz[fila, columna];
                    pares++;
                }

            }
            
        }
        return vectorespares;
        
    }

    
}
