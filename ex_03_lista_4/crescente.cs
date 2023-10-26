using System;

class crescente
{
    static void Main()
    {
        Crescente();

    }
    static void Crescente()
    {
        Console.WriteLine("Quantos Conjuntos de 3 numeros irão ser comparados?");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] numeros = new int[3];
            Console.WriteLine("Digite o primeiro numero");
            numeros[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            numeros[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero terceiro");
            numeros[2] = int.Parse(Console.ReadLine());
            Array.Sort(numeros);
             Console.WriteLine("Números ordenados em ordem crescente: " + string.Join(", ", numeros));
        }


    }
}
