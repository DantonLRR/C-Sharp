using System;


class Triangulo
{

    static void Main()
    {
        Console.WriteLine("Digite o Valor Do primeiro lado do triangulo");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Valor Do segundo lado do triangulo");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Valor Do terceiro lado do triangulo");
        int z = int.Parse(Console.ReadLine());

        verificacao(x, y, z);



    }


    static void verificacao(int x, int y, int z)
    {
        if (x + y > z && x + z > y && y + z > x)
        {
            Console.WriteLine("É um triângulo");

            if (x == y && y == z)
            {
                Console.WriteLine("Os valores que você digitou, corresponde a um Triângulo Equilátero (todos os lados são iguais).");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Os valores que você digitou, corresponde a um Triângulo Isósceles (dois lados são iguais).");
            }
            else
            {
                Console.WriteLine("Os valores que você digitou, corresponde a um Triângulo Escaleno (todos os lados são diferentes).");
            }
        }
        else
        {
            Console.WriteLine("Não é um triângulo");
        }
    }
}






}