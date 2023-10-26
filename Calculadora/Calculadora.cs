using System;
class Calculadora
{
    static void Main()
    {
        Console.WriteLine("-----Calculadora do dantin-----");
        Console.WriteLine("1-Soma");
        Console.WriteLine("2-Subtracao");
        Console.WriteLine("3-Divisao");
        Console.WriteLine("4-Multiplicacao");

        int opcao = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite o primeiro numero");
        int num1 = int.Parse(Console.ReadLine());


        Console.WriteLine("digite o segundo numero");
        int num2 = int.Parse(Console.ReadLine());

        int Resultado = 0;

        switch (opcao)
        {
            case 1:
               Resultado = Adicao(num1, num2);
                break;
                case 2 :
                Resultado = Subtracao(num1, num2);
                break;
                case 3:
                Resultado = divisao(num1,num2);
                break;
                case 4:
                Resultado = Multiplicacao(num1,num2);
                break;
            default:
                break;
        }


        Console.WriteLine("resultado " + Resultado);
    }
    static int Adicao(int x, int y)
    {
        int Resultado = x + y;
        return Resultado;

    }

    static int Subtracao(int x, int y)
    {
        int  Resultado = x-y;
        return Resultado;
    }
    static int divisao(int x, int y){

        int Resultado = x / y;
        return Resultado;
    }
    static int Multiplicacao(int x, int y){
        int Resultado = x *  y;
        return Resultado;
    }

}