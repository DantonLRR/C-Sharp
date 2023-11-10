using System;
using System.Linq;

class Aleatorio
{

    public static void Main()
    {

        int[] n = new int[20];
        Random NumerosAleatoriosParaOArray = new Random();

        for (int i = 0; i < n.Length; i++)
        {
            n[i] = NumerosAleatoriosParaOArray.Next(100);
            Console.WriteLine(n[i]);
        }

        int menorNumeroDoVetor = Menor(n);
        int posicaodoVetor = posicao(n,menorNumeroDoVetor);
        Console.WriteLine("o menor valor é: {0}, e a sua posição é {1}", menorNumeroDoVetor,posicaodoVetor);

    }

    public static int Menor(int[] n)
    {

        int numeroMenor = n.Min();
        return numeroMenor;
    }

public static int posicao(int[] n, int menorNumeroDoVetor){

        int indice = Array.IndexOf(n, menorNumeroDoVetor) +1;
        return indice;
}

}