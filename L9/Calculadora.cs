using System.Data;

class Calculadora
{
    int n1, n2;

    public Calculadora(int pn1, int pn2)
    {
        n1 = pn1;
        n2 = pn2;
    }

    public int suma()
    {
        return n1 + n2;
    }

}